using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            oyun oyna = new oyun();
            oyna.Show();
            this.Hide();
        }

        private void thropyBtn_Click(object sender, EventArgs e)
        {
            skorlar x = new skorlar();
            x.ShowDialog();
        }

       
    }
}
