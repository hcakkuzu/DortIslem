using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DortIslem
{
    public partial class sonEkran : Form
    {
        public sonEkran()
        {
            InitializeComponent();
        }


        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=data.mdb;");


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            anaMenu form = new anaMenu();
            form.Show();
        }

        private void sonEkran_Load(object sender, EventArgs e)
        {
            isimLbl.Text = Program.isim;
            skorLbl.Text = Program.skor.ToString();
            kZamanLbl.Text = (Program.sure).ToString();

            conn.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO skorlar([isim],[sure],[skor],[tarih]) VALUES(@isim,@sure,@skor,@tarih)", conn);
            cmd.Parameters.AddWithValue("@isim", isimLbl.Text);
            cmd.Parameters.AddWithValue("@sure", kZamanLbl.Text);
            cmd.Parameters.AddWithValue("@skor", Program.skor);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
            
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
