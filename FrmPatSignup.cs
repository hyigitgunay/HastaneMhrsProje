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
    public partial class FrmPatSignup : Form
    {
        public FrmPatSignup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Patients (PatientName , PatientSurname , PatientTC , PatientTel , PatientPassword , PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtName.Text);
            komut.Parameters.AddWithValue("@p2", TxtSurn.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskPhone.Text);
            komut.Parameters.AddWithValue("@p5", TxtPassw.Text);
            komut.Parameters.AddWithValue("@p6", CmbGender.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your registration is completed.Your Password is : " + TxtPassw.Text, "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPatSignup_Load(object sender, EventArgs e)
        {
        
        }
    }
}
