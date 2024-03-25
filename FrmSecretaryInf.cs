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
    public partial class FrmSecretaryInf : Form
    {
        public FrmSecretaryInf()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();    
        public string tc;
        private void FrmSecretaryInf_Load(object sender, EventArgs e)
        {
            //Name and Surname Transfer
            label9.Text = tc;
            SqlCommand komut = new SqlCommand("Select SecretaryName,SecretarySurname From Tbl_Secretary Where SecretaryTC = @p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label9.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label7.Text= dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();



            //Departs Table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Departs" , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctors Transfer 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select DoctorName , DoctorSurname , DoctorDepart From Table_Doctors   " , bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            

         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Appointments (AppointmentDate , AppointmentTime , AppointmentDepart , AppointmentDoctor ) values (@p1 , @p2 , @p3, @p4)" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2" , maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4" , comboBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment has been created." , "Information" , MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Doctors Transfer to ComboBox 
            comboBox2.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName , DoctorSurname from Table_Doctors where DoctorDepart = @p1 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            if (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Insert Into Table_Notifications (Notification) values (@p1)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1" , richTextBox1.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notification has been created . ", "Information", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDocPanel frm = new FrmDocPanel();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDepart frm2 = new FrmDepart();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frm3 = new FrmAppointmentList(); 
            frm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
