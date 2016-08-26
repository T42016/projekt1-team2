using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            
            InitializeComponent();
        }

        private void Avsluta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du verkligen avsluta programmet?", "Meme Machine",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void SvarA_Click(object sender, EventArgs e)
        {
            
        }
        private void SvarB_Click(object sender, EventArgs e)
        {

        }
        private void SvarC_Click(object sender, EventArgs e)
        {

        }

        private void SvarD_Click(object sender, EventArgs e)
        {

        }

        private void SvarA_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.UseVisualStyleBackColor = false;
            b.BackColor = Color.LightGreen;
        }
        private void SvarA_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.UseVisualStyleBackColor = true;
        }
        private void Avsluta_MouseEnter(object sender, EventArgs e)
        {
            Avsluta.UseVisualStyleBackColor = false;
            Avsluta.BackColor = Color.Red;
        }
        private void Avsluta_MouseLeave(object sender, EventArgs e)
        {
            Avsluta.UseVisualStyleBackColor = true;
        }

        private void aw(object sender, EventArgs e)
        {

        }


        private void startaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SvarA.Enabled = true;
            SvarB.Enabled = true;
            SvarC.Enabled = true;
            SvarD.Enabled = true;
        }      

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   if (MessageBox.Show("Vill du verkligen avsluta programmet?", "Meme Machine",
         //MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         //   {
                Close();
            //}
        }

        private void tillbakaTillMenynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du verkligen återvända till menyn?", "Meme Machine",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Försätts().Show();
                this.Hide();
            }
        }

        private void startaSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vill du verkligen avsluta programmet?", "Meme Machine",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
