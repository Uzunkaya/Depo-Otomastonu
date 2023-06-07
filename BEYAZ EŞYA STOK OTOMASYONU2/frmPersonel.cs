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

namespace BEYAZ_EŞYA_STOK_OTOMASYONU2
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-88ECQKK\\MSSQLSERVER02;Initial Catalog=Giriş_stok;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from parola1 where ad=@adi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("@adi", textBox1.Text.TrimEnd());
                SqlParameter prm2 = new SqlParameter("@sifresi", textBox2.Text.TrimEnd());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmSatış fr = new frmSatış();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
