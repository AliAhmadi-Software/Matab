using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matab
{
    public partial class frmlogo : Form
    {
        public frmlogo()
        {
            InitializeComponent();
            //
            timer1.Start();
        }
        string S = "به نرم افزار جامع مدیریت مطب خوش آمدید\n" + "از اینکه نرم افزار ما را انتخاب کردید از شما متشکریم";
        int MyTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.02;
            }
            //
            MyTime++;
            LblCenter.Text = S.Substring(0, MyTime);
            if (MyTime == S.Length)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void frmlogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                timer1.Stop();
            }
        }
    }
}
