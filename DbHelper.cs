using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aufgabenverwalter
{
    public static class DbHelper
    {
        private static string connStr = @"Server=localhost\SQLEXPRESS;Database=lp5;Trusted_Connection=True;";

        public static void InsertTask(string beschreibung, string prioritaet, DateTime faelligAm, int benutzerId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Aufgabe (titel, beschreibung, faellig_am, prioritaet, status, benutzer_id) " +
                               "VALUES (@titel, @beschreibung, @faellig_am, @prioritaet, @status, @benutzer_id)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titel", beschreibung);
                cmd.Parameters.AddWithValue("@beschreibung", beschreibung);
                cmd.Parameters.AddWithValue("@faellig_am", faelligAm);
                cmd.Parameters.AddWithValue("@prioritaet", prioritaet);
                cmd.Parameters.AddWithValue("@status", "offen");
                cmd.Parameters.AddWithValue("@benutzer_id", benutzerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<(int Id, string Anzeige)> LadeAlleAufgaben(int benutzerId)
        {
            var aufgabenListe = new List<(int, string)>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT id, titel, prioritaet, faellig_am FROM Aufgabe WHERE benutzer_id = @benutzer_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@benutzer_id", benutzerId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string titel = reader.GetString(1);
                        string prioritaet = reader.GetString(2);
                        DateTime faellig = reader.GetDateTime(3);

                        string eintrag = $"{titel} | Priorität: {prioritaet} | Fällig: {faellig.ToShortDateString()}";
                        aufgabenListe.Add((id, eintrag));
                    }
                }
            }

            return aufgabenListe;
        }

        public static void DeleteTask(int id)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "DELETE FROM Aufgabe WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateTask(int id, string neueBeschreibung)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE Aufgabe SET titel = @titel, beschreibung = @beschreibung WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titel", neueBeschreibung);
                cmd.Parameters.AddWithValue("@beschreibung", neueBeschreibung);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
