using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using graphiccontrol;

namespace desenatorGCtrlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
              }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.userControl11.g.DrawEllipse(this.userControl11.pen0, 100, 100, 220, 210);
     
        }
    }
}
