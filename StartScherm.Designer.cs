namespace LivePerformance2016
{
    partial class StartScherm
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
            this.bttnLocal = new System.Windows.Forms.Button();
            this.cbTelgebied = new System.Windows.Forms.ComboBox();
            this.cbProjecten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnLocal
            // 
            this.bttnLocal.Location = new System.Drawing.Point(118, 263);
            this.bttnLocal.Name = "bttnLocal";
            this.bttnLocal.Size = new System.Drawing.Size(108, 45);
            this.bttnLocal.TabIndex = 1;
            this.bttnLocal.Text = "Start";
            this.bttnLocal.UseVisualStyleBackColor = true;
            this.bttnLocal.Click += new System.EventHandler(this.bttnLocal_Click);
            // 
            // cbTelgebied
            // 
            this.cbTelgebied.FormattingEnabled = true;
            this.cbTelgebied.Location = new System.Drawing.Point(55, 109);
            this.cbTelgebied.Name = "cbTelgebied";
            this.cbTelgebied.Size = new System.Drawing.Size(229, 24);
            this.cbTelgebied.TabIndex = 2;
            // 
            // cbProjecten
            // 
            this.cbProjecten.FormattingEnabled = true;
            this.cbProjecten.Location = new System.Drawing.Point(55, 179);
            this.cbProjecten.Name = "cbProjecten";
            this.cbProjecten.Size = new System.Drawing.Size(229, 24);
            this.cbProjecten.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tel gebied:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Projecten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOVON";
            // 
            // StartScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProjecten);
            this.Controls.Add(this.cbTelgebied);
            this.Controls.Add(this.bttnLocal);
            this.Name = "StartScherm";
            this.Text = "StartScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnLocal;
        private System.Windows.Forms.ComboBox cbTelgebied;
        private System.Windows.Forms.ComboBox cbProjecten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}