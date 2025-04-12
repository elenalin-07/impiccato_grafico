using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace impiccato_grafic
{
    public partial class Form1 : Form
    {
        private GroupBox firstpag;
        private GroupBox secondpag;
        private Button[] tastiera = new Button[26];
        private GroupBox thirdpag;
        private GroupBox fourthpag;
        private GroupBox lastpag;
        private GroupBox indizi;

        public Form1()
        {
            InitializeComponent();
            inizio();
        }

        char lettera, lettera_inserita;
        string parola_segreta = "";
        int num_tentativi = 0, monete = 10;
        bool game;
        int posizione_indovinate = 0, posizione_non_indovinate = 0;
        int nm = 0, posizione_parole_uscite = 0, ind = 0;
        string[] parole_indovinate = new string[60];
        string[] parole_non_indovinate = new string[60];
        string[] parole_uscite = new string[60];

        string[] parola_scelte = new string[20];
        string parola;

        char[] parola_con_trattini;

        string indizio;

        Random random = new Random();

        private void inizio()
        {
            firstpag = new GroupBox();
            firstpag.Dock = DockStyle.Fill;
            firstpag.Controls.Add(lblIntro);
            firstpag.Controls.Add(lblTema);
            firstpag.Controls.Add(lblDifficult);
            firstpag.Controls.Add(ckbDifficult);
            firstpag.Controls.Add(ckbTema);
            firstpag.Controls.Add(btnStart);

            this.Controls.Add(firstpag);

            secondpag = new GroupBox();
            secondpag.Dock = DockStyle.Fill;
            secondpag.Controls.Add(lblParola);
            secondpag.Controls.Add(lblTicchetta_tema);
            secondpag.Controls.Add(lblTema_scelta);
            secondpag.Controls.Add(lblTcchetta_difficult);
            secondpag.Controls.Add(lblDifficult_scelta);
            secondpag.Controls.Add(lblRis_lettera_inserita);
            secondpag.Controls.Add(lblTicchetta_lettere);
            secondpag.Controls.Add(lblLettere_provate);
            secondpag.Controls.Add(lblTicchetta_Tentativi);
            secondpag.Controls.Add(lblTentativi);
            secondpag.Controls.Add(lblTicchetta_indizio_acquistato);
            secondpag.Controls.Add(lblIndizio_acquistato);
            secondpag.Controls.Add(lblRis_indizio);

            Button[] btn_lettere = { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                tastiera[i] = btn_lettere[i];
            }

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                secondpag.Controls.Add(btn_lettere[i]);
            }

            secondpag.Controls.Add(lblLettera_inserito);
            secondpag.Controls.Add(btnOk);


            this.Controls.Add(secondpag);

            thirdpag = new GroupBox();
            thirdpag.Dock = DockStyle.Fill;
            thirdpag.Controls.Add(lblDomanda_continua);
            thirdpag.Controls.Add(btnSi);
            thirdpag.Controls.Add(btnNo);

            this.Controls.Add(thirdpag);


            fourthpag = new GroupBox();
            fourthpag.Dock = DockStyle.Fill;

            fourthpag.Controls.Add(lblDomanda_continua);
            fourthpag.Controls.Add(btnSi);
            fourthpag.Controls.Add(btnNo);
            fourthpag.Controls.Add(lblGioco);

            this.Controls.Add(fourthpag);

            lastpag = new GroupBox();
            lastpag.Dock = DockStyle.Fill;

            lastpag.Controls.Add(lbxParole_indovinate);
            lastpag.Controls.Add(lbxParole_non_indovinate);

            this.Controls.Add(lastpag);

            indizi = new GroupBox();
            indizi.Dock = DockStyle.Fill;

            indizi.Controls.Add(lblTitle_indizi);
            indizi.Controls.Add(lblIntro_indizi1);
            indizi.Controls.Add(lblIntro_indizi2);

            this.Controls.Add(indizi);

            firstpag.Visible = true;
            secondpag.Visible = false;
            thirdpag.Visible = false;

            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            lblTicchetta_parola_inserito.Visible = false;
            tbxParola_inserita.Visible = false;
            btnParola_inserita.Visible = false;

            fourthpag.Visible = false;
            lastpag.Visible = false;
            indizi.Visible = false;

            lblIntro_indizi3.Visible = false;
            btnIndizio_si.Visible = false;
            btnIndizio_no.Visible = false;
            lblConquista_indizio.Visible = false;
            ckbIndizio.Visible = false;
            btnIndizio_scelto.Visible = false;

            lblTicchetta_monete.Visible = false;
            lblMonete.Visible = false;

            lblintro_extra_chance.Visible = true;
            btnExtra_chance_si.Visible = true;
            btnExtra_chance_no.Visible = true;

            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;

            lblMonete.Text = monete.ToString();
        }

        private void ckbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ckbTema.SelectedIndex;
            int count = ckbTema.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    ckbTema.SetItemChecked(i, false);
                }
            }
        }

        private void ckbDifficult_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ckbDifficult.SelectedIndex;
            int count = ckbDifficult.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    ckbDifficult.SetItemChecked(i, false);
                }
            }
        }

        string tema, difficult;
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblErrore.Text = "Per favore scegli una tema e / o una difficoltà";
            for (int i = 0; i < ckbTema.Items.Count; i++)
            {
                if (ckbTema.GetItemChecked(i))
                {
                    tema = ckbTema.Items[i].ToString();
                }
            }

            for (int i = 0; i < ckbDifficult.Items.Count; i++)
            {
                if (ckbDifficult.GetItemChecked(i))
                {
                    difficult = ckbDifficult.Items[i].ToString();
                }
            }

            if (tema != null && difficult != null)
            {
                firstpag.Visible = false;
                indizi.Visible = true;

                lblTicchetta_monete.Visible = true;
                lblMonete.Visible = true;

                lblIntro_indizi3.Visible = true;
                btnIndizio_si.Visible = true;
                btnIndizio_no.Visible = true;

                lblErrore.Visible = false;
            }
            else
            {
                lblErrore.Visible = true;
            }

            Array.Clear(lettere_provate);
            tentativi = 0;
            n_prove = 0;
            lettere_indovinate = 0;
            lblLettera_inserito.Text = null;
            lblRis_indizio.Text = null;
            lblIndizio_acquistato.Text = null;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lettera = 'a';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            lettera = 'b';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lettera = 'c';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void D_Click(object sender, EventArgs e)
        {
            lettera = 'd';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            lettera = 'e';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            lettera = 'f';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            lettera = 'g';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            lettera = 'h';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            lettera = 'i';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            lettera = 'j';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            lettera = 'k';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lettera = 'l';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            lettera = 'm';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            lettera = 'n';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            lettera = 'o';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            lettera = 'p';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            lettera = 'q';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lettera = 'r';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            lettera = 's';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            lettera = 't';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            lettera = 'u';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            lettera = 'v';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            lettera = 'w';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            lettera = 'x';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            lettera = 'y';
            lblLettera_inserito.Text = lettera.ToString();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            lettera = 'z';
            lblLettera_inserito.Text = lettera.ToString();
        }

        void controllo()
        {
            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;

            lblGioco.Visible = true;
            if (game == true)
            {
                monete += nm;
                lblMonete.Text = monete.ToString();
                lblGioco.Text = "Congratulazioni! Hai indovinato la parola!";
                parole_indovinate[posizione_indovinate++] = parola_segreta;
                lbxParole_indovinate.Items.Add(parola_segreta);
            }
            else
            {
                lblGioco.Text = $"Hai esaurito i tentativi. La parola segreta era: {parola_segreta}";
                parole_non_indovinate[posizione_non_indovinate++] = parola_segreta;
                lbxParole_non_indovinate.Items.Add(parola_segreta);

            }

            firstpag.Visible = false;
            secondpag.Visible = false;

            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;


            thirdpag.Visible = false;

            lblTicchetta_monete.Visible = false;
            lblMonete.Visible = false;

            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            lblTicchetta_parola_inserito.Visible = false;
            tbxParola_inserita.Visible = false;
            btnParola_inserita.Visible = false;

            fourthpag.Visible = true;
            lastpag.Visible = false;
        }

        char[] lettere_alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        void gioco()
        {
            lblIndizio_acquistato.Text = null;
            lblLettere_provate.Text = null;
            lblRis_lettera_inserita.Text = null;

            if (difficult.Contains("Facile"))
            {
                difficult = difficult.Substring(0, 6);
            }
            else if (difficult.Contains("Normale"))
            {
                difficult = difficult.Substring(0, 7);
            }
            else
            {
                difficult = difficult.Substring(0, 9);

            }

            lblDifficult_scelta.Text = difficult;
            lblTema_scelta.Text = tema;
            string filePath = tema_scelta(tema);
            string[] lines = File.ReadAllLines(filePath);
            parole(lines, ref parola_scelte, ref num_tentativi, ref nm, difficult);
            parola = parola_casuale(parola_scelte, parole_uscite);
            parola_segreta = parola_da_indovina(parola);

            parola_con_trattini = new char[parola_segreta.Length];

            for (int i = 0; i < parola_segreta.Length; i++)
            {
                parola_con_trattini[i] = '_';
            }

            lblTentativi.Text = num_tentativi.ToString();

            parole_uscite[posizione_parole_uscite++] = parola_segreta;

            lblMonete.Text = monete.ToString();

            int first_letter = 0;
            if (ind == 1)
            {
                lblIndizio_acquistato.Text = "Dizionario";
                lblRis_indizio.Text = "Hai acquistato un indizio!" +
                    $"\nUna lettera è stata rivelata: {parola_segreta[0]}";

                parola_con_trattini[0] = parola_segreta[0];

                for (int i = 0; i < parola_segreta.Length; i++)
                {
                    if (parola_segreta[i] == parola_segreta[0])
                    {
                        first_letter++;
                    }
                }

                if (first_letter == 1)
                {
                    lettere_provate[n_prove++] = parola_segreta[0];
                    lblLettere_provate.Text += parola_segreta[0] + " ";
                }

                ind = 0;
            }

            else if (ind == 2)
            {
                sorgente();
                ind = 0;
            }

            lblParola.Text = new string(parola_con_trattini);
        }

        int tentativi = 0, n_prove = 0, lettere_indovinate = 0;
        char[] lettere_provate = new char[26];

        void sorgente()
        {
            bool contains = false;

            lblIndizio_acquistato.Text = "Sorgente";
            int carattere = random.Next(1, 27);

            lblRis_indizio.Text = "Hai acquistato un indizio!" +
                $"\nUna lettera è stata rivelata: {lettere_alfabeto[carattere]}";

            lettere_provate[n_prove++] = lettere_alfabeto[carattere];
            lblLettere_provate.Text += lettere_alfabeto[carattere] + " ";

            if (parola_segreta.Contains(lettere_alfabeto[carattere]))
            {
                for (int i = 0; i < parola_segreta.Length; i++)
                {
                    if (parola_segreta[i] == lettere_alfabeto[carattere])
                    {
                        contains = true;
                        parola_con_trattini[i] = lettere_alfabeto[carattere];
                    }
                }
                if (contains == true)
                {
                    lblRis_indizio.Text = $"La lettera {lettere_alfabeto[carattere]} è presente nella parola segreta!";
                }
            }
            else
            {
                lblRis_indizio.Text = $"Purtroppo, la lettera {lettere_alfabeto[carattere]} non è presente nella parola segreta. Non arrenderti, continua a provare!";
            }

            lettere_provate[n_prove++] = lettere_alfabeto[carattere];

            lblParola.Text = new string(parola_con_trattini);
        }
        private void indovina()
        {
            lblRis_lettera_inserita.Text = null;

            for (int i = 0; i < parola_segreta.Length; i++)
            {
                if (parola_segreta[i] == lettera_inserita)
                {
                    parola_con_trattini[i] = parola_segreta[i];
                }
            }

            lblParola.Text = new string(parola_con_trattini);

            lblRis_lettera_inserita.Text = "Inserisci una lettera:";

            if (lettera_inserita != '1')
            {
                bool lettera_corretta = false;
                for (int i = 0; i < parola_segreta.Length; i++)
                {
                    if (parola_segreta[i] == lettera_inserita)
                    {
                        parola_con_trattini[i] = lettera_inserita;
                        lettera_corretta = true;
                    }
                }

                lblParola.Text = new string(parola_con_trattini);

                if (lettera_corretta)
                {
                    lblRis_lettera_inserita.Text = "Bravo! Hai indovinato una lettera.";
                    lettere_indovinate++;
                }
                else
                {
                    lblRis_lettera_inserita.Text = "Oops! La lettera che hai scelto non è corretta.";
                    tentativi++;
                }

                if (!new string(parola_con_trattini).Contains("_"))
                {
                    game = true;
                    controllo();
                }
                else if (tentativi >= num_tentativi)
                {

                    game = false;
                    controllo();
                }


                

                if (difficult == "Difficile" && monete >= 5 && tentativi != num_tentativi && tentativi >= 3)
                {
                    {
                        for (int i = 0; i < tastiera.Length; i++)
                        {
                            tastiera[i].Visible = false;
                        }

                        lblLettera_inserito.Visible = false;
                        btnOk.Visible = false;

                        lblintro_extra_chance.Text = $"Sei davvero vicino alla fine e ti restano solo {num_tentativi - tentativi} tentativi! Se stai trovando difficile indovinare la parola, posso darti un piccolo aiuto. Vuoi un indizio: Sorgente (per questa volta costa 5 monete!)?";
                        lblintro_extra_chance.Visible = true;
                        btnExtra_chance_si.Visible = true;
                        btnExtra_chance_no.Visible = true;

                    }
                }
                else if (lettere_indovinate >= 3 && tentativi != num_tentativi)
                {
                    lblParola_completa.Visible = true;
                    btnPC_si.Visible = true;
                    btnPC_no.Visible = true;

                    for (int i = 0; i < tastiera.Length; i++)
                    {
                        tastiera[i].Visible = false;
                    }

                    lblLettera_inserito.Visible = false;
                    btnOk.Visible = false;

                }

                lblTentativi.Text = (num_tentativi - tentativi).ToString();
            }
            else
            {
                lblRis_lettera_inserita.Text = "Per favore inserisci una lettera";
            }
        }

        private string tema_scelta(string tema)
        {
            string filePath = null;

            if (tema == "Animale")
            {
                filePath = "impiccato_animale.txt";
            }
            else if (tema == "Oggetto")
            {
                filePath = "impiccato_oggetto.txt";
            }
            else if (tema == "Paese")
            {
                filePath = "impiccato_paese.txt";
            }
            else if (tema == "Piante")
            {
                filePath = "impiccato_piante.txt";
            }

            if (filePath != null && File.Exists(filePath))
            {
                return filePath;
            }
            else
            {
                return "error";
            }
        }


        private void parole(string[] p, ref string[] pd, ref int nt, ref int monete, string d)
        {
            int a = 0, b = 0, c = 0;

            if (d == "Facile")
            {
                monete = 2;
                nt = 10;
                b = 20;
            }
            else if (d == "Normale")
            {
                monete = 5;
                nt = 8;
                a = 20;
                b = 40;
            }
            else if (d == "Difficile")
            {
                monete = 8;
                nt = 5;
                a = 40;
                b = p.Length;
            }

            for (int i = a; i < b; i++)
            {
                pd[c++] = p[i];
            }
        }

        private string parola_casuale(string[] parole, string[] parole_uscite)
        {
            int posizione = -1;
            bool trovato = false;
            while (trovato == false)
            {
                posizione = random.Next(0, 20);

                for (int i = 0; i < parole_uscite.Length; i++)
                {
                    if (parole_uscite[i] == null || parole[posizione] != parole_uscite[i])
                    {
                        trovato = true;
                    }
                }
            }

            return parole[posizione];
        }


        private string parola_da_indovina(string p)
        {
            string parola = null;
            if (p.Contains("Facile"))
            {
                parola = p.Substring(7);
            }
            else if (p.Contains("Normale"))
            {
                parola = p.Substring(8);
            }
            else
            {
                parola = p.Substring(10);
            }
            return parola.ToLower();
        }

        private void btnPC_si_Click(object sender, EventArgs e)
        {
            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            lblTicchetta_parola_inserito.Visible = true;
            tbxParola_inserita.Visible = true;
            btnParola_inserita.Visible = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            firstpag.Visible = false;
            secondpag.Visible = false;

            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;

            lblTicchetta_monete.Visible = false;
            lblMonete.Visible = false;

            thirdpag.Visible = false;
            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            lblTicchetta_parola_inserito.Visible = false;
            tbxParola_inserita.Visible = false;
            btnParola_inserita.Visible = false;

            fourthpag.Visible = false;
            lastpag.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblErrore.Visible = false;

            if (lblLettera_inserito.Text != "")
            {
                if (!lettere_provate.Contains(lettera))
                {
                    lettera_inserita = lettera;
                    lettere_provate[n_prove++] = lettera_inserita;
                    lblLettere_provate.Text += lettera_inserita + " ";
                    lblRis_lettera_inserita.Text = $"Hai scelto la lettera: {lettera_inserita}";
                    indovina();
                }
                else
                {
                    lblRis_lettera_inserita.Text = "Hai già scelto questa lettera! Prova con una lettera diversa.";
                }
            }
            else
            {
                lblRis_lettera_inserita.Text = "Per favore, scegli una lettera prima di premere OK!";
            }

            lblLettera_inserito.Text = null;
        }

        private void btnPC_no_Click(object sender, EventArgs e)
        {
            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            for (int i = 0; i < tastiera.Length; i++)
            {
                tastiera[i].Visible = true;
            }

            lblLettera_inserito.Visible = true;
            btnOk.Visible = true;

        }

        private void btnParola_inserita_Click(object sender, EventArgs e)
        {
            string parola_inserita = tbxParola_inserita.Text.ToLower();

            if (tbxParola_inserita.Text != null && tbxParola_inserita.Text != "")
            {
                if (parola_inserita == parola_segreta)
                {
                    game = true;
                    controllo();
                }
                else
                {
                    lblRis_lettera_inserita.Text = "Oops! La parola che hai provato non è corretta. Non preoccuparti, puoi continuare a giocare! Prova a indovinare un’altra lettera o riprova a indovinare la parola!";
                    lblTicchetta_parola_inserito.Visible = false;
                    tbxParola_inserita.Visible = false;
                    btnParola_inserita.Visible = false;

                    for (int i = 0; i < tastiera.Length; i++)
                    {
                        tastiera[i].Visible = true;
                    }

                    lblLettera_inserito.Visible = true;
                    btnOk.Visible = true;
                }
            }
            else
            {
                lblErrore_parola_inserita.Visible = true;
            }

            tbxParola_inserita.Text = null;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            firstpag.Visible = true;
            secondpag.Visible = false;

            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;

            lblTicchetta_monete.Visible = false;
            lblMonete.Visible = false;

            thirdpag.Visible = false;

            lblParola_completa.Visible = false;
            btnPC_si.Visible = false;
            btnPC_no.Visible = false;

            lblTicchetta_parola_inserito.Visible = false;
            tbxParola_inserita.Visible = false;
            btnParola_inserita.Visible = false;

            fourthpag.Visible = false;
            lastpag.Visible = false;
        }

        private void btnIndizio_si_Click(object sender, EventArgs e)
        {
            lblIntro_indizi3.Visible = false;
            btnIndizio_si.Visible = false;
            btnIndizio_no.Visible = false;
            lblConquista_indizio.Visible = true;
            ckbIndizio.Visible = true;
            btnIndizio_scelto.Visible = true;

        }

        private void ckbIndizio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ckbIndizio.SelectedIndex;
            int count = ckbIndizio.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    ckbIndizio.SetItemChecked(i, false);
                }
            }
        }

        private void btnIndizio_scelto_Click(object sender, EventArgs e)
        {
            lblErrore.Text = "Per favore scegli un indizio";
            for (int i = 0; i < ckbIndizio.Items.Count; i++)
            {
                if (ckbIndizio.GetItemChecked(i))
                {
                    indizio = ckbIndizio.Items[i].ToString();
                }
            }

            if (indizio != null)
            {
                indizi.Visible = false;

                lblIntro_indizi3.Visible = false;
                btnIndizio_si.Visible = false;
                btnIndizio_no.Visible = false;
                lblConquista_indizio.Visible = false;
                ckbIndizio.Visible = false;
                btnIndizio_scelto.Visible = false;

                secondpag.Visible = true;
                for (int i = 0; i < tastiera.Length; i++)
                {
                    tastiera[i].Visible = true;
                }

                lblLettera_inserito.Visible = true;
                btnOk.Visible = true;

                lblErrore.Visible = false;

                if (indizio.Contains("Dizionario"))
                {
                    if (monete - 3 < 0)
                    {
                        lblErrore.Text = "Ops! Non hai abbastanza monete per acquistare un indizio";
                        lblErrore.Visible = true;
                    }
                    else
                    {
                        ind = 1;
                        monete -= 3;
                    }
                }
                else
                {
                    if (monete - 2 < 0)
                    {
                        lblErrore.Text = "Ops! Non hai abbastanza monete per acquistare un indizio";
                        lblErrore.Visible = true;
                    }
                    else
                    {
                        ind = 2;
                        monete -= 2;
                    }
                }
                lblMonete.Text = monete.ToString();

                gioco();
            }
            else
            {
                lblErrore.Visible = true;
            }
        }

        private void btnIndizio_no_Click(object sender, EventArgs e)
        {
            indizi.Visible = false;

            lblIntro_indizi3.Visible = false;
            btnIndizio_si.Visible = false;
            btnIndizio_no.Visible = false;
            lblConquista_indizio.Visible = false;
            ckbIndizio.Visible = false;
            btnIndizio_scelto.Visible = false;

            secondpag.Visible = true;
            for (int i = 0; i < tastiera.Length; i++)
            {
                tastiera[i].Visible = true;
            }

            lblLettera_inserito.Visible = true;
            btnOk.Visible = true;

            gioco();
        }

        private void btnExtra_chance_si_Click(object sender, EventArgs e)
        {
            if (monete - 5 < 0)
            {
                lblErrore.Text = "Ops! Non hai abbastanza monete per acquistare un indizio";
                lblErrore.Visible = true;
            }
            else
            {
                monete -= 5;
                lblMonete.Text = monete.ToString();

                for (int i = 0; i < tastiera.Length; i++)
                {
                    tastiera[i].Visible = true;
                }

                lblLettera_inserito.Visible = true;
                btnOk.Visible = true;

                lblintro_extra_chance.Visible = false;
                btnExtra_chance_si.Visible = false;
                btnExtra_chance_no.Visible = false;

                sorgente();
            }
        }

        private void btnExtra_chance_no_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tastiera.Length; i++)
            {
                tastiera[i].Visible = true;
            }

            lblLettera_inserito.Visible = true;
            btnOk.Visible = true;

            lblintro_extra_chance.Visible = false;
            btnExtra_chance_si.Visible = false;
            btnExtra_chance_no.Visible = false;
        }

        private void lblTitle_indizi_Click(object sender, EventArgs e)
        {

        }
    }
}
