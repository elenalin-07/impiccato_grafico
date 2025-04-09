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
            btn_nextpag = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(324, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Impiccato";
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI", 10F);
            lblIntro.Location = new Point(26, 63);
            lblIntro.MaximumSize = new Size(750, 0);
            lblIntro.MinimumSize = new Size(750, 50);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(750, 152);
            lblIntro.TabIndex = 1;
            lblIntro.Text = resources.GetString("lblIntro.Text");
            lblIntro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Cooper Black", 14.25F);
            lblTema.Location = new Point(160, 231);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(162, 21);
            lblTema.TabIndex = 2;
            lblTema.Text = "Scegli una tema";
            // 
            // lblDifficult
            // 
            lblDifficult.AutoSize = true;
            lblDifficult.Font = new Font("Cooper Black", 14.25F);
            lblDifficult.Location = new Point(469, 231);
            lblDifficult.Name = "lblDifficult";
            lblDifficult.Size = new Size(185, 21);
            lblDifficult.TabIndex = 3;
            lblDifficult.Text = "Scegli la difficoltà";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SteelBlue;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Cooper Black", 14.25F);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(354, 373);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(111, 36);
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
            ckbTema.Location = new Point(198, 260);
            ckbTema.Margin = new Padding(3, 2, 3, 2);
            ckbTema.Name = "ckbTema";
            ckbTema.Size = new Size(110, 88);
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
            ckbDifficult.Location = new Point(469, 270);
            ckbDifficult.Margin = new Padding(3, 2, 3, 2);
            ckbDifficult.Name = "ckbDifficult";
            ckbDifficult.Size = new Size(264, 66);
            ckbDifficult.TabIndex = 13;
            ckbDifficult.TabStop = false;
            ckbDifficult.SelectedIndexChanged += ckbDifficult_SelectedIndexChanged;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Font = new Font("AR BLANCA", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParola.Location = new Point(198, 166);
            lblParola.MinimumSize = new Size(438, 15);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(438, 32);
            lblParola.TabIndex = 14;
            lblParola.Text = "parola segreta";
            lblParola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_monete
            // 
            lblTicchetta_monete.AutoSize = true;
            lblTicchetta_monete.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_monete.Location = new Point(10, 63);
            lblTicchetta_monete.Name = "lblTicchetta_monete";
            lblTicchetta_monete.Size = new Size(153, 17);
            lblTicchetta_monete.TabIndex = 16;
            lblTicchetta_monete.Text = "Numero di monete:";
            // 
            // lblMonete
            // 
            lblMonete.AutoSize = true;
            lblMonete.BackColor = SystemColors.Control;
            lblMonete.BorderStyle = BorderStyle.Fixed3D;
            lblMonete.Location = new Point(178, 64);
            lblMonete.MinimumSize = new Size(19, 16);
            lblMonete.Name = "lblMonete";
            lblMonete.Size = new Size(19, 17);
            lblMonete.TabIndex = 17;
            lblMonete.Text = "0";
            lblMonete.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_tema
            // 
            lblTicchetta_tema.AutoSize = true;
            lblTicchetta_tema.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_tema.Location = new Point(10, 102);
            lblTicchetta_tema.Name = "lblTicchetta_tema";
            lblTicchetta_tema.Size = new Size(103, 17);
            lblTicchetta_tema.TabIndex = 18;
            lblTicchetta_tema.Text = "Tema scelta:";
            // 
            // lblTema_scelta
            // 
            lblTema_scelta.AutoSize = true;
            lblTema_scelta.BackColor = SystemColors.Control;
            lblTema_scelta.BorderStyle = BorderStyle.Fixed3D;
            lblTema_scelta.Location = new Point(123, 101);
            lblTema_scelta.MinimumSize = new Size(70, 16);
            lblTema_scelta.Name = "lblTema_scelta";
            lblTema_scelta.Size = new Size(70, 17);
            lblTema_scelta.TabIndex = 19;
            lblTema_scelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTcchetta_difficult
            // 
            lblTcchetta_difficult.AutoSize = true;
            lblTcchetta_difficult.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTcchetta_difficult.Location = new Point(10, 146);
            lblTcchetta_difficult.Name = "lblTcchetta_difficult";
            lblTcchetta_difficult.Size = new Size(133, 17);
            lblTcchetta_difficult.TabIndex = 20;
            lblTcchetta_difficult.Text = "Difficoltà scelta:";
            // 
            // lblDifficult_scelta
            // 
            lblDifficult_scelta.AutoSize = true;
            lblDifficult_scelta.BackColor = SystemColors.Control;
            lblDifficult_scelta.BorderStyle = BorderStyle.Fixed3D;
            lblDifficult_scelta.Location = new Point(156, 145);
            lblDifficult_scelta.MinimumSize = new Size(70, 16);
            lblDifficult_scelta.Name = "lblDifficult_scelta";
            lblDifficult_scelta.Size = new Size(70, 17);
            lblDifficult_scelta.TabIndex = 21;
            lblDifficult_scelta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRis_lettera_inserita
            // 
            lblRis_lettera_inserita.AutoSize = true;
            lblRis_lettera_inserita.Location = new Point(198, 212);
            lblRis_lettera_inserita.MaximumSize = new Size(438, 22);
            lblRis_lettera_inserita.MinimumSize = new Size(438, 22);
            lblRis_lettera_inserita.Name = "lblRis_lettera_inserita";
            lblRis_lettera_inserita.Size = new Size(438, 22);
            lblRis_lettera_inserita.TabIndex = 23;
            lblRis_lettera_inserita.Text = "Oops! La parola che hai provato non è corretta. Non preoccuparti, puoi continuare a giocare! Prova a indovinare un’altra lettera o riprova a indovinare la parola!";
            lblRis_lettera_inserita.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            btnA.BackColor = Color.LightSkyBlue;
            btnA.Cursor = Cursors.Hand;
            btnA.Font = new Font("Cooper Black", 10.2F);
            btnA.Location = new Point(233, 346);
            btnA.Margin = new Padding(3, 2, 3, 2);
            btnA.MinimumSize = new Size(35, 30);
            btnA.Name = "btnA";
            btnA.Size = new Size(35, 30);
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
            btnOk.Location = new Point(463, 277);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.MinimumSize = new Size(0, 22);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(39, 22);
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
            btnC.Location = new Point(354, 380);
            btnC.Margin = new Padding(3, 2, 3, 2);
            btnC.MinimumSize = new Size(35, 30);
            btnC.Name = "btnC";
            btnC.Size = new Size(35, 30);
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
            btnD.Location = new Point(313, 346);
            btnD.Margin = new Padding(3, 2, 3, 2);
            btnD.MinimumSize = new Size(35, 30);
            btnD.Name = "btnD";
            btnD.Size = new Size(35, 30);
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
            btnE.Location = new Point(291, 311);
            btnE.Margin = new Padding(3, 2, 3, 2);
            btnE.MinimumSize = new Size(35, 30);
            btnE.Name = "btnE";
            btnE.Size = new Size(35, 30);
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
            btnF.Location = new Point(354, 346);
            btnF.Margin = new Padding(3, 2, 3, 2);
            btnF.MinimumSize = new Size(35, 30);
            btnF.Name = "btnF";
            btnF.Size = new Size(35, 30);
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
            btnG.Location = new Point(394, 346);
            btnG.Margin = new Padding(3, 2, 3, 2);
            btnG.MinimumSize = new Size(35, 30);
            btnG.Name = "btnG";
            btnG.Size = new Size(35, 30);
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
            btnH.Location = new Point(434, 346);
            btnH.Margin = new Padding(3, 2, 3, 2);
            btnH.MinimumSize = new Size(35, 30);
            btnH.Name = "btnH";
            btnH.Size = new Size(35, 30);
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
            btnI.Location = new Point(493, 311);
            btnI.Margin = new Padding(3, 2, 3, 2);
            btnI.MinimumSize = new Size(35, 30);
            btnI.Name = "btnI";
            btnI.Size = new Size(35, 30);
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
            btnJ.Location = new Point(474, 346);
            btnJ.Margin = new Padding(3, 2, 3, 2);
            btnJ.MinimumSize = new Size(35, 30);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(35, 30);
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
            btnK.Location = new Point(515, 346);
            btnK.Margin = new Padding(3, 2, 3, 2);
            btnK.MinimumSize = new Size(35, 30);
            btnK.Name = "btnK";
            btnK.Size = new Size(35, 30);
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
            btnL.Location = new Point(555, 346);
            btnL.Margin = new Padding(3, 2, 3, 2);
            btnL.MinimumSize = new Size(35, 30);
            btnL.Name = "btnL";
            btnL.Size = new Size(35, 30);
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
            btnM.Location = new Point(514, 380);
            btnM.Margin = new Padding(3, 2, 3, 2);
            btnM.MinimumSize = new Size(35, 30);
            btnM.Name = "btnM";
            btnM.Size = new Size(35, 30);
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
            btnN.Location = new Point(474, 380);
            btnN.Margin = new Padding(3, 2, 3, 2);
            btnN.MinimumSize = new Size(35, 30);
            btnN.Name = "btnN";
            btnN.Size = new Size(35, 30);
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
            btnO.Location = new Point(533, 311);
            btnO.Margin = new Padding(3, 2, 3, 2);
            btnO.MinimumSize = new Size(35, 30);
            btnO.Name = "btnO";
            btnO.Size = new Size(35, 30);
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
            btnP.Location = new Point(573, 311);
            btnP.Margin = new Padding(3, 2, 3, 2);
            btnP.MinimumSize = new Size(35, 30);
            btnP.Name = "btnP";
            btnP.Size = new Size(35, 30);
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
            btnQ.Location = new Point(211, 311);
            btnQ.Margin = new Padding(3, 2, 3, 2);
            btnQ.MinimumSize = new Size(35, 30);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(35, 30);
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
            btnR.Location = new Point(332, 311);
            btnR.Margin = new Padding(3, 2, 3, 2);
            btnR.MinimumSize = new Size(35, 30);
            btnR.Name = "btnR";
            btnR.Size = new Size(35, 30);
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
            lblLettera_inserito.Location = new Point(364, 277);
            lblLettera_inserito.MinimumSize = new Size(88, 23);
            lblLettera_inserito.Name = "lblLettera_inserito";
            lblLettera_inserito.Size = new Size(88, 23);
            lblLettera_inserito.TabIndex = 67;
            lblLettera_inserito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnS
            // 
            btnS.BackColor = Color.LightSkyBlue;
            btnS.Cursor = Cursors.Hand;
            btnS.Font = new Font("Cooper Black", 10.2F);
            btnS.Location = new Point(273, 346);
            btnS.Margin = new Padding(3, 2, 3, 2);
            btnS.MinimumSize = new Size(35, 30);
            btnS.Name = "btnS";
            btnS.Size = new Size(35, 30);
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
            btnT.Location = new Point(372, 311);
            btnT.Margin = new Padding(3, 2, 3, 2);
            btnT.MinimumSize = new Size(35, 30);
            btnT.Name = "btnT";
            btnT.Size = new Size(35, 30);
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
            btnU.Location = new Point(452, 311);
            btnU.Margin = new Padding(3, 2, 3, 2);
            btnU.MinimumSize = new Size(35, 30);
            btnU.Name = "btnU";
            btnU.Size = new Size(35, 30);
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
            btnV.Location = new Point(394, 380);
            btnV.Margin = new Padding(3, 2, 3, 2);
            btnV.MinimumSize = new Size(35, 30);
            btnV.Name = "btnV";
            btnV.Size = new Size(35, 30);
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
            btnW.Location = new Point(251, 311);
            btnW.Margin = new Padding(3, 2, 3, 2);
            btnW.MinimumSize = new Size(35, 30);
            btnW.Name = "btnW";
            btnW.Size = new Size(35, 30);
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
            btnX.Location = new Point(313, 380);
            btnX.Margin = new Padding(3, 2, 3, 2);
            btnX.MinimumSize = new Size(35, 30);
            btnX.Name = "btnX";
            btnX.Size = new Size(35, 30);
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
            btnB.Location = new Point(434, 380);
            btnB.Margin = new Padding(3, 2, 3, 2);
            btnB.MinimumSize = new Size(35, 30);
            btnB.Name = "btnB";
            btnB.Size = new Size(35, 30);
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
            btnZ.Location = new Point(273, 380);
            btnZ.Margin = new Padding(3, 2, 3, 2);
            btnZ.MinimumSize = new Size(35, 30);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(35, 30);
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
            btnY.Location = new Point(412, 311);
            btnY.Margin = new Padding(3, 2, 3, 2);
            btnY.MinimumSize = new Size(35, 30);
            btnY.Name = "btnY";
            btnY.Size = new Size(35, 30);
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
            lblErrore_TemaDiff.Location = new Point(208, 412);
            lblErrore_TemaDiff.Name = "lblErrore_TemaDiff";
            lblErrore_TemaDiff.Size = new Size(403, 25);
            lblErrore_TemaDiff.TabIndex = 77;
            lblErrore_TemaDiff.Text = "Per favore scegli una tema e/o una difficoltà";
            lblErrore_TemaDiff.Visible = false;
            // 
            // lblTicchetta_lettere
            // 
            lblTicchetta_lettere.AutoSize = true;
            lblTicchetta_lettere.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_lettere.Location = new Point(20, 311);
            lblTicchetta_lettere.Name = "lblTicchetta_lettere";
            lblTicchetta_lettere.Size = new Size(118, 16);
            lblTicchetta_lettere.TabIndex = 78;
            lblTicchetta_lettere.Text = "Lettere provate:";
            // 
            // lblLettere_provate
            // 
            lblLettere_provate.AutoSize = true;
            lblLettere_provate.BackColor = SystemColors.Control;
            lblLettere_provate.BorderStyle = BorderStyle.Fixed3D;
            lblLettere_provate.Location = new Point(10, 338);
            lblLettere_provate.MaximumSize = new Size(149, 38);
            lblLettere_provate.MinimumSize = new Size(149, 38);
            lblLettere_provate.Name = "lblLettere_provate";
            lblLettere_provate.Size = new Size(149, 38);
            lblLettere_provate.TabIndex = 79;
            lblLettere_provate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_Tentativi
            // 
            lblTicchetta_Tentativi.AutoSize = true;
            lblTicchetta_Tentativi.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicchetta_Tentativi.Location = new Point(605, 64);
            lblTicchetta_Tentativi.Name = "lblTicchetta_Tentativi";
            lblTicchetta_Tentativi.Size = new Size(143, 17);
            lblTicchetta_Tentativi.TabIndex = 80;
            lblTicchetta_Tentativi.Text = "Tentativi rimasti:";
            // 
            // lblTentativi
            // 
            lblTentativi.AutoSize = true;
            lblTentativi.BackColor = SystemColors.Control;
            lblTentativi.BorderStyle = BorderStyle.Fixed3D;
            lblTentativi.Location = new Point(757, 63);
            lblTentativi.MinimumSize = new Size(19, 16);
            lblTentativi.Name = "lblTentativi";
            lblTentativi.Size = new Size(19, 17);
            lblTentativi.TabIndex = 81;
            lblTentativi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.LightSkyBlue;
            btnNo.Font = new Font("Cooper Black", 12F);
            btnNo.Location = new Point(452, 228);
            btnNo.Margin = new Padding(3, 2, 3, 2);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(125, 48);
            btnNo.TabIndex = 84;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.LightSkyBlue;
            btnSi.Font = new Font("Cooper Black", 12F);
            btnSi.Location = new Point(242, 228);
            btnSi.Margin = new Padding(3, 2, 3, 2);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(125, 48);
            btnSi.TabIndex = 83;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // lblDomanda_continua
            // 
            lblDomanda_continua.AutoSize = true;
            lblDomanda_continua.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomanda_continua.Location = new Point(204, 175);
            lblDomanda_continua.Name = "lblDomanda_continua";
            lblDomanda_continua.Size = new Size(384, 19);
            lblDomanda_continua.TabIndex = 82;
            lblDomanda_continua.Text = "Vuoi provare di nuovo con una nuova parola?";
            lblDomanda_continua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPC_no
            // 
            btnPC_no.BackColor = Color.LightSkyBlue;
            btnPC_no.Font = new Font("Cooper Black", 12F);
            btnPC_no.Location = new Point(468, 346);
            btnPC_no.Margin = new Padding(3, 2, 3, 2);
            btnPC_no.Name = "btnPC_no";
            btnPC_no.Size = new Size(83, 32);
            btnPC_no.TabIndex = 87;
            btnPC_no.Text = "NO";
            btnPC_no.UseVisualStyleBackColor = false;
            // 
            // btnPC_si
            // 
            btnPC_si.BackColor = Color.LightSkyBlue;
            btnPC_si.Font = new Font("Cooper Black", 12F);
            btnPC_si.Location = new Point(259, 346);
            btnPC_si.Margin = new Padding(3, 2, 3, 2);
            btnPC_si.Name = "btnPC_si";
            btnPC_si.Size = new Size(83, 32);
            btnPC_si.TabIndex = 86;
            btnPC_si.Text = "SI";
            btnPC_si.UseVisualStyleBackColor = false;
            btnPC_si.Click += btnPC_si_Click;
            // 
            // lblParola_completa
            // 
            lblParola_completa.AutoSize = true;
            lblParola_completa.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParola_completa.Location = new Point(215, 292);
            lblParola_completa.Name = "lblParola_completa";
            lblParola_completa.Size = new Size(365, 19);
            lblParola_completa.TabIndex = 85;
            lblParola_completa.Text = "Sei pronto a indovinare la parola completa?";
            lblParola_completa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicchetta_parola_inserito
            // 
            lblTicchetta_parola_inserito.AutoSize = true;
            lblTicchetta_parola_inserito.Location = new Point(177, 319);
            lblTicchetta_parola_inserito.Name = "lblTicchetta_parola_inserito";
            lblTicchetta_parola_inserito.Size = new Size(433, 15);
            lblTicchetta_parola_inserito.TabIndex = 90;
            lblTicchetta_parola_inserito.Text = "Perfetto! Hai deciso di provarci. Scrivi la tua risposta e vediamo se hai indovinato!";
            // 
            // btnParola_inserita
            // 
            btnParola_inserita.BackColor = Color.SteelBlue;
            btnParola_inserita.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnParola_inserita.ForeColor = Color.White;
            btnParola_inserita.Location = new Point(434, 350);
            btnParola_inserita.Margin = new Padding(3, 2, 3, 2);
            btnParola_inserita.Name = "btnParola_inserita";
            btnParola_inserita.Size = new Size(82, 22);
            btnParola_inserita.TabIndex = 89;
            btnParola_inserita.Text = "OK";
            btnParola_inserita.UseVisualStyleBackColor = false;
            // 
            // tbxParola_inserita
            // 
            tbxParola_inserita.Location = new Point(303, 352);
            tbxParola_inserita.Margin = new Padding(3, 2, 3, 2);
            tbxParola_inserita.Name = "tbxParola_inserita";
            tbxParola_inserita.Size = new Size(110, 23);
            tbxParola_inserita.TabIndex = 88;
            // 
            // lbxParole_non_indovinate
            // 
            lbxParole_non_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_non_indovinate.FormattingEnabled = true;
            lbxParole_non_indovinate.Items.AddRange(new object[] { "Parole non indovinate:" });
            lbxParole_non_indovinate.Location = new Point(493, 145);
            lbxParole_non_indovinate.Margin = new Padding(3, 2, 3, 2);
            lbxParole_non_indovinate.Name = "lbxParole_non_indovinate";
            lbxParole_non_indovinate.Size = new Size(183, 132);
            lbxParole_non_indovinate.TabIndex = 92;
            // 
            // lbxParole_indovinate
            // 
            lbxParole_indovinate.Font = new Font("Cooper Black", 10.2F);
            lbxParole_indovinate.FormattingEnabled = true;
            lbxParole_indovinate.Items.AddRange(new object[] { "Parole indovinate:" });
            lbxParole_indovinate.Location = new Point(144, 145);
            lbxParole_indovinate.Margin = new Padding(3, 2, 3, 2);
            lbxParole_indovinate.Name = "lbxParole_indovinate";
            lbxParole_indovinate.Size = new Size(183, 132);
            lbxParole_indovinate.TabIndex = 91;
            // 
            // btn_nextpag
            // 
            btn_nextpag.BackColor = Color.RoyalBlue;
            btn_nextpag.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_nextpag.ForeColor = SystemColors.ControlLightLight;
            btn_nextpag.Location = new Point(695, 391);
            btn_nextpag.Name = "btn_nextpag";
            btn_nextpag.Size = new Size(93, 48);
            btn_nextpag.TabIndex = 93;
            btn_nextpag.Text = "Next Page";
            btn_nextpag.UseVisualStyleBackColor = false;
            btn_nextpag.Click += btn_nextpag_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_nextpag);
            Controls.Add(lblParola);
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
            Controls.Add(ckbDifficult);
            Controls.Add(ckbTema);
            Controls.Add(btnStart);
            Controls.Add(lblDifficult);
            Controls.Add(lblTema);
            Controls.Add(lblTitle);
            Controls.Add(lblIntro);
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
        private Button btn_nextpag;
    }
}
