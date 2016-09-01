namespace Quiz
{
    partial class Försätts
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
            this.Wilkommen = new System.Windows.Forms.Label();
            this.Val = new System.Windows.Forms.Label();
            this.BiologiLink = new System.Windows.Forms.LinkLabel();
            this.GeografiLink = new System.Windows.Forms.LinkLabel();
            this.HistoriaLink = new System.Windows.Forms.LinkLabel();
            this.DataLink = new System.Windows.Forms.LinkLabel();
            this.TeknikLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Wilkommen
            // 
            this.Wilkommen.AutoSize = true;
            this.Wilkommen.Location = new System.Drawing.Point(350, 10);
            this.Wilkommen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Wilkommen.Name = "Wilkommen";
            this.Wilkommen.Size = new System.Drawing.Size(189, 24);
            this.Wilkommen.TabIndex = 0;
            this.Wilkommen.Text = "Välkommen till Quiz";
            // 
            // Val
            // 
            this.Val.AutoSize = true;
            this.Val.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Val.Location = new System.Drawing.Point(40, 50);
            this.Val.Name = "Val";
            this.Val.Size = new System.Drawing.Size(420, 22);
            this.Val.TabIndex = 1;
            this.Val.Text = "Varsågod och välj från vilket spännande Quiz ni vill";
            // 
            // BiologiLink
            // 
            this.BiologiLink.AutoSize = true;
            this.BiologiLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiologiLink.LinkColor = System.Drawing.Color.Black;
            this.BiologiLink.Location = new System.Drawing.Point(40, 100);
            this.BiologiLink.Name = "BiologiLink";
            this.BiologiLink.Size = new System.Drawing.Size(70, 22);
            this.BiologiLink.TabIndex = 2;
            this.BiologiLink.TabStop = true;
            this.BiologiLink.Text = "Biologi";
            this.BiologiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BiologiLink_LinkClicked);
            // 
            // GeografiLink
            // 
            this.GeografiLink.AutoSize = true;
            this.GeografiLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeografiLink.LinkColor = System.Drawing.Color.Black;
            this.GeografiLink.Location = new System.Drawing.Point(40, 150);
            this.GeografiLink.Name = "GeografiLink";
            this.GeografiLink.Size = new System.Drawing.Size(80, 22);
            this.GeografiLink.TabIndex = 3;
            this.GeografiLink.TabStop = true;
            this.GeografiLink.Text = "Geografi";
            this.GeografiLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GeografiLink_LinkClicked);
            // 
            // HistoriaLink
            // 
            this.HistoriaLink.AutoSize = true;
            this.HistoriaLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoriaLink.LinkColor = System.Drawing.Color.Black;
            this.HistoriaLink.Location = new System.Drawing.Point(40, 200);
            this.HistoriaLink.Name = "HistoriaLink";
            this.HistoriaLink.Size = new System.Drawing.Size(75, 22);
            this.HistoriaLink.TabIndex = 4;
            this.HistoriaLink.TabStop = true;
            this.HistoriaLink.Text = "Historia";
            this.HistoriaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HistoriaLink_LinkClicked);
            // 
            // DataLink
            // 
            this.DataLink.AutoSize = true;
            this.DataLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLink.LinkColor = System.Drawing.Color.Black;
            this.DataLink.Location = new System.Drawing.Point(40, 250);
            this.DataLink.Name = "DataLink";
            this.DataLink.Size = new System.Drawing.Size(116, 22);
            this.DataLink.TabIndex = 5;
            this.DataLink.TabStop = true;
            this.DataLink.Text = "Tv/Datorspel";
            this.DataLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DataLink_LinkClicked);
            // 
            // TeknikLink
            // 
            this.TeknikLink.AutoSize = true;
            this.TeknikLink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeknikLink.LinkColor = System.Drawing.Color.Black;
            this.TeknikLink.Location = new System.Drawing.Point(40, 300);
            this.TeknikLink.Name = "TeknikLink";
            this.TeknikLink.Size = new System.Drawing.Size(63, 22);
            this.TeknikLink.TabIndex = 6;
            this.TeknikLink.TabStop = true;
            this.TeknikLink.Text = "Teknik";
            this.TeknikLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TeknikLink_LinkClicked);
            // 
            // Försätts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 441);
            this.Controls.Add(this.TeknikLink);
            this.Controls.Add(this.DataLink);
            this.Controls.Add(this.HistoriaLink);
            this.Controls.Add(this.GeografiLink);
            this.Controls.Add(this.BiologiLink);
            this.Controls.Add(this.Val);
            this.Controls.Add(this.Wilkommen);
            this.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Försätts";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Försätts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wilkommen;
        private System.Windows.Forms.Label Val;
        private System.Windows.Forms.LinkLabel BiologiLink;
        private System.Windows.Forms.LinkLabel GeografiLink;
        private System.Windows.Forms.LinkLabel HistoriaLink;
        private System.Windows.Forms.LinkLabel DataLink;
        private System.Windows.Forms.LinkLabel TeknikLink;
    }
}