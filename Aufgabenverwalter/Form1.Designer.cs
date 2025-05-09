namespace Aufgabenverwalter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            aufgabeHinzufügenToolStripMenuItem = new ToolStripMenuItem();
            btnAddTask = new Button();
            btnShowTasks = new Button();
            btnDeleteTask = new Button();
            btnEditTask = new Button();
            lstTasks = new ListBox();
            cmbPriority = new ComboBox();
            dtpDueDate = new DateTimePicker();
            txtTaskDescription = new TextBox();
            Test = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aufgabeHinzufügenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aufgabeHinzufügenToolStripMenuItem
            // 
            aufgabeHinzufügenToolStripMenuItem.Name = "aufgabeHinzufügenToolStripMenuItem";
            aufgabeHinzufügenToolStripMenuItem.Size = new Size(88, 24);
            aufgabeHinzufügenToolStripMenuItem.Text = "Aufgaben";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.SteelBlue;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(11, 57);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Hinzufügen";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnShowTasks
            // 
            btnShowTasks.BackColor = Color.SteelBlue;
            btnShowTasks.FlatStyle = FlatStyle.Flat;
            btnShowTasks.ForeColor = Color.White;
            btnShowTasks.Location = new Point(111, 57);
            btnShowTasks.Name = "btnShowTasks";
            btnShowTasks.Size = new Size(94, 29);
            btnShowTasks.TabIndex = 2;
            btnShowTasks.Text = "Anzeigen";
            btnShowTasks.UseVisualStyleBackColor = false;
            btnShowTasks.Click += btnShowTasks_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.SteelBlue;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(111, 90);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(94, 29);
            btnDeleteTask.TabIndex = 3;
            btnDeleteTask.Text = "Löschen";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.SteelBlue;
            btnEditTask.FlatStyle = FlatStyle.Flat;
            btnEditTask.ForeColor = Color.White;
            btnEditTask.Location = new Point(12, 90);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(93, 29);
            btnEditTask.TabIndex = 4;
            btnEditTask.Text = "Bearbeiten";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // lstTasks
            // 
            lstTasks.BackColor = Color.SteelBlue;
            lstTasks.ForeColor = SystemColors.Window;
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(11, 125);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(337, 164);
            lstTasks.TabIndex = 5;
            // 
            // cmbPriority
            // 
            cmbPriority.BackColor = Color.SteelBlue;
            cmbPriority.FlatStyle = FlatStyle.Flat;
            cmbPriority.ForeColor = Color.White;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(211, 57);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 6;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(368, 57);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 7;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.BackColor = Color.SteelBlue;
            txtTaskDescription.ForeColor = Color.White;
            txtTaskDescription.Location = new Point(354, 125);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(166, 27);
            txtTaskDescription.TabIndex = 8;
            // 
            // Test
            // 
            Test.Location = new Point(492, 224);
            Test.Name = "Test";
            Test.Size = new Size(94, 29);
            Test.TabIndex = 9;
            Test.Text = "button1";
            Test.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Test);
            Controls.Add(txtTaskDescription);
            Controls.Add(dtpDueDate);
            Controls.Add(cmbPriority);
            Controls.Add(lstTasks);
            Controls.Add(btnEditTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnShowTasks);
            Controls.Add(btnAddTask);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aufgabeHinzufügenToolStripMenuItem;
        private Button btnAddTask;
        private Button btnShowTasks;
        private Button btnDeleteTask;
        private Button btnEditTask;
        private ListBox lstTasks;
        private ComboBox cmbPriority;
        private DateTimePicker dtpDueDate;
        private TextBox txtTaskDescription;
        private Button Test;
    }
}
