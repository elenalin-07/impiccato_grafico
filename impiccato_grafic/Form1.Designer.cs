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
            btnStart = new Button();
            ckbTema = new CheckedListBox();
            ckbDifficult = new CheckedListBox();
            lblParola = new Label();
            lblTicchetta_monete = new Label();
            lblMonete = new Label();
            lblTicchetta_tema = new Label();
            lblTema_scelta = new Label();
            lblTcchetta_difficult = new Label();
            lblDifficult_scelta = new Label();
            lblRis_lettera_inserita = new Label();
            btnA = new Button();
            btnOk = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnL = new Button();
            btnM = new Button();
            btnN = new Button();
            btnO = new Button();
            btnP = new Button();
            btnQ = new Button();
            btnR = new Button();
            lblLettera_inserito = new Label();
            btnS = new Button();
            btnT = new Button();
            btnU = new Button();
            btnV = new Button();
            btnW = new Button();
            btnX = new Button();
            btnB = new Button();
            btnZ = new Button();
            btnY = new Button();
            lblErrore_TemaDiff = new Label();
            lblTicchetta_lettere = new Label();
            lblLettere_provate = new Label();
            lblTicchetta_Tentativi = new Label();
            lblTentativi = new Label();
            btnNo = new Button();
            btnSi = new Button();
            lblDomanda_continua = new Label();
            btnPC_no = new Button();
            btnPC_si = new Button();
            lblParola_completa = new Label();
            lblTicchetta_parola_inserito = new Label();
            btnParola_inserita = new Button();
            tbxParola_inserita = new TextBox();
            lbxParole_non_indovinate = new ListBox();
            lbxParole_indovinate = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(370, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Impiccato";
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI", 10F);
            lblIntro.Location = new Point(30, 84);
            lblIntro.MaximumSize = new Size(857, 0);
            lblIntro.MinimumSize = new Size(857, 67);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(857, 184);
            lblIntro.TabIndex = 1;
            lblIntro.Text = resources.GetString("lblIntro.Text");
            lblIntro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Cooper Black", 14.25F);
            lblTema.Location = new Point(183, 308);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(204, 27);
            lblTema.TabIndex = 2;
            lblTema.Text = "Scegli una tema";
            // 
            // lblDifficult
            // 
            lblDifficult.AutoSize = true;
            lblDifficult.Font = new Font("Cooper Black", 14.25F);
            lblDifficult.Location = new Point(536, 308);
            lblDifficult.Name = "lblDifficult";
            lblDifficult.Size = new Size(235, 27);
            lblDifficult.TabIndex = 3;
            lblDifficult.Text = "Scegli la difficoltà";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(405, 490);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(127, 48);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // ckbTema
            // 
            ckbTema.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ckbTema.BackColor = Color.LightBlue;
            ckbTema.BorderStyle = BorderStyle.None;
            ckbTema.ColumnWidth = 10;
            ckbTema.Font = new Font("Segoe UI Light", 11F);
            ckbTema.FormattingEnabled = true;
            ckbTema.HorizontalExtent = 10;
            ckbTema.Items.AddRange(new object[] { "Animale", "Oggetto", "Paese", "Piante" });
            ckbTema.Location = new Point(226, 347);
            ckbTema.Name = "ckbTema";
            ckbTema.Size = new Size(126, 135);
            ckbTema.TabIndex = 12;
            ckbTema.TabStop = false;
            ckbTema.SelectedIndexChanged += ckbTema_SelectedIndexChanged;
            // 
            // ckbDifficult
            // 
            ckbDifficult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ckbDifficult.BackColor = Color.LightBlue;
            ckbDifficult.BorderStyle = BorderStyle.None;
            ckbDifficult.ColumnWidth = 10;
            ckbDifficult.Font = new Font("Segoe UI Light", 11F);
            ckbDifficult.FormattingEnabled = true;
            ckbDifficult.HorizontalExtent = 10;
            ckbDifficult.Items.AddRange(new object[] { "Facile - 2 monete (10 tentativi)", "Normale - 5 monete (8 tentativi)", "Difficile - 8 monete (5 tentativi)" });
            ckbDifficult.Location = new Point(536, 360);
            ckbDifficult.Name = "ckbDifficult";
            ckbDifficult.Size = new Size(302, 108);
            ckbDifficult.TabIndex = 13;
            ckbDifficult.TabStop = false;
            ckbDifficult.SelectedIndexChanged += ckbDifficult_SelectedIndexChanged;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParola.Location = new Point(226, 222);
            lblParola.MinimumSize = new Size(500, 20);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(500, 46);
            lblParola.TabIndex = 14;
            lblParola.Text = "parola segreta";
            lblParola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_monete
            // 
            lblTicchetta_monete.AutoSize = true;
            lblTicchetta_monete.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_monete.Location = new Point(12, 84);
            lblTicchetta_monete.Name = "lblTicchetta_monete";
            lblTicchetta_monete.Size = new Size(186, 21);
            lblTicchetta_monete.TabIndex = 16;
            lblTicchetta_monete.Text = "Numero di monete:";
            // 
            // lblMonete
            // 
            lblMonete.AutoSize = true;
            lblMonete.BackColor = SystemColors.Control;
            lblMonete.BorderStyle = BorderStyle.Fixed3D;
            lblMonete.Location = new Point(204, 85);
            lblMonete.MinimumSize = new Size(22, 22);
            lblMonete.Name = "lblMonete";
            lblMonete.Size = new Size(22, 22);
            lblMonete.TabIndex = 17;
            lblMonete.Text = "0";
            lblMonete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_tema
            // 
            lblTicchetta_tema.AutoSize = true;
            lblTicchetta_tema.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_tema.Location = new Point(12, 136);
            lblTicchetta_tema.Name = "lblTicchetta_tema";
            lblTicchetta_tema.Size = new Size(123, 21);
            lblTicchetta_tema.TabIndex = 18;
            lblTicchetta_tema.Text = "Tema scelta:";
            // 
            // lblTema_scelta
            // 
            lblTema_scelta.AutoSize = true;
            lblTema_scelta.BackColor = SystemColors.Control;
            lblTema_scelta.BorderStyle = BorderStyle.Fixed3D;
            lblTema_scelta.Location = new Point(141, 135);
            lblTema_scelta.MinimumSize = new Size(80, 22);
            lblTema_scelta.Name = "lblTema_scelta";
            lblTema_scelta.Size = new Size(80, 22);
            lblTema_scelta.TabIndex = 19;
            lblTema_scelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTcchetta_difficult
            // 
            lblTcchetta_difficult.AutoSize = true;
            lblTcchetta_difficult.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTcchetta_difficult.Location = new Point(12, 194);
            lblTcchetta_difficult.Name = "lblTcchetta_difficult";
            lblTcchetta_difficult.Size = new Size(160, 21);
            lblTcchetta_difficult.TabIndex = 20;
            lblTcchetta_difficult.Text = "Difficoltà scelta:";
            // 
            // lblDifficult_scelta
            // 
            lblDifficult_scelta.AutoSize = true;
            lblDifficult_scelta.BackColor = SystemColors.Control;
            lblDifficult_scelta.BorderStyle = BorderStyle.Fixed3D;
            lblDifficult_scelta.Location = new Point(178, 193);
            lblDifficult_scelta.MinimumSize = new Size(80, 22);
            lblDifficult_scelta.Name = "lblDifficult_scelta";
            lblDifficult_scelta.Size = new Size(80, 22);
            lblDifficult_scelta.TabIndex = 21;
            lblDifficult_scelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRis_lettera_inserita
            // 
            lblRis_lettera_inserita.AutoSize = true;
            lblRis_lettera_inserita.BorderStyle = BorderStyle.FixedSingle;
            lblRis_lettera_inserita.Location = new Point(226, 282);
            lblRis_lettera_inserita.MaximumSize = new Size(500, 0);
            lblRis_lettera_inserita.MinimumSize = new Size(500, 0);
            lblRis_lettera_inserita.Name = "lblRis_lettera_inserita";
            lblRis_lettera_inserita.Size = new Size(500, 62);
            lblRis_lettera_inserita.TabIndex = 23;
            lblRis_lettera_inserita.Text = "Oops! La parola che hai provato non è corretta. Non preoccuparti, puoi continuare a giocare! Prova a indovinare un’altra lettera o riprova a indovinare la parola!";
            lblRis_lettera_inserita.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightSkyBlue;
            btnA.Cursor = Cursors.Hand;
            btnA.Font = new Font("Cooper Black", 10.2F);
            btnA.Location = new Point(266, 461);
            btnA.MinimumSize = new Size(40, 40);
            btnA.Name = "btnA";
            btnA.Size = new Size(40, 40);
            btnA.TabIndex = 49;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SteelBlue;
            btnOk.Cursor = Cursors.Hand;
            btnOk.Font = new Font("Cooper Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(529, 369);
            btnOk.MinimumSize = new Size(0, 30);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(45, 30);
            btnOk.TabIndex = 76;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.LightSkyBlue;
            btnC.Cursor = Cursors.Hand;
            btnC.Font = new Font("Cooper Black", 10.2F);
            btnC.Location = new Point(404, 507);
            btnC.MinimumSize = new Size(40, 40);
            btnC.Name = "btnC";
            btnC.Size = new Size(40, 40);
            btnC.TabIndex = 51;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.LightSkyBlue;
            btnD.Cursor = Cursors.Hand;
            btnD.Font = new Font("Cooper Black", 10.2F);
            btnD.Location = new Point(358, 461);
            btnD.MinimumSize = new Size(40, 40);
            btnD.Name = "btnD";
            btnD.Size = new Size(40, 40);
            btnD.TabIndex = 52;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += D_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.LightSkyBlue;
            btnE.Cursor = Cursors.Hand;
            btnE.Font = new Font("Cooper Black", 10.2F);
            btnE.Location = new Point(333, 415);
            btnE.MinimumSize = new Size(40, 40);
            btnE.Name = "btnE";
            btnE.Size = new Size(40, 40);
            btnE.TabIndex = 53;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnF
            // 
            btnF.BackColor = Color.LightSkyBlue;
            btnF.Cursor = Cursors.Hand;
            btnF.Font = new Font("Cooper Black", 10.2F);
            btnF.Location = new Point(404, 461);
            btnF.MinimumSize = new Size(40, 40);
            btnF.Name = "btnF";
            btnF.Size = new Size(40, 40);
            btnF.TabIndex = 54;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            btnF.Click += btnF_Click;
            // 
            // btnG
            // 
            btnG.BackColor = Color.LightSkyBlue;
            btnG.Cursor = Cursors.Hand;
            btnG.Font = new Font("Cooper Black", 10.2F);
            btnG.Location = new Point(450, 461);
            btnG.MinimumSize = new Size(40, 40);
            btnG.Name = "btnG";
            btnG.Size = new Size(40, 40);
            btnG.TabIndex = 55;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            btnG.Click += btnG_Click;
            // 
            // btnH
            // 
            btnH.BackColor = Color.LightSkyBlue;
            btnH.Cursor = Cursors.Hand;
            btnH.Font = new Font("Cooper Black", 10.2F);
            btnH.Location = new Point(496, 461);
            btnH.MinimumSize = new Size(40, 40);
            btnH.Name = "btnH";
            btnH.Size = new Size(40, 40);
            btnH.TabIndex = 56;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            btnH.Click += btnH_Click;
            // 
            // btnI
            // 
            btnI.BackColor = Color.LightSkyBlue;
            btnI.Cursor = Cursors.Hand;
            btnI.Font = new Font("Cooper Black", 10.2F);
            btnI.Location = new Point(563, 415);
            btnI.MinimumSize = new Size(40, 40);
            btnI.Name = "btnI";
            btnI.Size = new Size(40, 40);
            btnI.TabIndex = 57;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            btnI.Click += btnI_Click;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.LightSkyBlue;
            btnJ.Cursor = Cursors.Hand;
            btnJ.Font = new Font("Cooper Black", 10.2F);
            btnJ.Location = new Point(542, 461);
            btnJ.MinimumSize = new Size(40, 40);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(40, 40);
            btnJ.TabIndex = 58;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            btnJ.Click += btnJ_Click;
            // 
            // btnK
            // 
            btnK.BackColor = Color.LightSkyBlue;
            btnK.Cursor = Cursors.Hand;
            btnK.Font = new Font("Cooper Black", 10.2F);
            btnK.Location = new Point(589, 461);
            btnK.MinimumSize = new Size(40, 40);
            btnK.Name = "btnK";
            btnK.Size = new Size(40, 40);
            btnK.TabIndex = 59;
            btnK.Text = " K";
            btnK.UseVisualStyleBackColor = false;
            btnK.Click += btnK_Click;
            // 
            // btnL
            // 
            btnL.BackColor = Color.LightSkyBlue;
            btnL.Cursor = Cursors.Hand;
            btnL.Font = new Font("Cooper Black", 10.2F);
            btnL.Location = new Point(634, 461);
            btnL.MinimumSize = new Size(40, 40);
            btnL.Name = "btnL";
            btnL.Size = new Size(40, 40);
            btnL.TabIndex = 60;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            btnL.Click += btnL_Click;
            // 
            // btnM
            // 
            btnM.BackColor = Color.LightSkyBlue;
            btnM.Cursor = Cursors.Hand;
            btnM.Font = new Font("Cooper Black", 10.2F);
            btnM.Location = new Point(588, 507);
            btnM.MinimumSize = new Size(40, 40);
            btnM.Name = "btnM";
            btnM.Size = new Size(40, 40);
            btnM.TabIndex = 61;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            btnM.Click += btnM_Click;
            // 
            // btnN
            // 
            btnN.BackColor = Color.LightSkyBlue;
            btnN.Cursor = Cursors.Hand;
            btnN.Font = new Font("Cooper Black", 10.2F);
            btnN.Location = new Point(542, 507);
            btnN.MinimumSize = new Size(40, 40);
            btnN.Name = "btnN";
            btnN.Size = new Size(40, 40);
            btnN.TabIndex = 62;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            btnN.Click += btnN_Click;
            // 
            // btnO
            // 
            btnO.BackColor = Color.LightSkyBlue;
            btnO.Cursor = Cursors.Hand;
            btnO.Font = new Font("Cooper Black", 10.2F);
            btnO.Location = new Point(609, 415);
            btnO.MinimumSize = new Size(40, 40);
            btnO.Name = "btnO";
            btnO.Size = new Size(40, 40);
            btnO.TabIndex = 63;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            btnO.Click += btnO_Click;
            // 
            // btnP
            // 
            btnP.BackColor = Color.LightSkyBlue;
            btnP.Cursor = Cursors.Hand;
            btnP.Font = new Font("Cooper Black", 10.2F);
            btnP.Location = new Point(655, 415);
            btnP.MinimumSize = new Size(40, 40);
            btnP.Name = "btnP";
            btnP.Size = new Size(40, 40);
            btnP.TabIndex = 64;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            btnP.Click += btnP_Click;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.LightSkyBlue;
            btnQ.Cursor = Cursors.Hand;
            btnQ.Font = new Font("Cooper Black", 10.2F);
            btnQ.Location = new Point(241, 415);
            btnQ.MinimumSize = new Size(40, 40);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(40, 40);
            btnQ.TabIndex = 65;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            btnQ.Click += btnQ_Click;
            // 
            // btnR
            // 
            btnR.BackColor = Color.LightSkyBlue;
            btnR.Cursor = Cursors.Hand;
            btnR.Font = new Font("Cooper Black", 10.2F);
            btnR.Location = new Point(379, 415);
            btnR.MinimumSize = new Size(40, 40);
            btnR.Name = "btnR";
            btnR.Size = new Size(40, 40);
            btnR.TabIndex = 66;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnR_Click;
            // 
            // lblLettera_inserito
            // 
            lblLettera_inserito.AutoSize = true;
            lblLettera_inserito.BackColor = Color.White;
            lblLettera_inserito.BorderStyle = BorderStyle.FixedSingle;
            lblLettera_inserito.Location = new Point(416, 369);
            lblLettera_inserito.MinimumSize = new Size(100, 30);
            lblLettera_inserito.Name = "lblLettera_inserito";
            lblLettera_inserito.Size = new Size(100, 30);
            lblLettera_inserito.TabIndex = 67;
            lblLettera_inserito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnS
            // 
            btnS.BackColor = Color.LightSkyBlue;
            btnS.Cursor = Cursors.Hand;
            btnS.Font = new Font("Cooper Black", 10.2F);
            btnS.Location = new Point(312, 461);
            btnS.MinimumSize = new Size(40, 40);
            btnS.Name = "btnS";
            btnS.Size = new Size(40, 40);
            btnS.TabIndex = 68;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            btnS.Click += btnS_Click;
            // 
            // btnT
            // 
            btnT.BackColor = Color.LightSkyBlue;
            btnT.Cursor = Cursors.Hand;
            btnT.Font = new Font("Cooper Black", 10.2F);
            btnT.Location = new Point(425, 415);
            btnT.MinimumSize = new Size(40, 40);
            btnT.Name = "btnT";
            btnT.Size = new Size(40, 40);
            btnT.TabIndex = 69;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            btnT.Click += btnT_Click;
            // 
            // btnU
            // 
            btnU.BackColor = Color.LightSkyBlue;
            btnU.Cursor = Cursors.Hand;
            btnU.Font = new Font("Cooper Black", 10.2F);
            btnU.Location = new Point(517, 415);
            btnU.MinimumSize = new Size(40, 40);
            btnU.Name = "btnU";
            btnU.Size = new Size(40, 40);
            btnU.TabIndex = 70;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            btnU.Click += btnU_Click;
            // 
            // btnV
            // 
            btnV.BackColor = Color.LightSkyBlue;
            btnV.Cursor = Cursors.Hand;
            btnV.Font = new Font("Cooper Black", 10.2F);
            btnV.Location = new Point(450, 507);
            btnV.MinimumSize = new Size(40, 40);
            btnV.Name = "btnV";
            btnV.Size = new Size(40, 40);
            btnV.TabIndex = 71;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            btnV.Click += btnV_Click;
            // 
            // btnW
            // 
            btnW.BackColor = Color.LightSkyBlue;
            btnW.Cursor = Cursors.Hand;
            btnW.Font = new Font("Cooper Black", 10.2F);
            btnW.Location = new Point(287, 415);
            btnW.MinimumSize = new Size(40, 40);
            btnW.Name = "btnW";
            btnW.Size = new Size(40, 40);
            btnW.TabIndex = 72;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            btnW.Click += btnW_Click;
            // 
            // btnX
            // 
            btnX.BackColor = Color.LightSkyBlue;
            btnX.Cursor = Cursors.Hand;
            btnX.Font = new Font("Cooper Black", 10.2F);
            btnX.Location = new Point(358, 507);
            btnX.MinimumSize = new Size(40, 40);
            btnX.Name = "btnX";
            btnX.Size = new Size(40, 40);
            btnX.TabIndex = 73;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += btnX_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.LightSkyBlue;
            btnB.Cursor = Cursors.Hand;
            btnB.Font = new Font("Cooper Black", 10.2F);
            btnB.Location = new Point(496, 507);
            btnB.MinimumSize = new Size(40, 40);
            btnB.Name = "btnB";
            btnB.Size = new Size(40, 40);
            btnB.TabIndex = 50;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.LightSkyBlue;
            btnZ.Cursor = Cursors.Hand;
            btnZ.Font = new Font("Cooper Black", 10.2F);
            btnZ.Location = new Point(312, 507);
            btnZ.MinimumSize = new Size(40, 40);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(40, 40);
            btnZ.TabIndex = 75;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            btnZ.Click += btnZ_Click;
            // 
            // btnY
            // 
            btnY.BackColor = Color.LightSkyBlue;
            btnY.Cursor = Cursors.Hand;
            btnY.Font = new Font("Cooper Black", 10.2F);
            btnY.Location = new Point(471, 415);
            btnY.MinimumSize = new Size(40, 40);
            btnY.Name = "btnY";
            btnY.Size = new Size(40, 40);
            btnY.TabIndex = 74;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            btnY.Click += btnY_Click;
            // 
            // lblErrore_TemaDiff
            // 
            lblErrore_TemaDiff.AutoSize = true;
            lblErrore_TemaDiff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrore_TemaDiff.ForeColor = Color.Red;
            lblErrore_TemaDiff.Location = new Point(238, 550);
            lblErrore_TemaDiff.Name = "lblErrore_TemaDiff";
            lblErrore_TemaDiff.Size = new Size(488, 31);
            lblErrore_TemaDiff.TabIndex = 77;
            lblErrore_TemaDiff.Text = "Per favore scegli una tema e/o una difficoltà";
            lblErrore_TemaDiff.Visible = false;
            // 
            // lblTicchetta_lettere
            // 
            lblTicchetta_lettere.AutoSize = true;
            lblTicchetta_lettere.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_lettere.Location = new Point(23, 415);
            lblTicchetta_lettere.Name = "lblTicchetta_lettere";
            lblTicchetta_lettere.Size = new Size(149, 20);
            lblTicchetta_lettere.TabIndex = 78;
            lblTicchetta_lettere.Text = "Lettere provate:";
            // 
            // lblLettere_provate
            // 
            lblLettere_provate.AutoSize = true;
            lblLettere_provate.BackColor = SystemColors.Control;
            lblLettere_provate.BorderStyle = BorderStyle.Fixed3D;
            lblLettere_provate.Location = new Point(12, 451);
            lblLettere_provate.MaximumSize = new Size(170, 50);
            lblLettere_provate.MinimumSize = new Size(170, 50);
            lblLettere_provate.Name = "lblLettere_provate";
            lblLettere_provate.Size = new Size(170, 50);
            lblLettere_provate.TabIndex = 79;
            lblLettere_provate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_Tentativi
            // 
            lblTicchetta_Tentativi.AutoSize = true;
            lblTicchetta_Tentativi.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_Tentativi.Location = new Point(691, 86);
            lblTicchetta_Tentativi.Name = "lblTicchetta_Tentativi";
            lblTicchetta_Tentativi.Size = new Size(170, 21);
            lblTicchetta_Tentativi.TabIndex = 80;
            lblTicchetta_Tentativi.Text = "Tentativi rimasti:";
            // 
            // lblTentativi
            // 
            lblTentativi.AutoSize = true;
            lblTentativi.BackColor = SystemColors.Control;
            lblTentativi.BorderStyle = BorderStyle.Fixed3D;
            lblTentativi.Location = new Point(865, 84);
            lblTentativi.MinimumSize = new Size(22, 22);
            lblTentativi.Name = "lblTentativi";
            lblTentativi.Size = new Size(22, 22);
            lblTentativi.TabIndex = 81;
            lblTentativi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.LightSkyBlue;
            btnNo.Font = new Font("Cooper Black", 12F);
            btnNo.Location = new Point(517, 304);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(143, 64);
            btnNo.TabIndex = 84;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.LightSkyBlue;
            btnSi.Font = new Font("Cooper Black", 12F);
            btnSi.Location = new Point(276, 304);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(143, 64);
            btnSi.TabIndex = 83;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            // 
            // lblDomanda_continua
            // 
            lblDomanda_continua.AutoSize = true;
            lblDomanda_continua.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomanda_continua.Location = new Point(233, 233);
            lblDomanda_continua.Name = "lblDomanda_continua";
            lblDomanda_continua.Size = new Size(472, 23);
            lblDomanda_continua.TabIndex = 82;
            lblDomanda_continua.Text = "Vuoi provare di nuovo con una nuova parola?";
            lblDomanda_continua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPC_no
            // 
            btnPC_no.BackColor = Color.LightSkyBlue;
            btnPC_no.Font = new Font("Cooper Black", 12F);
            btnPC_no.Location = new Point(535, 461);
            btnPC_no.Name = "btnPC_no";
            btnPC_no.Size = new Size(95, 43);
            btnPC_no.TabIndex = 87;
            btnPC_no.Text = "NO";
            btnPC_no.UseVisualStyleBackColor = false;
            // 
            // btnPC_si
            // 
            btnPC_si.BackColor = Color.LightSkyBlue;
            btnPC_si.Font = new Font("Cooper Black", 12F);
            btnPC_si.Location = new Point(296, 461);
            btnPC_si.Name = "btnPC_si";
            btnPC_si.Size = new Size(95, 43);
            btnPC_si.TabIndex = 86;
            btnPC_si.Text = "SI";
            btnPC_si.UseVisualStyleBackColor = false;
            btnPC_si.Click += btnPC_si_Click;
            // 
            // lblParola_completa
            // 
            lblParola_completa.AutoSize = true;
            lblParola_completa.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParola_completa.Location = new Point(246, 389);
            lblParola_completa.Name = "lblParola_completa";
            lblParola_completa.Size = new Size(449, 23);
            lblParola_completa.TabIndex = 85;
            lblParola_completa.Text = "Sei pronto a indovinare la parola completa?";
            lblParola_completa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_parola_inserito
            // 
            lblTicchetta_parola_inserito.AutoSize = true;
            lblTicchetta_parola_inserito.Location = new Point(202, 425);
            lblTicchetta_parola_inserito.Name = "lblTicchetta_parola_inserito";
            lblTicchetta_parola_inserito.Size = new Size(548, 20);
            lblTicchetta_parola_inserito.TabIndex = 90;
            lblTicchetta_parola_inserito.Text = "Perfetto! Hai deciso di provarci. Scrivi la tua risposta e vediamo se hai indovinato!";
            // 
            // btnParola_inserita
            // 
            btnParola_inserita.BackColor = Color.SteelBlue;
            btnParola_inserita.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParola_inserita.ForeColor = Color.White;
            btnParola_inserita.Location = new Point(496, 467);
            btnParola_inserita.Name = "btnParola_inserita";
            btnParola_inserita.Size = new Size(94, 29);
            btnParola_inserita.TabIndex = 89;
            btnParola_inserita.Text = "OK";
            btnParola_inserita.UseVisualStyleBackColor = false;
            // 
            // tbxParola_inserita
            // 
            tbxParola_inserita.Location = new Point(346, 469);
            tbxParola_inserita.Name = "tbxParola_inserita";
            tbxParola_inserita.Size = new Size(125, 27);
            tbxParola_inserita.TabIndex = 88;
            // 
            // lbxParole_non_indovinate
            // 
            lbxParole_non_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_non_indovinate.FormattingEnabled = true;
            lbxParole_non_indovinate.Items.AddRange(new object[] { "Parole non indovinate:" });
            lbxParole_non_indovinate.Location = new Point(563, 193);
            lbxParole_non_indovinate.Name = "lbxParole_non_indovinate";
            lbxParole_non_indovinate.Size = new Size(209, 184);
            lbxParole_non_indovinate.TabIndex = 92;
            // 
            // lbxParole_indovinate
            // 
            lbxParole_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_indovinate.FormattingEnabled = true;
            lbxParole_indovinate.Items.AddRange(new object[] { "Parole indovinate:" });
            lbxParole_indovinate.Location = new Point(164, 193);
            lbxParole_indovinate.Name = "lbxParole_indovinate";
            lbxParole_indovinate.Size = new Size(209, 184);
            lbxParole_indovinate.TabIndex = 91;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(lbxParole_non_indovinate);
            Controls.Add(lbxParole_indovinate);
            Controls.Add(lblTicchetta_parola_inserito);
            Controls.Add(btnParola_inserita);
            Controls.Add(tbxParola_inserita);
            Controls.Add(btnPC_no);
            Controls.Add(btnPC_si);
            Controls.Add(lblParola_completa);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblDomanda_continua);
            Controls.Add(lblTentativi);
            Controls.Add(lblTicchetta_Tentativi);
            Controls.Add(lblLettere_provate);
            Controls.Add(lblTicchetta_lettere);
            Controls.Add(lblErrore_TemaDiff);
            Controls.Add(btnOk);
            Controls.Add(btnZ);
            Controls.Add(btnY);
            Controls.Add(btnX);
            Controls.Add(btnW);
            Controls.Add(btnV);
            Controls.Add(btnU);
            Controls.Add(btnT);
            Controls.Add(btnS);
            Controls.Add(lblLettera_inserito);
            Controls.Add(btnR);
            Controls.Add(btnQ);
            Controls.Add(btnP);
            Controls.Add(btnO);
            Controls.Add(btnN);
            Controls.Add(btnM);
            Controls.Add(btnL);
            Controls.Add(btnK);
            Controls.Add(btnJ);
            Controls.Add(btnI);
            Controls.Add(btnH);
            Controls.Add(btnG);
            Controls.Add(btnF);
            Controls.Add(btnE);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(lblRis_lettera_inserita);
            Controls.Add(lblDifficult_scelta);
            Controls.Add(lblTcchetta_difficult);
            Controls.Add(lblTema_scelta);
            Controls.Add(lblTicchetta_tema);
            Controls.Add(lblMonete);
            Controls.Add(lblTicchetta_monete);
            Controls.Add(lblParola);
            Controls.Add(ckbDifficult);
            Controls.Add(ckbTema);
            Controls.Add(btnStart);
            Controls.Add(lblDifficult);
            Controls.Add(lblTema);
            Controls.Add(lblIntro);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnStart;
        private CheckedListBox ckbTema;
        private CheckedListBox ckbDifficult;
        private Label lblParola;
        private Label lblTicchetta_monete;
        private Label lblMonete;
        private Label lblTicchetta_tema;
        private Label lblTema_scelta;
        private Label lblTcchetta_difficult;
        private Label lblDifficult_scelta;
        private Label lblRis_lettera_inserita;
        private Button btnA;
        private Button btnOk;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Label lblLettera_inserito;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnB;
        private Button btnZ;
        private Button btnY;
        private Label lblErrore_TemaDiff;
        private Label lblTicchetta_lettere;
        private Label lblLettere_provate;
        private Label lblTicchetta_Tentativi;
        private Label lblTentativi;
        private Button btnNo;
        private Button btnSi;
        private Label lblDomanda_continua;
        private Button btnPC_no;
        private Button btnPC_si;
        private Label lblParola_completa;
        private Label lblTicchetta_parola_inserito;
        private Button btnParola_inserita;
        private TextBox tbxParola_inserita;
        private ListBox lbxParole_non_indovinate;
        private ListBox lbxParole_indovinate;
    }
}
