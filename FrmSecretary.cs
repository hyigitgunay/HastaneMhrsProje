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
    public partial class FrmSecretary : Form
    {
        public FrmSecretary()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSecretary_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Secretary Where SecretaryTC = @p1 and SecretaryPassword=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskdTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryInf frm = new FrmSecretaryInf();
                frm.tc = MskdTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your password or Tc number is incorrect");
            }
        }
    }
}
