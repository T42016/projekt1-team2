using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Quiz : Form
    {
        private bool aClicked;
        private bool bClicked;
        private bool cClicked;
        private bool dClicked;
        int rätt = 0;
        Random r =new Random();
        int questionNr = 0;
        int i = 0;
        string[] cate = {"Biologi", "Geografi", "Historia", "Tvspel", "Teknik"};
        List<Question> Questions = new List<Question>();
        


        public Quiz(List<Question> frågor)
        {

            Questions = frågor;
            InitializeComponent();

        }

        private void SvarA_Click(object sender, EventArgs e)
        {
            Nästa.Enabled = true;
            SvarA.UseVisualStyleBackColor = true;
            SvarB.UseVisualStyleBackColor = true;
            SvarC.UseVisualStyleBackColor = true;
            SvarD.UseVisualStyleBackColor = true;
            aClicked = true;

        }

        private void SvarB_Click(object sender, EventArgs e)
        {
            Nästa.Enabled = true;
            SvarA.UseVisualStyleBackColor = true;
            SvarB.UseVisualStyleBackColor = true;
            SvarC.UseVisualStyleBackColor = true;
            SvarD.UseVisualStyleBackColor = true;
            bClicked = true;
        }

        private void SvarC_Click(object sender, EventArgs e)
        { 
            Nästa.Enabled = true;
            SvarA.UseVisualStyleBackColor = true;
            SvarB.UseVisualStyleBackColor = true;
            SvarC.UseVisualStyleBackColor = true;
            SvarD.UseVisualStyleBackColor = true;
            cClicked = true;
        }

        private void SvarD_Click(object sender, EventArgs e)
        {
            Nästa.Enabled = true;
            SvarA.UseVisualStyleBackColor = true;
            SvarB.UseVisualStyleBackColor = true;
            SvarC.UseVisualStyleBackColor = true;
            SvarD.UseVisualStyleBackColor = true;
            dClicked = true;
        }

        private void SvarA_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.UseVisualStyleBackColor = false;
            b.BackColor = Color.LightBlue;
        }

        private void SvarA_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.UseVisualStyleBackColor = true;
        }

        private void aw(object sender, EventArgs e)
        {

        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // På grund av Quiz_FormClosing så behövs det ingen textruta här då enbart Close() skickar en till
            // Quiz_FormClosing
            Close();
        }

        private void tillbakaTillMenynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // För att man inte ska komma direkt tillbaka till menyn 
            // vid händelse av ett feltryck öppnas det en text ruta som 
            // kräver ett definitivt svar
            if (MessageBox.Show("Vill du verkligen återvända till menyn?", "Meme Machine",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void startaSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SvarA.Enabled = true;
            SvarB.Enabled = true;
            SvarC.Enabled = true;
            SvarD.Enabled = true;
            i = 0;
            questionNr = r.Next(0, Questions.Count);
            Questions[questionNr].ShuffleAnswers();
            FrågFält_A.Text = Questions[questionNr].answers[0];
            FrågFält_B.Text = Questions[questionNr].answers[1];
            FrågFält_C.Text = Questions[questionNr].answers[2];
            FrågFält_D.Text = Questions[questionNr].answers[3];
            QuizBox.Text = Questions[questionNr].query;
        }

        private void Quiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            // För att spelet inte ska stängas av direkt
            // vid händelse av ett feltryck öppnas det en text ruta som 
            // kräver ett definitivt svar
            if (DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Vill du verkligen avsluta programmet?", "Meme Machine",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    DialogResult = DialogResult.Abort;
                else
                    e.Cancel = true;
            }
        }

        private void Nästa_Click(object sender, EventArgs e)
        {
            
            i++;
            Nästa.Enabled = false;

            
            if (aClicked)
            {
                if (FrågFält_A.Text == Questions[questionNr].rightAnswer)
                rätt++;
                
                else
                SvarA.BackColor = Color.Red;
                
            }
            else if (bClicked)
            { 
                if (FrågFält_B.Text == Questions[questionNr].rightAnswer)
                rätt++;
                 
                
                else
                SvarB.BackColor = Color.Red;
                
            }
            else if (cClicked)
            {
                if (FrågFält_C.Text == Questions[questionNr].rightAnswer)
                    rätt++;

                else
                SvarC.BackColor = Color.Red;
                
            }
            else if (dClicked)
            {
                if (FrågFält_D.Text == Questions[questionNr].rightAnswer)
                rätt++;
                    
                
                else
                SvarD.BackColor = Color.Red;
                
            }
            if (FrågFält_A.Text == Questions[questionNr].rightAnswer)
                SvarA.BackColor = Color.Green;
            if (FrågFält_B.Text == Questions[questionNr].rightAnswer)
                SvarB.BackColor = Color.Green;
            if (FrågFält_C.Text == Questions[questionNr].rightAnswer)
                SvarC.BackColor = Color.Green;
            if (FrågFält_D.Text == Questions[questionNr].rightAnswer)
                SvarD.BackColor = Color.Green;
            


            if (i < 3)
            {
                Questions.RemoveAt(questionNr);
                questionNr = r.Next(0, Questions.Count);
                Questions[questionNr].ShuffleAnswers();
                FrågFält_A.Text = Questions[questionNr].answers[0];
                FrågFält_B.Text = Questions[questionNr].answers[1];
                FrågFält_C.Text = Questions[questionNr].answers[2];
                FrågFält_D.Text = Questions[questionNr].answers[3];
                QuizBox.Text = Questions[questionNr].query;
            }
            else
            {
                SvarA.Enabled = false;
                SvarB.Enabled = false;
                SvarC.Enabled = false;
                SvarD.Enabled = false;
                Nästa.Enabled = false;
                if ((MessageBox.Show("Spelet är över: Du fick " + rätt + " rätt svar", "Meme Machine",
                MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                    
                }

            }
            aClicked = false;
            bClicked = false;
            cClicked = false;
            dClicked = false;
        }
    }
}