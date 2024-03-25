using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSecretary_Click(object sender, EventArgs e)
        {
            FrmSecretary fr = new FrmSecretary();   
            fr.Show();
            this.Hide();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            FrmPatient fr = new FrmPatient();
            fr.Show();
            this.Hide();
        }

        private void BtnDoc_Click(object sender, EventArgs e)
        {
            FrmDoc fr = new FrmDoc();
            fr.Show();
            this.Hide();    
        }
    }
}
