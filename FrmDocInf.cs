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
    public partial class FrmDocInf : Form
    {
        public FrmDocInf()
        {
            InitializeComponent();
        }
        
        public string tc;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDocInf_Load(object sender, EventArgs e)
        {
            label3.Text = tc;
            SqlCommand komut = new SqlCommand("select DoctorName , DoctorSurname from Table_Doctors where DoctorTC=@p1 " , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , tc );
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr[0] + " " +dr[1];
            }
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
