using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IxosTest2
{
    public partial class frmPleaseWait : Form
    {
        public frmPleaseWait()
        {
            InitializeComponent();
            this.pgbPercentDone.MarqueeAnimationSpeed = 30;
            this.pgbPercentDone.Style = ProgressBarStyle.Marquee;
            this.pgbPercentDone.Enabled = true;
            //this.pgbPercentDone.e
        }
    }
}
