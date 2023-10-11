using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cBhlubsi.Checked =  lbhlubsi.Visible = true;
        }

        private void cbBarva_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbBarva.SelectedItem = 1;
            
        }
        private void Spocitej()
        { 
            
        }

        private void lbS_Click(object sender, EventArgs e)
        {

        }

        private void traBaNas_Scroll(object sender, EventArgs e)
        {
            int val;
            val = traBaNas.Value;
            
            lbS.Text = "Posuvnik nastaveno: " + val.ToString();
        }

        private void textBA_TextChanged(object sender, EventArgs e)
        {

        }

        private void laSoucet_Click(object sender, EventArgs e)
        {
            
        }
        private void Soucet()
        {
            String A, B;
            int Soucet;

            A = textBA.Text;
            B = textBB.Text;

            int Ai = int.Parse(A);
            int Bi = int.Parse(B);

            Soucet = Ai + Bi;

            laSoucet.Text = Soucet.ToString();
        }

        private void cBdelsi_CheckedChanged(object sender, EventArgs e)
        {
            cBdelsi.Checked = LbDelsi.Visible = true;
        }

        private void cBvyssi_CheckedChanged(object sender, EventArgs e)
        {
             
            cBvyssi.Checked = lbvyssi.Visible = true;
        }
    }
}
