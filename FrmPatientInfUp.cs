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
    public partial class FrmPatientInfUp : Form
    {
        public FrmPatientInfUp()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmPatientInfUp_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Table_Patients where PatientTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurn.Text = dr[2].ToString(); 
                MskPhone.Text = dr[4].ToString();
                TxtPassw.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
