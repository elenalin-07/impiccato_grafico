using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace impiccato_grafic
{
    public partial class Form1 : Form
    {
        private GroupBox firstpag;
        private Label[] secondpag = new Label[12];
        private GroupBox thirdpag;
        private Button[] btn_lettere = new Button[26];
        private GroupBox richiesta_indovina_parola;
        private GroupBox parola_completa;
        private GroupBox lastpag;

        public Form1()
        {
            InitializeComponent();
            inizio();
        }

        char lettera, lettera_ins;

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

            this.Controls.Add(firstpag);

            Label[] lbl_secondpag = { lblParola, lblTicchetta_monete, lblMonete, lblTicchetta_tema, lblTema_scelta, lblTcchetta_difficult, lblDifficult_scelta, lblRis_lettera_inserita, lblTicchetta_lettere, lblLettere_provate, lblTicchetta_Tentativi, lblTentativi };

            for (int i = 0; i < lbl_secondpag.Length; i++)
            {
                secondpag[i] = lbl_secondpag[i];
            }

            Button[] btn_tastiera = { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };

            for (int i = 0; i < btn_tastiera.Length; i++)
            {
                btn_lettere[i] = btn_tastiera[i];
            }

            thirdpag = new GroupBox();
            thirdpag.Dock = DockStyle.Fill;
            thirdpag.Controls.Add(lblDomanda_continua);
            thirdpag.Controls.Add(btnSi);
            thirdpag.Controls.Add(btnNo);

            this.Controls.Add(thirdpag);

            richiesta_indovina_parola = new GroupBox();
            richiesta_indovina_parola.Dock = DockStyle.Fill;

            richiesta_indovina_parola.Controls.Add(lblParola_completa);
            richiesta_indovina_parola.Controls.Add(btnPC_si);
            richiesta_indovina_parola.Controls.Add(btnPC_no);

            this.Controls.Add(richiesta_indovina_parola);

            parola_completa = new GroupBox();
            parola_completa.Dock = DockStyle.Fill;

            parola_completa.Controls.Add(lblTicchetta_parola_inserito);
            parola_completa.Controls.Add(tbxParola_inserita);
            parola_completa.Controls.Add(btnParola_inserita);

            this.Controls.Add(parola_completa);

            lastpag = new GroupBox();
            lastpag.Dock = DockStyle.Fill;

            lastpag.Controls.Add(lbxParole_indovinate);
            lastpag.Controls.Add(lbxParole_non_indovinate);

            this.Controls.Add(lastpag);

            firstpag.Visible = true;

            for (int i = 0; i < secondpag.Length; i++)
            {
                secondpag[i].Visible = false;
            }

            thirdpag.Visible = false;

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                btn_lettere[i].Visible = false;
            }

            lblLettera_inserito.Visible = false;
            btnOk.Visible = false;

            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = false;

            lblDomanda_continua.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;

            lastpag.Visible = false;

            btn_nextpag.Visible = false;
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
        bool btnStart_clicked = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
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
                for (int i = 0; i < secondpag.Length; i++)
                {
                    secondpag[i].Visible = true;
                }
                lblTicchetta_monete.Visible = true;
                lblDomanda_continua.Visible = false;
                btnSi.Visible = false;
                btnNo.Visible = false;

                lastpag.Visible = false;
                btnStart.Visible = false;
                firstpag.Visible = false;

                btn_nextpag.Visible = false;

                for (int i = 0; i < btn_lettere.Length; i++)
                {
                    btn_lettere[i].Visible = true;
                }

                lblLettera_inserito.Visible = true;
                btnOk.Visible = true;

                lblErrore_TemaDiff.Visible = false;

                gioco();
            }
            else
            {
                lblErrore_TemaDiff.Visible = true;
            }
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

        void gioco()
        {
            string[] parole_indovinate = new string[60];
            string[] parole_non_indovinate = new string[60];
            string[] parole_uscite = new string[60];

            string[] parola_scelte = new string[20];
            string parola, parola_segreta, ris;
            int num_tentativi = 0, posizione_indovinate = 0, posizione_non_indovinate = 0;
            int nm = 0, posizione_parole_uscite = 0, monete = 0;

            string filePath = tema_scelta(tema);
            string[] lines = File.ReadAllLines(filePath);

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

            lblDifficult.Text = difficult;
            lblTema_scelta.Text = tema;
            parole(lines, ref parola_scelte, ref num_tentativi, ref nm, difficult);
            parola = parola_casuale(random, parola_scelte, parole_uscite);
            parola_segreta = parola_da_indovina(parola);

            lblTentativi.Text = num_tentativi.ToString();

            parole_uscite[posizione_parole_uscite++] = parola_segreta;

            if (indovina(parola_segreta, num_tentativi, ref monete, lettera_ins) == true)
            {
                monete += nm;
                lblRis_lettera_inserita.Text = "Congratulazioni! Hai indovinato la parola!";
                parole_indovinate[posizione_indovinate++] = parola_segreta;
                lbxParole_indovinate.Items.Add(parola_segreta);
            }
            else
            {
                parole_non_indovinate[posizione_non_indovinate++] = parola_segreta;
                lbxParole_non_indovinate.Items.Add(parola_segreta);
            }

            // btn_nextpag.Visible = true;

            btnSi.Click += (sender, e) =>
            {
                firstpag.Visible = true;

                for (int i = 0; i < secondpag.Length; i++)
                {
                    secondpag[i].Visible = false;
                }

                thirdpag.Visible = false;
                richiesta_indovina_parola.Visible = false;
                parola_completa.Visible = false;
                lastpag.Visible = false;

                lblDomanda_continua.Visible = false;
                btnSi.Visible = false;
                btnNo.Visible = false;
            };
        }

        private bool indovina(string p, int tentativi_max, ref int m, char lettera)
        {
            lblRis_lettera_inserita.Text = "";
            char[] lettere_parola_non_ripete = new char[p.Length];
            char[] parola_con_trattini = new char[p.Length];

            int tentativi = 0, nTentativi_lettere_indovinate = 0, n_prove = 0, n_indovina_parola = 0;
            char[] lettere_provate = new char[26];

            for (int i = 0; i < p.Length; i++)
            {
                if (!lettere_parola_non_ripete.Contains(p[i]))
                {
                    lettere_parola_non_ripete[i] = p[i];
                    n_indovina_parola++;
                }
            }

            if (n_indovina_parola < 5)
            {
                n_indovina_parola -= 3;
            }
            else
            {
                n_indovina_parola = 3;
            }

            for (int i = 0; i < parola_con_trattini.Length; i++)
            {
                parola_con_trattini[i] = '_';
            }



            lblRis_lettera_inserita.Text = "Adesso indovina la parola nascosta una lettera alla volta!";

            lblParola.Text = new string(parola_con_trattini);
            lblLettere_provate.Text = new string(lettere_provate);
            lblTentativi.Text = (tentativi_max - tentativi).ToString();
            lblRis_lettera_inserita.Text = "Inserisci una lettera:";

            if (lettere_provate.Contains(lettera))
            {
                lblRis_lettera_inserita.Text = "Hai già scelto questa lettera! Prova con una lettera diversa.";
            }

            bool lettera_corretta = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == lettera)
                {
                    parola_con_trattini[i] = lettera;
                    lettera_corretta = true;
                }
            }

            if (lettera_corretta)
            {
                nTentativi_lettere_indovinate++;
                lblRis_lettera_inserita.Text = "Bravo! Hai indovinato una lettera.";
            }
            else
            {
                lblRis_lettera_inserita.Text = "Oops! La lettera che hai scelto non è corretta.";
                tentativi++;
            }

            lettere_provate[n_prove++] = lettera;
            bool scelta_indizio = false;

            if (!new string(parola_con_trattini).Contains("_"))
            {
                return true;
            }
            else if (tentativi >= tentativi_max)
            {
                lblRis_lettera_inserita.Text = $"Hai esaurito i tentativi. La parola segreta era: {p}";
                return false;
            }
            else if (nTentativi_lettere_indovinate > n_indovina_parola)
            {
                lblRis_lettera_inserita.Text = new string(parola_con_trattini);
                for (int i = 0; i < btn_lettere.Length; i++)
                {
                    btn_lettere[i].Visible = false;
                }

                lblLettera_inserito.Visible = false;
                btnOk.Visible = false;

                richiesta_indovina_parola.Visible = true;

                btnPC_si.Click += (sender, e) =>
                {
                    if (indovina_parola(p))
                    {
                        return;
                    }
                };
            }

            return false;
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
                pd[c] = p[i];
                c++;
            }
        }

        private string parola_casuale(Random random, string[] parole, string[] parole_uscite)
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
            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = true;
        }

        private bool indovina_parola(string p)
        {
            string parola_provata = tbxParola_inserita.Text;
            firstpag.Visible = false;

            for (int i = 0; i < secondpag.Length; i++)
            {
                secondpag[i].Visible = true;
            }

            thirdpag.Visible = false;
            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = false;

            lblDomanda_continua.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;

            lastpag.Visible = false;

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                btn_lettere[i].Visible = true;
            }

            lblLettera_inserito.Visible = true;
            btnOk.Visible = true;

            if (parola_provata == p)
            {
                return true;
            }
            else
            {
                lblRis_lettera_inserita.Text = "Oops! La parola che hai provato non è corretta. Non preoccuparti, puoi continuare a giocare! Prova a indovinare un’altra lettera o riprova a indovinare la parola!";
                return false;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            firstpag.Visible = false;

            for (int i = 0; i < secondpag.Length; i++)
            {
                secondpag[i].Visible = false;
            }

            thirdpag.Visible = false;
            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = false;

            lblDomanda_continua.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;

            lastpag.Visible = true;

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                btn_lettere[i].Visible = false;
            }

            lblLettera_inserito.Visible = false;
            btnOk.Visible = false;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            firstpag.Visible = true;

            for (int i = 0; i < secondpag.Length; i++)
            {
                secondpag[i].Visible = false;
            }

            thirdpag.Visible = false;
            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = false;

            lblDomanda_continua.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;

            lastpag.Visible = false;

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                btn_lettere[i].Visible = false;
            }

            lblLettera_inserito.Visible = false;
            btnOk.Visible = false;
        }

        private void btn_nextpag_Click(object sender, EventArgs e)
        {
            firstpag.Visible = false;

            for (int i = 0; i < secondpag.Length; i++)
            {
                secondpag[i].Visible = false;
            }

            thirdpag.Visible = false;

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                btn_lettere[i].Visible = false;
            }

            lblLettera_inserito.Visible = false;
            btnOk.Visible = false;

            richiesta_indovina_parola.Visible = false;
            parola_completa.Visible = false;

            lblDomanda_continua.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;

            lastpag.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lettera_ins = lettera;
            lblLettera_inserito.Text = "";
        }
    }
}
