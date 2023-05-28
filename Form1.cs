using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_19_keke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZbZSe6N_BXs");
        }

        private void SwedenLLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=aBkTkxKDduc");
        }

        private void ValikkoTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=LOsOynOl8cE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=k1BneeJTDcU");
        }

        private void jooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JooLLB.Visible = true;
            WhyLLB.Visible = false;
            SwedenLLB.Visible = false;
            EiLB.Visible = false;
        }

        private void enOleVarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhyLLB.Visible = true;
            JooLLB.Visible = false;
            EiLB.Visible = false;
            SwedenLLB.Visible = false;
        }

        private void eiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EiLB.Visible = true;
            JooLLB.Visible=false;
            WhyLLB.Visible = false;
            SwedenLLB.Visible = false;
        }

        private void rauhallistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwedenLLB.Visible = true;
            EiLB.Visible = false;
            JooLLB.Visible = false;
            WhyLLB.Visible = false;
        }

        private void EminemBT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=D4hAVemuQXY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Tm8LGxTLtQk");
        }

        private void TextBT_Click(object sender, EventArgs e)
        {
            
            
            if (ValikkoTB.Text == "1")
            {
                EminemBT.Visible = true;
                ChesterBT.Visible = true;
                SkylarBT.Visible = true;    
                InternetBT.Visible = false;
            }
            else if (ValikkoTB.Text == "2")
            {
                InternetBT.Visible = true;
                EminemBT.Visible = false;
                ChesterBT.Visible = false;
            }
        }

        
    }
}
