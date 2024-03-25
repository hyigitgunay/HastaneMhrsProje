using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatSignup frm = new FrmPatSignup();
            frm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Patients Where PatientTC=@p1 and PatientPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskdTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientInf frm = new FrmPatientInf();
                frm.tc = MskdTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Tc or Password is incorrect.");
            }
            bgl.baglanti().Close();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
