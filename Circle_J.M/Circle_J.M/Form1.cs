﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle_J.M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            // Has always to be the first line of the overriden OnPaint-Method.
            base.OnPaint(e);
            // Get the graphics object.
            Graphics graphics = e.Graphics;
            

            SolidBrush brush = new SolidBrush(Color.Red);

            e.Graphics.FillEllipse(brush,(this.ClientSize.Width/2 -50),(this.ClientSize.Height/2-50),100,100);

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
