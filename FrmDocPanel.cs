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
    public partial class FrmDocPanel : Form
    {
        public FrmDocPanel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDocPanel_Load(object sender, EventArgs e)
        {
            //Made a DataGrid Table
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Doctors " , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Table_Doctors (DoctorName , DoctorSurname , DoctorDepart , DoctorTC , DoctorPassword) values (@p1 , @p2 , @p3 , @p4 , @p5)" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2" , textBox3.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p5", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Added. ", "Information", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete  from Table_Doctors where DoctorTC = @p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1" ,maskedTextBox1.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor Deleted. ", "Information", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Table_Doctors set DoctorName = @p1 , DoctorSurname = @p2 , DoctorDepart = @p3  , DoctorPassword = @p5 where DoctorTC = @p4 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1" ,textBox1.Text);
            komut3.Parameters.AddWithValue("@p2", textBox3.Text);
            komut3.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut3.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut3.Parameters.AddWithValue("@p5", textBox2.Text);
            komut3.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Information Has Been Changed. ", "Information", MessageBoxButtons.OK);
        }
    }
}
