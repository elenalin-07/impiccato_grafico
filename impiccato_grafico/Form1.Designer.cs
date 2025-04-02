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
            ckbAnimal = new CheckBox();
            lblTema = new Label();
            ckbObject = new CheckBox();
            ckbPaese = new CheckBox();
            ckbPiante = new CheckBox();
            ckbDifficult = new CheckBox();
            ckbNormal = new CheckBox();
            label1 = new Label();
            ckbEasy = new CheckBox();
            btnStart = new Button();
            lblIntroduction = new Label();
            label2 = new Label();
            lblError_scelta = new Label();
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
            // ckbAnimal
            // 
            ckbAnimal.AutoSize = true;
            ckbAnimal.Location = new Point(214, 234);
            ckbAnimal.Name = "ckbAnimal";
            ckbAnimal.Size = new Size(70, 19);
            ckbAnimal.TabIndex = 1;
            ckbAnimal.Text = "Animale";
            ckbAnimal.UseVisualStyleBackColor = true;
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
            // ckbObject
            // 
            ckbObject.AutoSize = true;
            ckbObject.Location = new Point(214, 271);
            ckbObject.Name = "ckbObject";
            ckbObject.Size = new Size(70, 19);
            ckbObject.TabIndex = 3;
            ckbObject.Text = "Oggetto";
            ckbObject.UseVisualStyleBackColor = true;
            // 
            // ckbPaese
            // 
            ckbPaese.AutoSize = true;
            ckbPaese.Location = new Point(214, 312);
            ckbPaese.Name = "ckbPaese";
            ckbPaese.Size = new Size(56, 19);
            ckbPaese.TabIndex = 4;
            ckbPaese.Text = "Paese";
            ckbPaese.UseVisualStyleBackColor = true;
            // 
            // ckbPiante
            // 
            ckbPiante.AutoSize = true;
            ckbPiante.Location = new Point(214, 352);
            ckbPiante.Name = "ckbPiante";
            ckbPiante.Size = new Size(59, 19);
            ckbPiante.TabIndex = 5;
            ckbPiante.Text = "Piante";
            ckbPiante.UseVisualStyleBackColor = true;
            // 
            // ckbDifficult
            // 
            ckbDifficult.AutoSize = true;
            ckbDifficult.Location = new Point(508, 352);
            ckbDifficult.Name = "ckbDifficult";
            ckbDifficult.Size = new Size(66, 19);
            ckbDifficult.TabIndex = 9;
            ckbDifficult.Text = "Difficile";
            ckbDifficult.UseVisualStyleBackColor = true;
            // 
            // ckbNormal
            // 
            ckbNormal.AutoSize = true;
            ckbNormal.Location = new Point(508, 291);
            ckbNormal.Name = "ckbNormal";
            ckbNormal.Size = new Size(72, 19);
            ckbNormal.TabIndex = 8;
            ckbNormal.Text = "Normale";
            ckbNormal.UseVisualStyleBackColor = true;
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
            // ckbEasy
            // 
            ckbEasy.AutoSize = true;
            ckbEasy.Location = new Point(508, 234);
            ckbEasy.Name = "ckbEasy";
            ckbEasy.Size = new Size(56, 19);
            ckbEasy.TabIndex = 6;
            ckbEasy.Text = "Facile";
            ckbEasy.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError_scelta);
            Controls.Add(label2);
            Controls.Add(lblIntroduction);
            Controls.Add(btnStart);
            Controls.Add(ckbDifficult);
            Controls.Add(ckbNormal);
            Controls.Add(label1);
            Controls.Add(ckbEasy);
            Controls.Add(ckbPiante);
            Controls.Add(ckbPaese);
            Controls.Add(ckbObject);
            Controls.Add(lblTema);
            Controls.Add(ckbAnimal);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private CheckBox ckbAnimal;
        private Label lblTema;
        private CheckBox ckbObject;
        private CheckBox ckbPaese;
        private CheckBox ckbPiante;
        private CheckBox ckbDifficult;
        private CheckBox ckbNormal;
        private Label label1;
        private CheckBox ckbEasy;
        private Button btnStart;
        private Label lblIntroduction;
        private Label label2;
        private Label lblError_scelta;
    }
}
