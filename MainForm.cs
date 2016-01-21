using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance2016.CSharp;
using LivePerformance2016.CSharp.Data;

namespace LivePerformance2016
{
    public partial class MainForm : Form
    {
        private Administratie admin;
        private Point Pos2 = new Point();
        private Point Pos1 = new Point();

        public MainForm()
        {
            InitializeComponent();
            admin = new Administratie();
            VulDropdown();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbType.SelectedItem != null)
            {
                string geselecteerdekeuze = cbType.SelectedText;
                Diersoort d = admin.Findvogel(geselecteerdekeuze); ;
                Pos1 = e.Location;
                
                Label label = new Label();
                label.Width = 25;
                label.Height = 25;
                label.Text = d.Afkorting;
                label.Location = Pos1;
                label.Click += new EventHandler(clickLabel);
                this.panel1.Controls.Add(label);
                }
            else
            {
                MessageBox.Show("Geef een type vogel op");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bttnOpslaan_Click(object sender, EventArgs e)
        {
            
        }

        private void clickLabel(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void VulDropdown()
        {
            foreach (Diersoort d in admin.Diersoorts)
            {
                cbType.Items.Add(d);
            }
        }
    }

}

