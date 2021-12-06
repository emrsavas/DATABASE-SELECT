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


namespace VERİ_TABANLI_PARTİ_SECİM
{
    public partial class FRMOYGİRİS : Form
    {
        public FRMOYGİRİS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NUIFV6S\SQLEXPRESS; Initial Catalog=DBSECIMPROJE; Integrated Security=True");


        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.open;
            sqlcommand komut = new sqlcommand("insert into TBLILCE (ILCEAD;APARTI;BPARTI;CPARTI;DPARTI;EPARTI) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValues("@P1", txtilçe.Text);
            komut.Parameters.AddWithValues("@P2", txta.Text);
            komut.Parameters.AddWithValues("@P3", txtb.Text);
            komut.Parameters.AddWithValues("@P4", txtc.Text);
            komut.Parameters.AddWithValues("@P5", txtd.Text);
            komut.Parameters.AddWithValues("@P6", txte.Text);
            komut.ExecuteNonQuery();
            baglanti.close();
            MessageBox.Show("Oy girişi TAMAM");



        }
    }
}
