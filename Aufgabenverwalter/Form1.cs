

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            cmbBenutzer.SelectedIndexChanged += (s, e) => LadeAufgabenAusDatenbank();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.Add("Hoch");
            cmbPriority.Items.Add("Mittel");
            cmbPriority.Items.Add("Niedrig");

            if (cmbPriority.Items.Count > 0)
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

           
            DbHelper.InsertTask(taskDescription, priority, dueDate);

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
            if (cmbBenutzer.SelectedItem is not BenutzerItem selectedBenutzer)
                return;

            dgvTasks.Rows.Clear();
            dgvTasks.Columns.Clear();

            dgvTasks.Columns.Add("id", "ID");
            dgvTasks.Columns["id"].Visible = false; // ID nicht anzeigen

            dgvTasks.Columns.Add("titel", "Titel");
            dgvTasks.Columns.Add("prioritaet", "Priorität");
            dgvTasks.Columns.Add("faellig", "Fällig am");

            var aufgaben = DbHelper.LadeAlleAufgaben(selectedBenutzer.Id);
            foreach (var aufgabe in aufgaben)
            {
                string[] teile = aufgabe.Anzeige.Split('|');
                dgvTasks.Rows.Add(aufgabe.Id, teile[0].Trim(), teile[1].Split(':')[1].Trim(), teile[2].Split(':')[1].Trim());
            }
        }


        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wähle eine Aufgabe aus.");
                return;
            }

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["id"].Value);
            DbHelper.DeleteTask(id);
            MessageBox.Show("❌ Aufgabe gelöscht");
            LadeAufgabenAusDatenbank();
        }


        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte wähle eine Aufgabe aus.");
                return;
            }

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["id"].Value);
            string alterTitel = dgvTasks.SelectedRows[0].Cells["titel"].Value.ToString();

            string neuerText = Microsoft.VisualBasic.Interaction.InputBox("Neue Beschreibung:", "Aufgabe bearbeiten", alterTitel);
            if (!string.IsNullOrWhiteSpace(neuerText))
            {
                DbHelper.UpdateTask(id, neuerText);
                LadeAufgabenAusDatenbank();
            }
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
