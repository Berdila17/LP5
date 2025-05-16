using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aufgabenverwalter;

namespace Aufgabenverwalter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.AddRange(new[] { "Hoch", "Mittel", "Niedrig" });
            cmbPriority.SelectedIndex = 0;
            LadeBenutzer();
            LadeAufgabenAusDatenbank();
        }

        private void LadeBenutzer()
        {
            cmbBenutzer.Items.Clear();

            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=lp5;Trusted_Connection=True;"))
            {
                string query = "SELECT id, name FROM Benutzer";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    cmbBenutzer.Items.Add(new BenutzerItem { Id = id, Name = name });
                }
            }

            if (cmbBenutzer.Items.Count > 0)
                cmbBenutzer.SelectedIndex = 0;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskDescription = txtTaskDescription.Text.Trim();
            if (string.IsNullOrEmpty(taskDescription))
            {
                MessageBox.Show("Bitte eine gültige Aufgabe eingeben.");
                return;
            }

            string priority = cmbPriority.SelectedItem?.ToString() ?? "Mittel";
            DateTime dueDate = dtpDueDate.Value;

            DbHelper.InsertTask(taskDescription, priority, dueDate); // benutzerId = 1 als Standard

            MessageBox.Show("✅ Aufgabe gespeichert!");
            txtTaskDescription.Clear();
            cmbPriority.SelectedIndex = 0;

            LadeAufgabenAusDatenbank();
        }

        private void btnShowTasks_Click(object sender, EventArgs e)
        {
            LadeAufgabenAusDatenbank();
        }

        private void LadeAufgabenAusDatenbank()
        {
            lstTasks.Items.Clear();
            var aufgaben = DbHelper.LadeAlleAufgaben(); // noch ohne Benutzerfilter

            foreach (var aufgabe in aufgaben)
            {
                lstTasks.Items.Add(new ListItem { Id = aufgabe.Id, Text = aufgabe.Anzeige });
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is ListItem selected)
            {
                DbHelper.DeleteTask(selected.Id);
                MessageBox.Show("❌ Aufgabe gelöscht");
                LadeAufgabenAusDatenbank();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Aufgabe zum Löschen aus.");
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bearbeiten-Funktion funktioniert aktuell nur visuell in der Liste.\nIn der Datenbank muss sie noch eingebaut werden.");
        }

        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string taskEntry = lstTasks.Items[e.Index].ToString();

            Color color = Color.Black;
            if (taskEntry.Contains("Hoch"))
                color = Color.Red;
            else if (taskEntry.Contains("Niedrig"))
                color = Color.Green;

            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, taskEntry, e.Font, e.Bounds, color);
            e.DrawFocusRectangle();
        }

        private class ListItem
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public override string ToString() => Text;
        }

        private class BenutzerItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }
    }
}

