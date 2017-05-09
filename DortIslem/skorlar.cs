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
    public partial class skorlar : Form
    {
        public skorlar()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=data.mdb;");

        public struct skorListe
        {
            public string isim;
            public int sure;
            public int skor;
            public string tarih;

            public skorListe(string i, int s, int sk, string t)
            {
                isim = i;
                sure = s;
                skor = sk;
                tarih = t;
            }
        }

        public static List<skorListe> SKORLAR = new List<skorListe>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skorlar_Load(object sender, EventArgs e)
        {
            skorGrid.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn();
            noColumn.DataPropertyName = "c1";
            noColumn.HeaderText = "#";

            DataGridViewTextBoxColumn isimColumn = new DataGridViewTextBoxColumn();
            isimColumn.DataPropertyName = "isim";
            isimColumn.HeaderText = "İsim";

            DataGridViewTextBoxColumn sureColumn = new DataGridViewTextBoxColumn();
            sureColumn.DataPropertyName = "sure";
            sureColumn.HeaderText = "Süre";

            DataGridViewTextBoxColumn skorColumn = new DataGridViewTextBoxColumn();
            skorColumn.DataPropertyName = "skor";
            skorColumn.HeaderText = "Skor";

            DataGridViewTextBoxColumn tarihColumn = new DataGridViewTextBoxColumn();
            tarihColumn.DataPropertyName = "tarih";
            tarihColumn.HeaderText = "Tarih";

            skorGrid.Columns.Add(noColumn);
            skorGrid.Columns.Add(isimColumn);
            skorGrid.Columns.Add(sureColumn);
            skorGrid.Columns.Add(skorColumn);
            skorGrid.Columns.Add(tarihColumn);
            //-------------------------------------------------


            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT TOP 10 isim,sure,skor,tarih FROM skorlar ORDER BY skor DESC,sure ASC";

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                skorListe rec = new skorListe(reader.GetValue(0).ToString(), int.Parse(reader.GetValue(1).ToString()), int.Parse(reader.GetValue(2).ToString()), reader.GetValue(3).ToString());
                SKORLAR.Add(rec);
            }

            conn.Close();


            DataTable dt = new DataTable();
            dt.Columns.Add("c1");
            dt.Columns.Add("isim");
            dt.Columns.Add("sure");
            dt.Columns.Add("skor");
            dt.Columns.Add("tarih");

            for (int i = 0; i < SKORLAR.Count; i++)
            {
                dt.Rows.Add((i + 1), SKORLAR[i].isim, SKORLAR[i].sure, SKORLAR[i].skor, SKORLAR[i].tarih);
            }

            skorGrid.DataSource = dt;
            skorGrid.Refresh();
        }
    }
}
