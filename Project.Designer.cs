namespace LivePerformance2016
{
    partial class Project
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnNieuwProject = new System.Windows.Forms.Button();
            this.cbVelden = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeschrijving = new System.Windows.Forms.TextBox();
            this.dateTimePickerVan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTot = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnNieuwProject
            // 
            this.bttnNieuwProject.Location = new System.Drawing.Point(118, 463);
            this.bttnNieuwProject.Name = "bttnNieuwProject";
            this.bttnNieuwProject.Size = new System.Drawing.Size(174, 41);
            this.bttnNieuwProject.TabIndex = 0;
            this.bttnNieuwProject.Text = "Nieuw Project";
            this.bttnNieuwProject.UseVisualStyleBackColor = true;
            this.bttnNieuwProject.Click += new System.EventHandler(this.bttnNieuwProject_Click);
            // 
            // cbVelden
            // 
            this.cbVelden.FormattingEnabled = true;
            this.cbVelden.Location = new System.Drawing.Point(6, 310);
            this.cbVelden.Name = "cbVelden";
            this.cbVelden.Size = new System.Drawing.Size(174, 24);
            this.cbVelden.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerTot);
            this.groupBox1.Controls.Add(this.dateTimePickerVan);
            this.groupBox1.Controls.Add(this.txtBeschrijving);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Naam);
            this.groupBox1.Controls.Add(this.txtNaam);
            this.groupBox1.Controls.Add(this.cbVelden);
            this.groupBox1.Controls.Add(this.bttnNieuwProject);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 510);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuwproject";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(6, 68);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 22);
            this.txtNaam.TabIndex = 2;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(7, 45);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(49, 17);
            this.Naam.TabIndex = 3;
            this.Naam.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beschrijving";
            // 
            // txtBeschrijving
            // 
            this.txtBeschrijving.Location = new System.Drawing.Point(6, 117);
            this.txtBeschrijving.Multiline = true;
            this.txtBeschrijving.Name = "txtBeschrijving";
            this.txtBeschrijving.Size = new System.Drawing.Size(335, 166);
            this.txtBeschrijving.TabIndex = 5;
            // 
            // dateTimePickerVan
            // 
            this.dateTimePickerVan.Location = new System.Drawing.Point(6, 357);
            this.dateTimePickerVan.Name = "dateTimePickerVan";
            this.dateTimePickerVan.Size = new System.Drawing.Size(334, 22);
            this.dateTimePickerVan.TabIndex = 6;
            // 
            // dateTimePickerTot
            // 
            this.dateTimePickerTot.Location = new System.Drawing.Point(6, 417);
            this.dateTimePickerTot.Name = "dateTimePickerTot";
            this.dateTimePickerTot.Size = new System.Drawing.Size(334, 22);
            this.dateTimePickerTot.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Van:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tot:";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 543);
            this.Controls.Add(this.groupBox1);
            this.Name = "Project";
            this.Text = "Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnNieuwProject;
        private System.Windows.Forms.ComboBox cbVelden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTot;
        private System.Windows.Forms.DateTimePicker dateTimePickerVan;
        private System.Windows.Forms.TextBox txtBeschrijving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.TextBox txtNaam;
    }
}