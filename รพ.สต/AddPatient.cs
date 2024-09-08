using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace รพ.สต
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frm_home = new Menu();
            frm_home.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Menu frm_home = new Menu();
            frm_home.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            PatientMedicalRecord frm_Patient = new PatientMedicalRecord();
            frm_Patient.Show();
            this.Hide();
        }
    }
}
