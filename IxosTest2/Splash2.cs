using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IxosTest2
{
    public partial class Splash2 : Form
    {
        public Splash2()
        {
            InitializeComponent();
        }

        private void Splash2_Load(object sender, EventArgs e)
        {
            //this.Show();
            this.FormBorderStyle = FormBorderStyle.None;
            //Thread.Sleep(5000);
            //Form1 frm = new Form1();
            //frm.Show();
            //this.Close();
        }

        private void Splash2_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
