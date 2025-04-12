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
            lblErrore = new Label();
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
            lblErrore_parola_inserita = new Label();
            lblGioco = new Label();
            lblIntro_indizi3 = new Label();
            lblTitle_indizi = new Label();
            lblIntro_indizi2 = new Label();
            btnIndizio_no = new Button();
            btnIndizio_si = new Button();
            lblIntro_indizi1 = new Label();
            btnIndizio_scelto = new Button();
            lblConquista_indizio = new Label();
            ckbIndizio = new CheckedListBox();
            lblIndizio_acquistato = new Label();
            lblTicchetta_indizio_acquistato = new Label();
            lblRis_indizio = new Label();
            btnExtra_chance_no = new Button();
            btnExtra_chance_si = new Button();
            lblintro_extra_chance = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(162, 27);
            lblTitle.MinimumSize = new Size(900, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(900, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Impiccato";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI", 10F);
            lblIntro.Location = new Point(162, 106);
            lblIntro.MaximumSize = new Size(900, 0);
            lblIntro.MinimumSize = new Size(900, 67);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(900, 184);
            lblIntro.TabIndex = 1;
            lblIntro.Text = resources.GetString("lblIntro.Text");
            lblIntro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Cooper Black", 14.25F);
            lblTema.Location = new Point(250, 334);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(204, 27);
            lblTema.TabIndex = 2;
            lblTema.Text = "Scegli una tema";
            // 
            // lblDifficult
            // 
            lblDifficult.AutoSize = true;
            lblDifficult.Font = new Font("Cooper Black", 14.25F);
            lblDifficult.Location = new Point(737, 334);
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
            btnStart.Location = new Point(546, 554);
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
            ckbTema.Location = new Point(282, 391);
            ckbTema.Name = "ckbTema";
            ckbTema.Size = new Size(193, 135);
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
            ckbDifficult.Location = new Point(736, 399);
            ckbDifficult.Name = "ckbDifficult";
            ckbDifficult.Size = new Size(309, 108);
            ckbDifficult.TabIndex = 13;
            ckbDifficult.TabStop = false;
            ckbDifficult.SelectedIndexChanged += ckbDifficult_SelectedIndexChanged;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Transparent;
            lblParola.Font = new Font("Lucida Bright", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblParola.Location = new Point(366, 249);
            lblParola.MinimumSize = new Size(500, 20);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(500, 54);
            lblParola.TabIndex = 14;
            lblParola.Text = "____";
            lblParola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_monete
            // 
            lblTicchetta_monete.AutoSize = true;
            lblTicchetta_monete.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_monete.Location = new Point(12, 122);
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
            lblMonete.Location = new Point(204, 123);
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
            lblTicchetta_tema.Location = new Point(12, 188);
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
            lblTema_scelta.Location = new Point(141, 187);
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
            lblTcchetta_difficult.Location = new Point(12, 263);
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
            lblDifficult_scelta.Location = new Point(178, 261);
            lblDifficult_scelta.MinimumSize = new Size(80, 22);
            lblDifficult_scelta.Name = "lblDifficult_scelta";
            lblDifficult_scelta.Size = new Size(80, 22);
            lblDifficult_scelta.TabIndex = 21;
            lblDifficult_scelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRis_lettera_inserita
            // 
            lblRis_lettera_inserita.AutoSize = true;
            lblRis_lettera_inserita.Location = new Point(374, 312);
            lblRis_lettera_inserita.MaximumSize = new Size(500, 0);
            lblRis_lettera_inserita.MinimumSize = new Size(500, 0);
            lblRis_lettera_inserita.Name = "lblRis_lettera_inserita";
            lblRis_lettera_inserita.Size = new Size(500, 60);
            lblRis_lettera_inserita.TabIndex = 23;
            lblRis_lettera_inserita.Text = "Oops! La parola che hai provato non è corretta. Non preoccuparti, puoi continuare a giocare! Prova a indovinare un’altra lettera o riprova a indovinare la parola!";
            lblRis_lettera_inserita.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightSkyBlue;
            btnA.Cursor = Cursors.Hand;
            btnA.Font = new Font("Cooper Black", 10.2F);
            btnA.Location = new Point(414, 491);
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
            btnOk.Location = new Point(677, 399);
            btnOk.MinimumSize = new Size(0, 30);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(45, 30);
            btnOk.TabIndex = 76;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.LightSkyBlue;
            btnC.Cursor = Cursors.Hand;
            btnC.Font = new Font("Cooper Black", 10.2F);
            btnC.Location = new Point(552, 537);
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
            btnD.Location = new Point(506, 491);
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
            btnE.Location = new Point(481, 445);
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
            btnF.Location = new Point(552, 491);
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
            btnG.Location = new Point(598, 491);
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
            btnH.Location = new Point(644, 491);
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
            btnI.Location = new Point(711, 445);
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
            btnJ.Location = new Point(690, 491);
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
            btnK.Location = new Point(737, 491);
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
            btnL.Location = new Point(782, 491);
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
            btnM.Location = new Point(736, 537);
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
            btnN.Location = new Point(690, 537);
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
            btnO.Location = new Point(757, 445);
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
            btnP.Location = new Point(803, 445);
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
            btnQ.Location = new Point(389, 445);
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
            btnR.Location = new Point(527, 445);
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
            lblLettera_inserito.Location = new Point(564, 399);
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
            btnS.Location = new Point(460, 491);
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
            btnT.Location = new Point(573, 445);
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
            btnU.Location = new Point(665, 445);
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
            btnV.Location = new Point(598, 537);
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
            btnW.Location = new Point(435, 445);
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
            btnX.Location = new Point(506, 537);
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
            btnB.Location = new Point(644, 537);
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
            btnZ.Location = new Point(460, 537);
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
            btnY.Location = new Point(619, 445);
            btnY.MinimumSize = new Size(40, 40);
            btnY.Name = "btnY";
            btnY.Size = new Size(40, 40);
            btnY.TabIndex = 74;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            btnY.Click += btnY_Click;
            // 
            // lblErrore
            // 
            lblErrore.AutoSize = true;
            lblErrore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrore.ForeColor = Color.Red;
            lblErrore.Location = new Point(162, 624);
            lblErrore.MinimumSize = new Size(900, 0);
            lblErrore.Name = "lblErrore";
            lblErrore.Size = new Size(900, 31);
            lblErrore.TabIndex = 77;
            lblErrore.Text = "Per favore";
            lblErrore.TextAlign = ContentAlignment.MiddleCenter;
            lblErrore.Visible = false;
            // 
            // lblTicchetta_lettere
            // 
            lblTicchetta_lettere.AutoSize = true;
            lblTicchetta_lettere.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_lettere.Location = new Point(12, 377);
            lblTicchetta_lettere.Name = "lblTicchetta_lettere";
            lblTicchetta_lettere.Size = new Size(159, 21);
            lblTicchetta_lettere.TabIndex = 78;
            lblTicchetta_lettere.Text = "Lettere provate:";
            // 
            // lblLettere_provate
            // 
            lblLettere_provate.AutoSize = true;
            lblLettere_provate.BackColor = SystemColors.Control;
            lblLettere_provate.BorderStyle = BorderStyle.Fixed3D;
            lblLettere_provate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLettere_provate.Location = new Point(12, 407);
            lblLettere_provate.MaximumSize = new Size(170, 70);
            lblLettere_provate.MinimumSize = new Size(170, 70);
            lblLettere_provate.Name = "lblLettere_provate";
            lblLettere_provate.Size = new Size(170, 70);
            lblLettere_provate.TabIndex = 79;
            lblLettere_provate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_Tentativi
            // 
            lblTicchetta_Tentativi.AutoSize = true;
            lblTicchetta_Tentativi.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_Tentativi.Location = new Point(949, 118);
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
            lblTentativi.Location = new Point(1125, 116);
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
            btnNo.Location = new Point(665, 334);
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
            btnSi.Location = new Point(424, 334);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(143, 64);
            btnSi.TabIndex = 83;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // lblDomanda_continua
            // 
            lblDomanda_continua.AutoSize = true;
            lblDomanda_continua.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomanda_continua.Location = new Point(371, 261);
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
            btnPC_no.Location = new Point(683, 491);
            btnPC_no.Name = "btnPC_no";
            btnPC_no.Size = new Size(95, 43);
            btnPC_no.TabIndex = 87;
            btnPC_no.Text = "NO";
            btnPC_no.UseVisualStyleBackColor = false;
            btnPC_no.Click += btnPC_no_Click;
            // 
            // btnPC_si
            // 
            btnPC_si.BackColor = Color.LightSkyBlue;
            btnPC_si.Font = new Font("Cooper Black", 12F);
            btnPC_si.Location = new Point(444, 491);
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
            lblParola_completa.Location = new Point(394, 419);
            lblParola_completa.Name = "lblParola_completa";
            lblParola_completa.Size = new Size(449, 23);
            lblParola_completa.TabIndex = 85;
            lblParola_completa.Text = "Sei pronto a indovinare la parola completa?";
            lblParola_completa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_parola_inserito
            // 
            lblTicchetta_parola_inserito.AutoSize = true;
            lblTicchetta_parola_inserito.Location = new Point(350, 455);
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
            btnParola_inserita.Location = new Point(644, 497);
            btnParola_inserita.Name = "btnParola_inserita";
            btnParola_inserita.Size = new Size(94, 29);
            btnParola_inserita.TabIndex = 89;
            btnParola_inserita.Text = "OK";
            btnParola_inserita.UseVisualStyleBackColor = false;
            btnParola_inserita.Click += btnParola_inserita_Click;
            // 
            // tbxParola_inserita
            // 
            tbxParola_inserita.Location = new Point(497, 500);
            tbxParola_inserita.Name = "tbxParola_inserita";
            tbxParola_inserita.Size = new Size(125, 27);
            tbxParola_inserita.TabIndex = 88;
            // 
            // lbxParole_non_indovinate
            // 
            lbxParole_non_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_non_indovinate.FormattingEnabled = true;
            lbxParole_non_indovinate.Items.AddRange(new object[] { "Parole non indovinate:" });
            lbxParole_non_indovinate.Location = new Point(711, 223);
            lbxParole_non_indovinate.Name = "lbxParole_non_indovinate";
            lbxParole_non_indovinate.Size = new Size(209, 184);
            lbxParole_non_indovinate.TabIndex = 92;
            // 
            // lbxParole_indovinate
            // 
            lbxParole_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_indovinate.FormattingEnabled = true;
            lbxParole_indovinate.Items.AddRange(new object[] { "Parole indovinate:" });
            lbxParole_indovinate.Location = new Point(312, 223);
            lbxParole_indovinate.Name = "lbxParole_indovinate";
            lbxParole_indovinate.Size = new Size(209, 184);
            lbxParole_indovinate.TabIndex = 91;
            // 
            // lblErrore_parola_inserita
            // 
            lblErrore_parola_inserita.AutoSize = true;
            lblErrore_parola_inserita.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrore_parola_inserita.ForeColor = Color.Red;
            lblErrore_parola_inserita.Location = new Point(481, 526);
            lblErrore_parola_inserita.Name = "lblErrore_parola_inserita";
            lblErrore_parola_inserita.Size = new Size(281, 28);
            lblErrore_parola_inserita.TabIndex = 93;
            lblErrore_parola_inserita.Text = "Per favore inserisci la parola";
            lblErrore_parola_inserita.Visible = false;
            // 
            // lblGioco
            // 
            lblGioco.AutoSize = true;
            lblGioco.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGioco.Location = new Point(291, 229);
            lblGioco.MaximumSize = new Size(644, 23);
            lblGioco.MinimumSize = new Size(644, 23);
            lblGioco.Name = "lblGioco";
            lblGioco.Size = new Size(644, 23);
            lblGioco.TabIndex = 94;
            lblGioco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntro_indizi3
            // 
            lblIntro_indizi3.AutoSize = true;
            lblIntro_indizi3.Location = new Point(162, 314);
            lblIntro_indizi3.MinimumSize = new Size(900, 20);
            lblIntro_indizi3.Name = "lblIntro_indizi3";
            lblIntro_indizi3.Size = new Size(900, 20);
            lblIntro_indizi3.TabIndex = 100;
            lblIntro_indizi3.Text = "Per aiutarti a risolvere il mistero, puoi acquistare un indizio! (si/no)";
            lblIntro_indizi3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle_indizi
            // 
            lblTitle_indizi.AutoSize = true;
            lblTitle_indizi.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle_indizi.Location = new Point(162, 85);
            lblTitle_indizi.MinimumSize = new Size(900, 32);
            lblTitle_indizi.Name = "lblTitle_indizi";
            lblTitle_indizi.Size = new Size(900, 32);
            lblTitle_indizi.TabIndex = 99;
            lblTitle_indizi.Text = "Indizi";
            lblTitle_indizi.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle_indizi.Click += lblTitle_indizi_Click;
            // 
            // lblIntro_indizi2
            // 
            lblIntro_indizi2.AutoSize = true;
            lblIntro_indizi2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntro_indizi2.Location = new Point(141, 223);
            lblIntro_indizi2.MaximumSize = new Size(900, 80);
            lblIntro_indizi2.MinimumSize = new Size(900, 80);
            lblIntro_indizi2.Name = "lblIntro_indizi2";
            lblIntro_indizi2.Size = new Size(900, 80);
            lblIntro_indizi2.TabIndex = 98;
            lblIntro_indizi2.Text = "Ecco le opzioni che hai a disposizione:\r\n1. Dizionario - Scopri la prima lettera della parola\r\n2. Sorgente - Ottieni una lettera casuale e ti dirà se è presente nella parola";
            lblIntro_indizi2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIndizio_no
            // 
            btnIndizio_no.BackColor = Color.RoyalBlue;
            btnIndizio_no.Font = new Font("Cooper Black", 13.8F);
            btnIndizio_no.ForeColor = Color.White;
            btnIndizio_no.Location = new Point(694, 363);
            btnIndizio_no.Name = "btnIndizio_no";
            btnIndizio_no.Size = new Size(122, 49);
            btnIndizio_no.TabIndex = 97;
            btnIndizio_no.Text = "No";
            btnIndizio_no.UseVisualStyleBackColor = false;
            btnIndizio_no.Click += btnIndizio_no_Click;
            // 
            // btnIndizio_si
            // 
            btnIndizio_si.BackColor = Color.RoyalBlue;
            btnIndizio_si.Font = new Font("Cooper Black", 13.8F);
            btnIndizio_si.ForeColor = Color.White;
            btnIndizio_si.Location = new Point(366, 363);
            btnIndizio_si.Name = "btnIndizio_si";
            btnIndizio_si.Size = new Size(122, 49);
            btnIndizio_si.TabIndex = 96;
            btnIndizio_si.Text = "Si";
            btnIndizio_si.UseVisualStyleBackColor = false;
            btnIndizio_si.Click += btnIndizio_si_Click;
            // 
            // lblIntro_indizi1
            // 
            lblIntro_indizi1.AutoSize = true;
            lblIntro_indizi1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntro_indizi1.Location = new Point(141, 170);
            lblIntro_indizi1.MaximumSize = new Size(900, 50);
            lblIntro_indizi1.MinimumSize = new Size(900, 50);
            lblIntro_indizi1.Name = "lblIntro_indizi1";
            lblIntro_indizi1.Size = new Size(900, 50);
            lblIntro_indizi1.TabIndex = 95;
            lblIntro_indizi1.Text = resources.GetString("lblIntro_indizi1.Text");
            lblIntro_indizi1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIndizio_scelto
            // 
            btnIndizio_scelto.BackColor = Color.MediumSlateBlue;
            btnIndizio_scelto.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIndizio_scelto.ForeColor = Color.White;
            btnIndizio_scelto.Location = new Point(552, 491);
            btnIndizio_scelto.Name = "btnIndizio_scelto";
            btnIndizio_scelto.Size = new Size(121, 56);
            btnIndizio_scelto.TabIndex = 103;
            btnIndizio_scelto.Text = "OK";
            btnIndizio_scelto.UseVisualStyleBackColor = false;
            btnIndizio_scelto.Click += btnIndizio_scelto_Click;
            // 
            // lblConquista_indizio
            // 
            lblConquista_indizio.AutoSize = true;
            lblConquista_indizio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConquista_indizio.Location = new Point(141, 334);
            lblConquista_indizio.MinimumSize = new Size(900, 0);
            lblConquista_indizio.Name = "lblConquista_indizio";
            lblConquista_indizio.Size = new Size(900, 25);
            lblConquista_indizio.TabIndex = 102;
            lblConquista_indizio.Text = "Perfetto! Hai deciso di acquistare un indizio. Ora, scegli quale opzione vuoi utilizzare:";
            lblConquista_indizio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbIndizio
            // 
            ckbIndizio.BackColor = Color.LightBlue;
            ckbIndizio.BorderStyle = BorderStyle.None;
            ckbIndizio.Font = new Font("Segoe UI Light", 11F);
            ckbIndizio.FormattingEnabled = true;
            ckbIndizio.Items.AddRange(new object[] { "1. Dizionario – 3 monete", "2. Sorgente - 2 monete" });
            ckbIndizio.Location = new Point(479, 377);
            ckbIndizio.Name = "ckbIndizio";
            ckbIndizio.Size = new Size(243, 81);
            ckbIndizio.TabIndex = 101;
            ckbIndizio.SelectedIndexChanged += ckbIndizio_SelectedIndexChanged;
            // 
            // lblIndizio_acquistato
            // 
            lblIndizio_acquistato.AutoSize = true;
            lblIndizio_acquistato.BackColor = SystemColors.Control;
            lblIndizio_acquistato.BorderStyle = BorderStyle.Fixed3D;
            lblIndizio_acquistato.Location = new Point(1077, 171);
            lblIndizio_acquistato.MinimumSize = new Size(70, 22);
            lblIndizio_acquistato.Name = "lblIndizio_acquistato";
            lblIndizio_acquistato.Size = new Size(70, 22);
            lblIndizio_acquistato.TabIndex = 105;
            lblIndizio_acquistato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_indizio_acquistato
            // 
            lblTicchetta_indizio_acquistato.AutoSize = true;
            lblTicchetta_indizio_acquistato.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_indizio_acquistato.Location = new Point(893, 172);
            lblTicchetta_indizio_acquistato.Name = "lblTicchetta_indizio_acquistato";
            lblTicchetta_indizio_acquistato.Size = new Size(178, 21);
            lblTicchetta_indizio_acquistato.TabIndex = 104;
            lblTicchetta_indizio_acquistato.Text = "Indizio acquistato:";
            // 
            // lblRis_indizio
            // 
            lblRis_indizio.AutoSize = true;
            lblRis_indizio.Location = new Point(897, 206);
            lblRis_indizio.MaximumSize = new Size(250, 80);
            lblRis_indizio.MinimumSize = new Size(250, 80);
            lblRis_indizio.Name = "lblRis_indizio";
            lblRis_indizio.Size = new Size(250, 80);
            lblRis_indizio.TabIndex = 106;
            lblRis_indizio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExtra_chance_no
            // 
            btnExtra_chance_no.BackColor = Color.CadetBlue;
            btnExtra_chance_no.Font = new Font("Cooper Black", 10.2F);
            btnExtra_chance_no.ForeColor = Color.White;
            btnExtra_chance_no.Location = new Point(690, 492);
            btnExtra_chance_no.Name = "btnExtra_chance_no";
            btnExtra_chance_no.Size = new Size(106, 38);
            btnExtra_chance_no.TabIndex = 109;
            btnExtra_chance_no.Text = "No";
            btnExtra_chance_no.UseVisualStyleBackColor = false;
            btnExtra_chance_no.Click += btnExtra_chance_no_Click;
            // 
            // btnExtra_chance_si
            // 
            btnExtra_chance_si.BackColor = Color.CadetBlue;
            btnExtra_chance_si.Font = new Font("Cooper Black", 10.2F);
            btnExtra_chance_si.ForeColor = Color.White;
            btnExtra_chance_si.Location = new Point(433, 491);
            btnExtra_chance_si.Name = "btnExtra_chance_si";
            btnExtra_chance_si.Size = new Size(106, 38);
            btnExtra_chance_si.TabIndex = 108;
            btnExtra_chance_si.Text = "Si";
            btnExtra_chance_si.UseVisualStyleBackColor = false;
            btnExtra_chance_si.Click += btnExtra_chance_si_Click;
            // 
            // lblintro_extra_chance
            // 
            lblintro_extra_chance.AutoSize = true;
            lblintro_extra_chance.Location = new Point(272, 415);
            lblintro_extra_chance.MaximumSize = new Size(700, 0);
            lblintro_extra_chance.MinimumSize = new Size(700, 0);
            lblintro_extra_chance.Name = "lblintro_extra_chance";
            lblintro_extra_chance.Size = new Size(700, 40);
            lblintro_extra_chance.TabIndex = 107;
            lblintro_extra_chance.Text = resources.GetString("lblintro_extra_chance.Text");
            lblintro_extra_chance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1172, 664);
            Controls.Add(btnExtra_chance_no);
            Controls.Add(btnExtra_chance_si);
            Controls.Add(lblintro_extra_chance);
            Controls.Add(lblDifficult_scelta);
            Controls.Add(lblRis_indizio);
            Controls.Add(lblIndizio_acquistato);
            Controls.Add(lblTicchetta_indizio_acquistato);
            Controls.Add(lblMonete);
            Controls.Add(lblTicchetta_monete);
            Controls.Add(btnIndizio_scelto);
            Controls.Add(lblConquista_indizio);
            Controls.Add(ckbIndizio);
            Controls.Add(lblIntro_indizi3);
            Controls.Add(lblTitle_indizi);
            Controls.Add(btnIndizio_no);
            Controls.Add(btnIndizio_si);
            Controls.Add(lblIntro_indizi1);
            Controls.Add(btnStart);
            Controls.Add(lblTentativi);
            Controls.Add(lblTicchetta_Tentativi);
            Controls.Add(lblLettere_provate);
            Controls.Add(lblTicchetta_lettere);
            Controls.Add(lblErrore);
            Controls.Add(btnZ);
            Controls.Add(btnX);
            Controls.Add(btnW);
            Controls.Add(btnV);
            Controls.Add(btnQ);
            Controls.Add(btnP);
            Controls.Add(btnO);
            Controls.Add(btnN);
            Controls.Add(btnM);
            Controls.Add(btnL);
            Controls.Add(btnI);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(lblTcchetta_difficult);
            Controls.Add(lblTema_scelta);
            Controls.Add(lblTicchetta_tema);
            Controls.Add(lblTitle);
            Controls.Add(lblTicchetta_parola_inserito);
            Controls.Add(lblParola_completa);
            Controls.Add(btnPC_si);
            Controls.Add(btnOk);
            Controls.Add(lblLettera_inserito);
            Controls.Add(ckbDifficult);
            Controls.Add(ckbTema);
            Controls.Add(lblDifficult);
            Controls.Add(lblTema);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblRis_lettera_inserita);
            Controls.Add(btnD);
            Controls.Add(btnE);
            Controls.Add(btnR);
            Controls.Add(btnT);
            Controls.Add(btnY);
            Controls.Add(btnU);
            Controls.Add(btnS);
            Controls.Add(tbxParola_inserita);
            Controls.Add(btnK);
            Controls.Add(btnF);
            Controls.Add(btnG);
            Controls.Add(lblErrore_parola_inserita);
            Controls.Add(btnParola_inserita);
            Controls.Add(btnPC_no);
            Controls.Add(btnJ);
            Controls.Add(btnH);
            Controls.Add(lblParola);
            Controls.Add(lblGioco);
            Controls.Add(lbxParole_indovinate);
            Controls.Add(lbxParole_non_indovinate);
            Controls.Add(lblIntro_indizi2);
            Controls.Add(lblDomanda_continua);
            Controls.Add(lblIntro);
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
        private Label lblErrore;
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
        private Label lblErrore_parola_inserita;
        private Label lblGioco;
        private Label lblIntro_indizi3;
        private Label lblTitle_indizi;
        private Label lblIntro_indizi2;
        private Button btnIndizio_no;
        private Button btnIndizio_si;
        private Label lblIntro_indizi1;
        private Button btnIndizio_scelto;
        private Label lblConquista_indizio;
        private CheckedListBox ckbIndizio;
        private Label lblIndizio_acquistato;
        private Label lblTicchetta_indizio_acquistato;
        private Label lblRis_indizio;
        private Button btnExtra_chance_no;
        private Button btnExtra_chance_si;
        private Label lblintro_extra_chance;
    }
}
