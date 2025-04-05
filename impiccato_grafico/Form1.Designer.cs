namespace impiccato_grafico
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
            lblTema = new Label();
            label1 = new Label();
            btnStart = new Button();
            lblIntroduction = new Label();
            label2 = new Label();
            lblError_scelta = new Label();
            Animale = new Button();
            Oggetto = new Button();
            Paese = new Button();
            Piante = new Button();
            Difficile = new Button();
            Normale = new Button();
            Facile = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(321, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Impiccato";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTema.Location = new Point(192, 202);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(128, 17);
            lblTema.TabIndex = 2;
            lblTema.Text = "Scegli una tema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 202);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 7;
            label1.Text = "Scegli una difficoltà";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(337, 380);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(99, 39);
            btnStart.TabIndex = 10;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblIntroduction
            // 
            lblIntroduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntroduction.AutoSize = true;
            lblIntroduction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntroduction.Location = new Point(5, 62);
            lblIntroduction.MaximumSize = new Size(800, 70);
            lblIntroduction.Name = "lblIntroduction";
            lblIntroduction.Size = new Size(779, 68);
            lblIntroduction.TabIndex = 11;
            lblIntroduction.Text = resources.GetString("lblIntroduction.Text");
            lblIntroduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 168);
            label2.Name = "label2";
            label2.Size = new Size(311, 17);
            label2.TabIndex = 12;
            label2.Text = "Sei pronto a iniziare? Scegli una tema per la parola!";
            // 
            // lblError_scelta
            // 
            lblError_scelta.AutoSize = true;
            lblError_scelta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError_scelta.ForeColor = Color.Brown;
            lblError_scelta.Location = new Point(241, 426);
            lblError_scelta.Name = "lblError_scelta";
            lblError_scelta.Size = new Size(269, 15);
            lblError_scelta.TabIndex = 13;
            lblError_scelta.Text = "Per favore, scegli solo una tema o una difficoltà";
            lblError_scelta.Visible = false;
            // 
            // Animale
            // 
            Animale.Location = new Point(216, 235);
            Animale.Name = "Animale";
            Animale.Size = new Size(75, 23);
            Animale.TabIndex = 14;
            Animale.Text = "Animale";
            Animale.UseVisualStyleBackColor = true;
            // 
            // Oggetto
            // 
            Oggetto.Location = new Point(216, 264);
            Oggetto.Name = "Oggetto";
            Oggetto.Size = new Size(75, 23);
            Oggetto.TabIndex = 15;
            Oggetto.Text = "Oggetto";
            Oggetto.UseVisualStyleBackColor = true;
            // 
            // Paese
            // 
            Paese.Location = new Point(216, 293);
            Paese.Name = "Paese";
            Paese.Size = new Size(75, 23);
            Paese.TabIndex = 16;
            Paese.Text = "Paese";
            Paese.UseVisualStyleBackColor = true;
            // 
            // Piante
            // 
            Piante.Location = new Point(218, 322);
            Piante.Name = "Piante";
            Piante.Size = new Size(75, 23);
            Piante.TabIndex = 17;
            Piante.Text = "Piante";
            Piante.UseVisualStyleBackColor = true;
            // 
            // Difficile
            // 
            Difficile.Location = new Point(496, 322);
            Difficile.Name = "Difficile";
            Difficile.Size = new Size(75, 23);
            Difficile.TabIndex = 20;
            Difficile.Text = "Difficile";
            Difficile.UseVisualStyleBackColor = true;
            // 
            // Normale
            // 
            Normale.Location = new Point(496, 279);
            Normale.Name = "Normale";
            Normale.Size = new Size(75, 23);
            Normale.TabIndex = 19;
            Normale.Text = "Normale";
            Normale.UseVisualStyleBackColor = true;
            // 
            // Facile
            // 
            Facile.Location = new Point(496, 235);
            Facile.Name = "Facile";
            Facile.Size = new Size(75, 23);
            Facile.TabIndex = 18;
            Facile.Text = "Facile";
            Facile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(Difficile);
            Controls.Add(Normale);
            Controls.Add(Facile);
            Controls.Add(Piante);
            Controls.Add(Paese);
            Controls.Add(Oggetto);
            Controls.Add(Animale);
            Controls.Add(lblError_scelta);
            Controls.Add(label2);
            Controls.Add(lblIntroduction);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(lblTema);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTema;
        private Label label1;
        private Button btnStart;
        private Label lblIntroduction;
        private Label label2;
        private Label lblError_scelta;
        private Button Animale;
        private Button Oggetto;
        private Button Paese;
        private Button Piante;
        private Button Difficile;
        private Button Normale;
        private Button Facile;
    }
}
