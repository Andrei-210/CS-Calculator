namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.artanButton1 = new ArtanButton.ArtanButton();
            this.ElipseForm = new Calculator.ArtanElipseControl();
            this.artanButton2 = new ArtanButton.ArtanButton();
            this.artanButton3 = new ArtanButton.ArtanButton();
            this.artanButton4 = new ArtanButton.ArtanButton();
            this.artanButton5 = new ArtanButton.ArtanButton();
            this.artanButton6 = new ArtanButton.ArtanButton();
            this.artanButton7 = new ArtanButton.ArtanButton();
            this.artanButton8 = new ArtanButton.ArtanButton();
            this.artanButton9 = new ArtanButton.ArtanButton();
            this.artanButton10 = new ArtanButton.ArtanButton();
            this.artanButton11 = new ArtanButton.ArtanButton();
            this.artanButton12 = new ArtanButton.ArtanButton();
            this.artanButton13 = new ArtanButton.ArtanButton();
            this.artanButton14 = new ArtanButton.ArtanButton();
            this.artanButton15 = new ArtanButton.ArtanButton();
            this.artanButton16 = new ArtanButton.ArtanButton();
            this.artanButton17 = new ArtanButton.ArtanButton();
            this.artanButton18 = new ArtanButton.ArtanButton();
            this.artanButton19 = new ArtanButton.ArtanButton();
            this.artanButton20 = new ArtanButton.ArtanButton();
            this.artanButton21 = new ArtanButton.ArtanButton();
            this.artanButton22 = new ArtanButton.ArtanButton();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.button2);
            this.PnlTitle.Controls.Add(this.button1);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.richTextBox1);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 565);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(350, 0);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 40);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 16F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "811";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 32F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 105);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "811";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // artanButton1
            // 
            this.artanButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.BorderRadius = 20;
            this.artanButton1.BorderSize = 0;
            this.artanButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.FlatAppearance.BorderSize = 0;
            this.artanButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton1.ForeColor = System.Drawing.Color.White;
            this.artanButton1.Image = ((System.Drawing.Image)(resources.GetObject("artanButton1.Image")));
            this.artanButton1.Location = new System.Drawing.Point(261, 196);
            this.artanButton1.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton1.Name = "artanButton1";
            this.artanButton1.Size = new System.Drawing.Size(85, 55);
            this.artanButton1.TabIndex = 5;
            this.artanButton1.TextColor = System.Drawing.Color.White;
            this.artanButton1.UseVisualStyleBackColor = false;
            this.artanButton1.Click += new System.EventHandler(this.artanButton1_Click);
            // 
            // ElipseForm
            // 
            this.ElipseForm.CornerRedius = 20;
            this.ElipseForm.TargetControl = this;
            // 
            // artanButton2
            // 
            this.artanButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BorderRadius = 15;
            this.artanButton2.BorderSize = 0;
            this.artanButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton2.FlatAppearance.BorderSize = 0;
            this.artanButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton2.ForeColor = System.Drawing.Color.White;
            this.artanButton2.Location = new System.Drawing.Point(291, 166);
            this.artanButton2.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton2.Name = "artanButton2";
            this.artanButton2.Size = new System.Drawing.Size(50, 30);
            this.artanButton2.TabIndex = 6;
            this.artanButton2.Text = "M~";
            this.artanButton2.TextColor = System.Drawing.Color.White;
            this.artanButton2.UseVisualStyleBackColor = false;
            // 
            // artanButton3
            // 
            this.artanButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BorderRadius = 15;
            this.artanButton3.BorderSize = 0;
            this.artanButton3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton3.FlatAppearance.BorderSize = 0;
            this.artanButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton3.ForeColor = System.Drawing.Color.White;
            this.artanButton3.Location = new System.Drawing.Point(234, 166);
            this.artanButton3.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton3.Name = "artanButton3";
            this.artanButton3.Size = new System.Drawing.Size(50, 30);
            this.artanButton3.TabIndex = 7;
            this.artanButton3.Text = "MS";
            this.artanButton3.TextColor = System.Drawing.Color.White;
            this.artanButton3.UseVisualStyleBackColor = false;
            // 
            // artanButton4
            // 
            this.artanButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BorderRadius = 15;
            this.artanButton4.BorderSize = 0;
            this.artanButton4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton4.FlatAppearance.BorderSize = 0;
            this.artanButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton4.ForeColor = System.Drawing.Color.White;
            this.artanButton4.Location = new System.Drawing.Point(177, 166);
            this.artanButton4.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton4.Name = "artanButton4";
            this.artanButton4.Size = new System.Drawing.Size(50, 30);
            this.artanButton4.TabIndex = 8;
            this.artanButton4.Text = "M-";
            this.artanButton4.TextColor = System.Drawing.Color.White;
            this.artanButton4.UseVisualStyleBackColor = false;
            // 
            // artanButton5
            // 
            this.artanButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BorderRadius = 15;
            this.artanButton5.BorderSize = 0;
            this.artanButton5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton5.FlatAppearance.BorderSize = 0;
            this.artanButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton5.ForeColor = System.Drawing.Color.White;
            this.artanButton5.Location = new System.Drawing.Point(120, 166);
            this.artanButton5.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton5.Name = "artanButton5";
            this.artanButton5.Size = new System.Drawing.Size(50, 30);
            this.artanButton5.TabIndex = 9;
            this.artanButton5.Text = "M+";
            this.artanButton5.TextColor = System.Drawing.Color.White;
            this.artanButton5.UseVisualStyleBackColor = false;
            // 
            // artanButton6
            // 
            this.artanButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BorderRadius = 15;
            this.artanButton6.BorderSize = 0;
            this.artanButton6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton6.FlatAppearance.BorderSize = 0;
            this.artanButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton6.ForeColor = System.Drawing.Color.White;
            this.artanButton6.Location = new System.Drawing.Point(63, 166);
            this.artanButton6.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton6.Name = "artanButton6";
            this.artanButton6.Size = new System.Drawing.Size(50, 30);
            this.artanButton6.TabIndex = 10;
            this.artanButton6.Text = "MR";
            this.artanButton6.TextColor = System.Drawing.Color.White;
            this.artanButton6.UseVisualStyleBackColor = false;
            // 
            // artanButton7
            // 
            this.artanButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton7.BorderRadius = 15;
            this.artanButton7.BorderSize = 0;
            this.artanButton7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.artanButton7.FlatAppearance.BorderSize = 0;
            this.artanButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton7.ForeColor = System.Drawing.Color.White;
            this.artanButton7.Location = new System.Drawing.Point(6, 166);
            this.artanButton7.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton7.Name = "artanButton7";
            this.artanButton7.Size = new System.Drawing.Size(50, 30);
            this.artanButton7.TabIndex = 11;
            this.artanButton7.Text = "MC";
            this.artanButton7.TextColor = System.Drawing.Color.White;
            this.artanButton7.UseVisualStyleBackColor = false;
            // 
            // artanButton8
            // 
            this.artanButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton8.BorderRadius = 20;
            this.artanButton8.BorderSize = 0;
            this.artanButton8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton8.FlatAppearance.BorderSize = 0;
            this.artanButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton8.ForeColor = System.Drawing.Color.White;
            this.artanButton8.Location = new System.Drawing.Point(6, 196);
            this.artanButton8.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton8.Name = "artanButton8";
            this.artanButton8.Size = new System.Drawing.Size(85, 55);
            this.artanButton8.TabIndex = 12;
            this.artanButton8.Text = "%";
            this.artanButton8.TextColor = System.Drawing.Color.White;
            this.artanButton8.UseVisualStyleBackColor = false;
            // 
            // artanButton9
            // 
            this.artanButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton9.BorderRadius = 20;
            this.artanButton9.BorderSize = 0;
            this.artanButton9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton9.FlatAppearance.BorderSize = 0;
            this.artanButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton9.ForeColor = System.Drawing.Color.White;
            this.artanButton9.Location = new System.Drawing.Point(91, 196);
            this.artanButton9.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton9.Name = "artanButton9";
            this.artanButton9.Size = new System.Drawing.Size(85, 55);
            this.artanButton9.TabIndex = 13;
            this.artanButton9.Text = "CE";
            this.artanButton9.TextColor = System.Drawing.Color.White;
            this.artanButton9.UseVisualStyleBackColor = false;
            // 
            // artanButton10
            // 
            this.artanButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton10.BorderRadius = 20;
            this.artanButton10.BorderSize = 0;
            this.artanButton10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton10.FlatAppearance.BorderSize = 0;
            this.artanButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton10.ForeColor = System.Drawing.Color.White;
            this.artanButton10.Location = new System.Drawing.Point(176, 196);
            this.artanButton10.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton10.Name = "artanButton10";
            this.artanButton10.Size = new System.Drawing.Size(85, 55);
            this.artanButton10.TabIndex = 14;
            this.artanButton10.Text = "C";
            this.artanButton10.TextColor = System.Drawing.Color.White;
            this.artanButton10.UseVisualStyleBackColor = false;
            // 
            // artanButton11
            // 
            this.artanButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton11.BorderRadius = 20;
            this.artanButton11.BorderSize = 0;
            this.artanButton11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton11.FlatAppearance.BorderSize = 0;
            this.artanButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton11.ForeColor = System.Drawing.Color.White;
            this.artanButton11.Location = new System.Drawing.Point(176, 251);
            this.artanButton11.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton11.Name = "artanButton11";
            this.artanButton11.Size = new System.Drawing.Size(85, 55);
            this.artanButton11.TabIndex = 18;
            this.artanButton11.Text = "√a";
            this.artanButton11.TextColor = System.Drawing.Color.White;
            this.artanButton11.UseVisualStyleBackColor = false;
            // 
            // artanButton12
            // 
            this.artanButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton12.BorderRadius = 20;
            this.artanButton12.BorderSize = 0;
            this.artanButton12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton12.FlatAppearance.BorderSize = 0;
            this.artanButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton12.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton12.ForeColor = System.Drawing.Color.White;
            this.artanButton12.Location = new System.Drawing.Point(91, 251);
            this.artanButton12.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton12.Name = "artanButton12";
            this.artanButton12.Size = new System.Drawing.Size(85, 55);
            this.artanButton12.TabIndex = 17;
            this.artanButton12.Text = "^2";
            this.artanButton12.TextColor = System.Drawing.Color.White;
            this.artanButton12.UseVisualStyleBackColor = false;
            // 
            // artanButton13
            // 
            this.artanButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton13.BorderRadius = 20;
            this.artanButton13.BorderSize = 0;
            this.artanButton13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton13.FlatAppearance.BorderSize = 0;
            this.artanButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton13.ForeColor = System.Drawing.Color.White;
            this.artanButton13.Location = new System.Drawing.Point(6, 251);
            this.artanButton13.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton13.Name = "artanButton13";
            this.artanButton13.Size = new System.Drawing.Size(85, 55);
            this.artanButton13.TabIndex = 16;
            this.artanButton13.Text = "1/x";
            this.artanButton13.TextColor = System.Drawing.Color.White;
            this.artanButton13.UseVisualStyleBackColor = false;
            // 
            // artanButton14
            // 
            this.artanButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton14.BorderRadius = 20;
            this.artanButton14.BorderSize = 0;
            this.artanButton14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton14.FlatAppearance.BorderSize = 0;
            this.artanButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton14.ForeColor = System.Drawing.Color.White;
            this.artanButton14.Location = new System.Drawing.Point(261, 251);
            this.artanButton14.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton14.Name = "artanButton14";
            this.artanButton14.Size = new System.Drawing.Size(85, 55);
            this.artanButton14.TabIndex = 15;
            this.artanButton14.Text = "÷";
            this.artanButton14.TextColor = System.Drawing.Color.White;
            this.artanButton14.UseVisualStyleBackColor = false;
            // 
            // artanButton15
            // 
            this.artanButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton15.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton15.BorderRadius = 20;
            this.artanButton15.BorderSize = 0;
            this.artanButton15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton15.FlatAppearance.BorderSize = 0;
            this.artanButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton15.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton15.ForeColor = System.Drawing.Color.White;
            this.artanButton15.Location = new System.Drawing.Point(176, 362);
            this.artanButton15.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton15.Name = "artanButton15";
            this.artanButton15.Size = new System.Drawing.Size(85, 55);
            this.artanButton15.TabIndex = 26;
            this.artanButton15.Text = "√a";
            this.artanButton15.TextColor = System.Drawing.Color.White;
            this.artanButton15.UseVisualStyleBackColor = false;
            // 
            // artanButton16
            // 
            this.artanButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton16.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton16.BorderRadius = 20;
            this.artanButton16.BorderSize = 0;
            this.artanButton16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton16.FlatAppearance.BorderSize = 0;
            this.artanButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton16.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton16.ForeColor = System.Drawing.Color.White;
            this.artanButton16.Location = new System.Drawing.Point(91, 362);
            this.artanButton16.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton16.Name = "artanButton16";
            this.artanButton16.Size = new System.Drawing.Size(85, 55);
            this.artanButton16.TabIndex = 25;
            this.artanButton16.Text = "^2";
            this.artanButton16.TextColor = System.Drawing.Color.White;
            this.artanButton16.UseVisualStyleBackColor = false;
            // 
            // artanButton17
            // 
            this.artanButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton17.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton17.BorderRadius = 20;
            this.artanButton17.BorderSize = 0;
            this.artanButton17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton17.FlatAppearance.BorderSize = 0;
            this.artanButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton17.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton17.ForeColor = System.Drawing.Color.White;
            this.artanButton17.Location = new System.Drawing.Point(6, 362);
            this.artanButton17.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton17.Name = "artanButton17";
            this.artanButton17.Size = new System.Drawing.Size(85, 55);
            this.artanButton17.TabIndex = 24;
            this.artanButton17.Text = "1/x";
            this.artanButton17.TextColor = System.Drawing.Color.White;
            this.artanButton17.UseVisualStyleBackColor = false;
            // 
            // artanButton18
            // 
            this.artanButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton18.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton18.BorderRadius = 20;
            this.artanButton18.BorderSize = 0;
            this.artanButton18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton18.FlatAppearance.BorderSize = 0;
            this.artanButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton18.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton18.ForeColor = System.Drawing.Color.White;
            this.artanButton18.Location = new System.Drawing.Point(261, 362);
            this.artanButton18.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton18.Name = "artanButton18";
            this.artanButton18.Size = new System.Drawing.Size(85, 55);
            this.artanButton18.TabIndex = 23;
            this.artanButton18.Text = "÷";
            this.artanButton18.TextColor = System.Drawing.Color.White;
            this.artanButton18.UseVisualStyleBackColor = false;
            // 
            // artanButton19
            // 
            this.artanButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton19.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton19.BorderRadius = 20;
            this.artanButton19.BorderSize = 0;
            this.artanButton19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton19.FlatAppearance.BorderSize = 0;
            this.artanButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton19.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton19.ForeColor = System.Drawing.Color.White;
            this.artanButton19.Location = new System.Drawing.Point(176, 307);
            this.artanButton19.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton19.Name = "artanButton19";
            this.artanButton19.Size = new System.Drawing.Size(85, 55);
            this.artanButton19.TabIndex = 22;
            this.artanButton19.Text = "C";
            this.artanButton19.TextColor = System.Drawing.Color.White;
            this.artanButton19.UseVisualStyleBackColor = false;
            // 
            // artanButton20
            // 
            this.artanButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton20.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton20.BorderRadius = 20;
            this.artanButton20.BorderSize = 0;
            this.artanButton20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton20.FlatAppearance.BorderSize = 0;
            this.artanButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton20.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton20.ForeColor = System.Drawing.Color.White;
            this.artanButton20.Location = new System.Drawing.Point(91, 307);
            this.artanButton20.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton20.Name = "artanButton20";
            this.artanButton20.Size = new System.Drawing.Size(85, 55);
            this.artanButton20.TabIndex = 21;
            this.artanButton20.Text = "CE";
            this.artanButton20.TextColor = System.Drawing.Color.White;
            this.artanButton20.UseVisualStyleBackColor = false;
            // 
            // artanButton21
            // 
            this.artanButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton21.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton21.BorderRadius = 20;
            this.artanButton21.BorderSize = 0;
            this.artanButton21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton21.FlatAppearance.BorderSize = 0;
            this.artanButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton21.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton21.ForeColor = System.Drawing.Color.White;
            this.artanButton21.Location = new System.Drawing.Point(6, 307);
            this.artanButton21.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton21.Name = "artanButton21";
            this.artanButton21.Size = new System.Drawing.Size(85, 55);
            this.artanButton21.TabIndex = 20;
            this.artanButton21.Text = "%";
            this.artanButton21.TextColor = System.Drawing.Color.White;
            this.artanButton21.UseVisualStyleBackColor = false;
            // 
            // artanButton22
            // 
            this.artanButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton22.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton22.BorderRadius = 20;
            this.artanButton22.BorderSize = 0;
            this.artanButton22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton22.FlatAppearance.BorderSize = 0;
            this.artanButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton22.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanButton22.ForeColor = System.Drawing.Color.White;
            this.artanButton22.Image = ((System.Drawing.Image)(resources.GetObject("artanButton22.Image")));
            this.artanButton22.Location = new System.Drawing.Point(261, 307);
            this.artanButton22.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton22.Name = "artanButton22";
            this.artanButton22.Size = new System.Drawing.Size(85, 55);
            this.artanButton22.TabIndex = 19;
            this.artanButton22.TextColor = System.Drawing.Color.White;
            this.artanButton22.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.artanButton15);
            this.Controls.Add(this.artanButton16);
            this.Controls.Add(this.artanButton17);
            this.Controls.Add(this.artanButton18);
            this.Controls.Add(this.artanButton19);
            this.Controls.Add(this.artanButton20);
            this.Controls.Add(this.artanButton21);
            this.Controls.Add(this.artanButton22);
            this.Controls.Add(this.artanButton11);
            this.Controls.Add(this.artanButton12);
            this.Controls.Add(this.artanButton13);
            this.Controls.Add(this.artanButton14);
            this.Controls.Add(this.artanButton10);
            this.Controls.Add(this.artanButton9);
            this.Controls.Add(this.artanButton8);
            this.Controls.Add(this.artanButton7);
            this.Controls.Add(this.artanButton6);
            this.Controls.Add(this.artanButton5);
            this.Controls.Add(this.artanButton4);
            this.Controls.Add(this.artanButton3);
            this.Controls.Add(this.artanButton2);
            this.Controls.Add(this.artanButton1);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ArtanElipseControl ElipseForm;
        private ArtanButton.ArtanButton artanButton1;
        private ArtanButton.ArtanButton artanButton7;
        private ArtanButton.ArtanButton artanButton6;
        private ArtanButton.ArtanButton artanButton5;
        private ArtanButton.ArtanButton artanButton4;
        private ArtanButton.ArtanButton artanButton3;
        private ArtanButton.ArtanButton artanButton2;
        private ArtanButton.ArtanButton artanButton10;
        private ArtanButton.ArtanButton artanButton9;
        private ArtanButton.ArtanButton artanButton8;
        private ArtanButton.ArtanButton artanButton11;
        private ArtanButton.ArtanButton artanButton12;
        private ArtanButton.ArtanButton artanButton13;
        private ArtanButton.ArtanButton artanButton14;
        private ArtanButton.ArtanButton artanButton15;
        private ArtanButton.ArtanButton artanButton16;
        private ArtanButton.ArtanButton artanButton17;
        private ArtanButton.ArtanButton artanButton18;
        private ArtanButton.ArtanButton artanButton19;
        private ArtanButton.ArtanButton artanButton20;
        private ArtanButton.ArtanButton artanButton21;
        private ArtanButton.ArtanButton artanButton22;
    }
}

