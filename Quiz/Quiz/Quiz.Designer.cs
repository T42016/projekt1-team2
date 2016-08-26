namespace Quiz
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SvarA = new System.Windows.Forms.Button();
            this.SvarB = new System.Windows.Forms.Button();
            this.SvarC = new System.Windows.Forms.Button();
            this.SvarD = new System.Windows.Forms.Button();
            this.Avsluta = new System.Windows.Forms.Button();
            this.QuizBox = new System.Windows.Forms.Label();
            this.FrågFält_A = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FrågFält_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FrågFält_C = new System.Windows.Forms.Label();
            this.FrågFält_D = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startaSpelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tillbakaTillMenynToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SvarA
            // 
            this.SvarA.Enabled = false;
            this.SvarA.Location = new System.Drawing.Point(180, 310);
            this.SvarA.Name = "SvarA";
            this.SvarA.Size = new System.Drawing.Size(61, 58);
            this.SvarA.TabIndex = 0;
            this.SvarA.TabStop = false;
            this.SvarA.Text = "A";
            this.SvarA.UseVisualStyleBackColor = true;
            this.SvarA.Click += new System.EventHandler(this.SvarA_Click);
            this.SvarA.MouseEnter += new System.EventHandler(this.SvarA_MouseEnter);
            this.SvarA.MouseLeave += new System.EventHandler(this.SvarA_MouseLeave);
            // 
            // SvarB
            // 
            this.SvarB.Enabled = false;
            this.SvarB.Location = new System.Drawing.Point(320, 310);
            this.SvarB.Name = "SvarB";
            this.SvarB.Size = new System.Drawing.Size(61, 58);
            this.SvarB.TabIndex = 1;
            this.SvarB.TabStop = false;
            this.SvarB.Text = "B";
            this.SvarB.UseVisualStyleBackColor = true;
            this.SvarB.MouseEnter += new System.EventHandler(this.SvarA_MouseEnter);
            this.SvarB.MouseLeave += new System.EventHandler(this.SvarA_MouseLeave);
            // 
            // SvarC
            // 
            this.SvarC.Enabled = false;
            this.SvarC.Location = new System.Drawing.Point(460, 310);
            this.SvarC.Name = "SvarC";
            this.SvarC.Size = new System.Drawing.Size(61, 58);
            this.SvarC.TabIndex = 2;
            this.SvarC.TabStop = false;
            this.SvarC.Text = "C";
            this.SvarC.UseVisualStyleBackColor = true;
            this.SvarC.MouseEnter += new System.EventHandler(this.SvarA_MouseEnter);
            this.SvarC.MouseLeave += new System.EventHandler(this.SvarA_MouseLeave);
            // 
            // SvarD
            // 
            this.SvarD.Enabled = false;
            this.SvarD.Location = new System.Drawing.Point(600, 310);
            this.SvarD.Name = "SvarD";
            this.SvarD.Size = new System.Drawing.Size(61, 58);
            this.SvarD.TabIndex = 3;
            this.SvarD.TabStop = false;
            this.SvarD.Text = "D";
            this.SvarD.UseVisualStyleBackColor = true;
            this.SvarD.MouseEnter += new System.EventHandler(this.SvarA_MouseEnter);
            this.SvarD.MouseLeave += new System.EventHandler(this.SvarA_MouseLeave);
            // 
            // Avsluta
            // 
            this.Avsluta.Location = new System.Drawing.Point(700, 420);
            this.Avsluta.Name = "Avsluta";
            this.Avsluta.Size = new System.Drawing.Size(80, 40);
            this.Avsluta.TabIndex = 4;
            this.Avsluta.TabStop = false;
            this.Avsluta.Text = "Avsluta";
            this.Avsluta.UseVisualStyleBackColor = true;
            this.Avsluta.Click += new System.EventHandler(this.Avsluta_Click);
            this.Avsluta.MouseEnter += new System.EventHandler(this.Avsluta_MouseEnter);
            this.Avsluta.MouseLeave += new System.EventHandler(this.Avsluta_MouseLeave);
            // 
            // QuizBox
            // 
            this.QuizBox.Location = new System.Drawing.Point(180, 29);
            this.QuizBox.Name = "QuizBox";
            this.QuizBox.Size = new System.Drawing.Size(481, 100);
            this.QuizBox.TabIndex = 5;
            this.QuizBox.Text = "Frågfältet";
            // 
            // FrågFält_A
            // 
            this.FrågFält_A.Location = new System.Drawing.Point(220, 140);
            this.FrågFält_A.Name = "FrågFält_A";
            this.FrågFält_A.Size = new System.Drawing.Size(441, 24);
            this.FrågFält_A.TabIndex = 6;
            this.FrågFält_A.Text = "Svarsalternativ A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // FrågFält_B
            // 
            this.FrågFält_B.Location = new System.Drawing.Point(220, 180);
            this.FrågFält_B.Name = "FrågFält_B";
            this.FrågFält_B.Size = new System.Drawing.Size(441, 24);
            this.FrågFält_B.TabIndex = 8;
            this.FrågFält_B.Text = "Svarsalternativ B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "D";
            // 
            // FrågFält_C
            // 
            this.FrågFält_C.Location = new System.Drawing.Point(220, 220);
            this.FrågFält_C.Name = "FrågFält_C";
            this.FrågFält_C.Size = new System.Drawing.Size(441, 24);
            this.FrågFält_C.TabIndex = 12;
            this.FrågFält_C.Text = "Svarsalternativ C";
            // 
            // FrågFält_D
            // 
            this.FrågFält_D.Location = new System.Drawing.Point(220, 260);
            this.FrågFält_D.Name = "FrågFält_D";
            this.FrågFält_D.Size = new System.Drawing.Size(441, 24);
            this.FrågFält_D.TabIndex = 13;
            this.FrågFält_D.Text = "Svarsalternativ D";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(700, 40);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(80, 40);
            this.Start.TabIndex = 14;
            this.Start.Text = "Starta";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startaToolStripMenuItem,
            this.inställningarToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startaToolStripMenuItem
            // 
            this.startaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startaSpelToolStripMenuItem,
            this.tillbakaTillMenynToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.startaToolStripMenuItem.Name = "startaToolStripMenuItem";
            this.startaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startaToolStripMenuItem.Text = "Start";
            this.startaToolStripMenuItem.Click += new System.EventHandler(this.startaToolStripMenuItem_Click);
            // 
            // startaSpelToolStripMenuItem
            // 
            this.startaSpelToolStripMenuItem.Name = "startaSpelToolStripMenuItem";
            this.startaSpelToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.startaSpelToolStripMenuItem.Text = "Starta spel";
            this.startaSpelToolStripMenuItem.Click += new System.EventHandler(this.startaSpelToolStripMenuItem_Click);
            // 
            // tillbakaTillMenynToolStripMenuItem
            // 
            this.tillbakaTillMenynToolStripMenuItem.Name = "tillbakaTillMenynToolStripMenuItem";
            this.tillbakaTillMenynToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.tillbakaTillMenynToolStripMenuItem.Text = "Tillbaka till menyn";
            this.tillbakaTillMenynToolStripMenuItem.Click += new System.EventHandler(this.tillbakaTillMenynToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.inställningarToolStripMenuItem.Text = "Inställningar";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FrågFält_D);
            this.Controls.Add(this.FrågFält_C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrågFält_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FrågFält_A);
            this.Controls.Add(this.QuizBox);
            this.Controls.Add(this.Avsluta);
            this.Controls.Add(this.SvarD);
            this.Controls.Add(this.SvarC);
            this.Controls.Add(this.SvarB);
            this.Controls.Add(this.SvarA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quiz";
            this.Text = "w";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quiz_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SvarA;
        private System.Windows.Forms.Button SvarB;
        private System.Windows.Forms.Button SvarC;
        private System.Windows.Forms.Button SvarD;
        private System.Windows.Forms.Button Avsluta;
        private System.Windows.Forms.Label QuizBox;
        private System.Windows.Forms.Label FrågFält_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FrågFält_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FrågFält_C;
        private System.Windows.Forms.Label FrågFält_D;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startaSpelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tillbakaTillMenynToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
    }
}

