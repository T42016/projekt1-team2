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
    public partial class Försätts : Form
    {
        public Försätts()
        {
            InitializeComponent();
        }

        private void BiologiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Quiz().Show();
            this.Hide();
        }

        private void Försätts_Load(object sender, EventArgs e)
        {

        }
    }
}
