﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            tbxUtdata.Clear();
            int nivå = int.Parse(tbxNivå.Text);
            //om i är mindre än talet jag skriver in på "nivå" så lägger programmet på 1 ända tills det når "nivå"//
            for (int i = 1; i <= nivå; i++) 
            { 
                for (int j = 1; j <= 10; j++) 
                    
                tbxUtdata.AppendText(i*j + "\t");
                tbxUtdata.AppendText( "\r\n" );
            }
        }
    }
}
