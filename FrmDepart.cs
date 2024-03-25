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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Hospital
{
 
    public partial class FrmDepart : Form
    {
        public FrmDepart()
        {
            InitializeComponent();
        }
          sqlbaglantisi bgl = new sqlbaglantisi();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmDepart_Load(object sender, EventArgs e)
        {
            //datagridview 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Departs " , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Departs
            SqlCommand komut = new SqlCommand("Insert Into Table_Departs ( DepartName) values ( @p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , textBox1.Text);
            komut.Parameters.AddWithValue("@p2" , textBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Depart Added. ", "Information", MessageBoxButtons.OK);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete button
            SqlCommand komut2 = new SqlCommand("Delete * From Table_Departs where DepartId = @p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBox1.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Depart deleted. ", "Information", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update button
            SqlCommand komut3 = new SqlCommand("Update Table_Departs Set DepartName=@p1 where DepartId = @p2" ,bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", textBox3.Text);
            komut3.Parameters.AddWithValue("@p2" ,textBox1.Text);    
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Depart updated. ", "Information", MessageBoxButtons.OK);



        }

    }
}
