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
    public partial class FrmPatientInf : Form
    {
        public FrmPatientInf()
        {
            InitializeComponent();
        }
        public string tc;
        public string gender;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientInfUp frm = new FrmPatientInfUp();
            frm.Show();
            this.Hide();

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmPatientInf_Load(object sender, EventArgs e)
        {
            //Name and Surname Transfer
            label3.Text = tc;
            SqlCommand komut = new SqlCommand("Select PatientName,PatientSurname,PatientGender from Table_Patients where PatientTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[0] + " " + dr[1];
                label5.Text = dr[2]+ " ";
            }
            bgl.baglanti().Close();

            //Appointments History
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where PatientTc="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Departmants Transfer 
            SqlCommand komut2 = new SqlCommand("Select DepartName From Table_Departs ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

          
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doctors 
            comboBox2.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName,DoctorSurname From Table_Doctors where DoctorDepart=@p1 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where AppointmentDepart= '" + comboBox1.Text + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("UPDATE Table_Patients SET PatientProblem = @p1 WHERE PatientTC = @p2", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut4.Parameters.AddWithValue("@p2", tc);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your appointment has been created . ", "Information", MessageBoxButtons.OK);
        }
    }
}
