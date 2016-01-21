using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2016.CSharp;


namespace LivePerformance2016
{
    public partial class StartScherm : Form
    {
        private Administratie admin;

        public StartScherm()
        {
            InitializeComponent();
            admin = new Administratie();
            fill();
        }

        private void bttnLocal_Click(object sender, EventArgs e)
        {
            string projectnaam = cbProjecten.SelectedItem.ToString();
            MainForm settingsForm = new MainForm();
            // Show the settings form
            settingsForm.Show();
        }

        public void fill()
        {
            foreach(CSharp.Project p in admin.Projecten)
            {
                cbProjecten.Items.Add(p);
            }
            foreach (CSharp.TelGebied t in admin.TelGebieden)
            {
                cbTelgebied.Items.Add(t);
            }
        }
    }
}
