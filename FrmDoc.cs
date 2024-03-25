using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrmDoc : Form
    {
        public FrmDoc()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FrmDoc_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Doctors where DoctorTC = @p1 and DoctorPassword = @p2",bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", MskdTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmDocInf frm = new FrmDocInf();
                frm.tc = MskdTC.Text; 
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Password is incorrect. ");
            }
            
        }
    }
}
