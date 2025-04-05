namespace impiccato_grafic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblIntro = new Label();
            lblTema = new Label();
            lblDifficult = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(300, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Impiccato";
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntro.AutoSize = true;
            lblIntro.Location = new Point(22, 63);
            lblIntro.MaximumSize = new Size(750, 100);
            lblIntro.MinimumSize = new Size(750, 50);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(750, 90);
            lblIntro.TabIndex = 1;
            lblIntro.Text = resources.GetString("lblIntro.Text");
            lblIntro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Cooper Black", 14.25F);
            lblTema.Location = new Point(179, 193);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(162, 21);
            lblTema.TabIndex = 2;
            lblTema.Text = "Scegli una tema";
            // 
            // lblDifficult
            // 
            lblDifficult.AutoSize = true;
            lblDifficult.Font = new Font("Cooper Black", 14.25F);
            lblDifficult.Location = new Point(444, 193);
            lblDifficult.Name = "lblDifficult";
            lblDifficult.Size = new Size(185, 21);
            lblDifficult.TabIndex = 3;
            lblDifficult.Text = "Scegli la difficoltà";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(206, 222);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(206, 259);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(206, 296);
            button3.Name = "button3";
            button3.Size = new Size(107, 31);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(206, 333);
            button4.Name = "button4";
            button4.Size = new Size(107, 31);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SkyBlue;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(493, 222);
            button5.Name = "button5";
            button5.Size = new Size(107, 31);
            button5.TabIndex = 10;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SkyBlue;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(493, 279);
            button6.Name = "button6";
            button6.Size = new Size(107, 31);
            button6.TabIndex = 9;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.SkyBlue;
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(493, 333);
            button7.Name = "button7";
            button7.Size = new Size(107, 31);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(348, 386);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(111, 36);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblDifficult);
            Controls.Add(lblTema);
            Controls.Add(lblIntro);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblIntro;
        private Label lblTema;
        private Label lblDifficult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button btnStart;
    }
}
