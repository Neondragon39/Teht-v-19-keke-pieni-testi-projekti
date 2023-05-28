namespace Tehtävä_19_keke
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tykkääköMusiikistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enOleVarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rauhallistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JooLLB = new System.Windows.Forms.LinkLabel();
            this.EiLB = new System.Windows.Forms.LinkLabel();
            this.SwedenLLB = new System.Windows.Forms.LinkLabel();
            this.WhyLLB = new System.Windows.Forms.LinkLabel();
            this.ValikkoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EminemBT = new System.Windows.Forms.Button();
            this.ChesterBT = new System.Windows.Forms.Button();
            this.SkylarBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InternetBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBT = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tykkääköMusiikistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tykkääköMusiikistaToolStripMenuItem
            // 
            this.tykkääköMusiikistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jooToolStripMenuItem,
            this.eiToolStripMenuItem,
            this.enOleVarmaToolStripMenuItem,
            this.rauhallistaToolStripMenuItem});
            this.tykkääköMusiikistaToolStripMenuItem.Name = "tykkääköMusiikistaToolStripMenuItem";
            this.tykkääköMusiikistaToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.tykkääköMusiikistaToolStripMenuItem.Text = "Tykkääkö musiikista?";
            // 
            // jooToolStripMenuItem
            // 
            this.jooToolStripMenuItem.Name = "jooToolStripMenuItem";
            this.jooToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.jooToolStripMenuItem.Text = "Joo";
            this.jooToolStripMenuItem.Click += new System.EventHandler(this.jooToolStripMenuItem_Click);
            // 
            // eiToolStripMenuItem
            // 
            this.eiToolStripMenuItem.Name = "eiToolStripMenuItem";
            this.eiToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.eiToolStripMenuItem.Text = "Ei";
            this.eiToolStripMenuItem.Click += new System.EventHandler(this.eiToolStripMenuItem_Click);
            // 
            // enOleVarmaToolStripMenuItem
            // 
            this.enOleVarmaToolStripMenuItem.Name = "enOleVarmaToolStripMenuItem";
            this.enOleVarmaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.enOleVarmaToolStripMenuItem.Text = "En ole varma";
            this.enOleVarmaToolStripMenuItem.Click += new System.EventHandler(this.enOleVarmaToolStripMenuItem_Click);
            // 
            // rauhallistaToolStripMenuItem
            // 
            this.rauhallistaToolStripMenuItem.Name = "rauhallistaToolStripMenuItem";
            this.rauhallistaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rauhallistaToolStripMenuItem.Text = "Rauhallista";
            this.rauhallistaToolStripMenuItem.Click += new System.EventHandler(this.rauhallistaToolStripMenuItem_Click);
            // 
            // JooLLB
            // 
            this.JooLLB.AutoSize = true;
            this.JooLLB.Location = new System.Drawing.Point(148, 203);
            this.JooLLB.Name = "JooLLB";
            this.JooLLB.Size = new System.Drawing.Size(82, 13);
            this.JooLLB.TabIndex = 1;
            this.JooLLB.TabStop = true;
            this.JooLLB.Text = "Paina nyt minua";
            this.JooLLB.Visible = false;
            this.JooLLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EiLB
            // 
            this.EiLB.AutoSize = true;
            this.EiLB.Location = new System.Drawing.Point(148, 238);
            this.EiLB.Name = "EiLB";
            this.EiLB.Size = new System.Drawing.Size(58, 13);
            this.EiLB.TabIndex = 2;
            this.EiLB.TabStop = true;
            this.EiLB.Text = "Et tykkää?";
            this.EiLB.Visible = false;
            this.EiLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // SwedenLLB
            // 
            this.SwedenLLB.AutoSize = true;
            this.SwedenLLB.Location = new System.Drawing.Point(148, 318);
            this.SwedenLLB.Name = "SwedenLLB";
            this.SwedenLLB.Size = new System.Drawing.Size(68, 13);
            this.SwedenLLB.TabIndex = 3;
            this.SwedenLLB.TabStop = true;
            this.SwedenLLB.Text = "Tuut muistaa";
            this.SwedenLLB.Visible = false;
            this.SwedenLLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SwedenLLB_LinkClicked);
            // 
            // WhyLLB
            // 
            this.WhyLLB.AutoSize = true;
            this.WhyLLB.Location = new System.Drawing.Point(148, 282);
            this.WhyLLB.Name = "WhyLLB";
            this.WhyLLB.Size = new System.Drawing.Size(119, 13);
            this.WhyLLB.TabIndex = 4;
            this.WhyLLB.TabStop = true;
            this.WhyLLB.Text = "the importance of music";
            this.WhyLLB.Visible = false;
            // 
            // ValikkoTB
            // 
            this.ValikkoTB.Location = new System.Drawing.Point(151, 101);
            this.ValikkoTB.Name = "ValikkoTB";
            this.ValikkoTB.Size = new System.Drawing.Size(100, 20);
            this.ValikkoTB.TabIndex = 5;
            this.ValikkoTB.TextChanged += new System.EventHandler(this.ValikkoTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mitä haluat kuunella?";
            // 
            // EminemBT
            // 
            this.EminemBT.Location = new System.Drawing.Point(80, 127);
            this.EminemBT.Name = "EminemBT";
            this.EminemBT.Size = new System.Drawing.Size(75, 23);
            this.EminemBT.TabIndex = 7;
            this.EminemBT.Text = "Eminem";
            this.EminemBT.UseVisualStyleBackColor = true;
            this.EminemBT.Visible = false;
            this.EminemBT.Click += new System.EventHandler(this.EminemBT_Click);
            // 
            // ChesterBT
            // 
            this.ChesterBT.Location = new System.Drawing.Point(161, 127);
            this.ChesterBT.Name = "ChesterBT";
            this.ChesterBT.Size = new System.Drawing.Size(75, 23);
            this.ChesterBT.TabIndex = 8;
            this.ChesterBT.Text = "Linking Park";
            this.ChesterBT.UseVisualStyleBackColor = true;
            this.ChesterBT.Visible = false;
            this.ChesterBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // SkylarBT
            // 
            this.SkylarBT.Location = new System.Drawing.Point(242, 127);
            this.SkylarBT.Name = "SkylarBT";
            this.SkylarBT.Size = new System.Drawing.Size(75, 23);
            this.SkylarBT.TabIndex = 9;
            this.SkylarBT.Text = "Skylar Grey";
            this.SkylarBT.UseVisualStyleBackColor = true;
            this.SkylarBT.Visible = false;
            this.SkylarBT.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "1. Musiikki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "2. Meemi";
            // 
            // InternetBT
            // 
            this.InternetBT.Location = new System.Drawing.Point(122, 156);
            this.InternetBT.Name = "InternetBT";
            this.InternetBT.Size = new System.Drawing.Size(145, 24);
            this.InternetBT.TabIndex = 12;
            this.InternetBT.Text = "Tervettuloa internettiin";
            this.InternetBT.UseVisualStyleBackColor = true;
            this.InternetBT.Visible = false;
            this.InternetBT.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vastaa 1 tai 2";
            // 
            // TextBT
            // 
            this.TextBT.Location = new System.Drawing.Point(267, 99);
            this.TextBT.Name = "TextBT";
            this.TextBT.Size = new System.Drawing.Size(75, 23);
            this.TextBT.TabIndex = 14;
            this.TextBT.Text = "Valitse";
            this.TextBT.UseVisualStyleBackColor = true;
            this.TextBT.Click += new System.EventHandler(this.TextBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InternetBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SkylarBT);
            this.Controls.Add(this.ChesterBT);
            this.Controls.Add(this.EminemBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValikkoTB);
            this.Controls.Add(this.WhyLLB);
            this.Controls.Add(this.SwedenLLB);
            this.Controls.Add(this.EiLB);
            this.Controls.Add(this.JooLLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tykkääköMusiikistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enOleVarmaToolStripMenuItem;
        private System.Windows.Forms.LinkLabel JooLLB;
        private System.Windows.Forms.LinkLabel EiLB;
        private System.Windows.Forms.LinkLabel SwedenLLB;
        private System.Windows.Forms.LinkLabel WhyLLB;
        private System.Windows.Forms.TextBox ValikkoTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EminemBT;
        private System.Windows.Forms.Button ChesterBT;
        private System.Windows.Forms.Button SkylarBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InternetBT;
        private System.Windows.Forms.ToolStripMenuItem rauhallistaToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TextBT;
    }
}

