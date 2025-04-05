using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace impiccato_grafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gioco();
        }

        char lettera;

        private GroupBox firstpag;
        private GroupBox secondpag;

        Random random = new Random();
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
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lettera = 'a';
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            lettera = 'b';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lettera = 'c';
        }

        private void D_Click(object sender, EventArgs e)
        {
            lettera = 'd';
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            lettera = 'e';
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            lettera = 'f';
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            lettera = 'g';
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            lettera = 'h';
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            lettera = 'i';
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            lettera = 'j';
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            lettera = 'k';
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            lettera = 'l';
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            lettera = 'm';
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            lettera = 'n';
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            lettera = 'o';
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            lettera = 'p';
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            lettera = 'q';
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lettera = 'r';
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            lettera = 's';
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            lettera = 't';
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            lettera = 'u';
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            lettera = 'v';
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            lettera = 'w';
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            lettera = 'x';
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            lettera = 'y';
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            lettera = 'z';
        }

        void gioco()
        {
            GroupBox firstpag = new GroupBox();
            firstpag.Dock = DockStyle.Fill;
            firstpag.Controls.Add(lblIntro);
            firstpag.Controls.Add(lblTema);
            firstpag.Controls.Add(lblDifficult);
            firstpag.Controls.Add(ckbDifficult);
            firstpag.Controls.Add(ckbTema);
            firstpag.Controls.Add(btnStart);

            this.Controls.Add(firstpag);

            GroupBox secondpag = new GroupBox();
            secondpag.Dock = DockStyle.Fill;
            secondpag.Controls.Add(lblParola);
            secondpag.Controls.Add(lblTicchetta_monete);
            secondpag.Controls.Add(lblMonete);
            secondpag.Controls.Add(lblTicchetta_tema);
            secondpag.Controls.Add(lblTema_scelta);
            secondpag.Controls.Add(lblTcchetta_difficult);
            secondpag.Controls.Add(lblDifficult_scelta);
            secondpag.Controls.Add(lblRis_lettera_inserita);

            Button[] btn_lettere = { btnA, btnB, btnC, btnD, btnE, btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP, btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ };

            for (int i = 0; i < btn_lettere.Length; i++)
            {
                secondpag.Controls.Add(btn_lettere[i]);
            }

            secondpag.Controls.Add(btnOk);
            secondpag.Controls.Add(lblLettera_inserito);

            this.Controls.Add(secondpag);

            firstpag.Visible = true;
            secondpag.Visible = false;

            lblErrore_TemaDiff.Visible = false;
            btnStart.Click += (sender, e) =>
            {
                if (tema != null && difficult != null)
                {
                    firstpag.Visible = false;
                    secondpag.Visible = true;
                    lblErrore_TemaDiff.Visible = false;
                }
                else
                {
                    lblErrore_TemaDiff.Visible = true;
                }
            };

            string[] parola_scelte = new string[20];
            string[] parole_uscite = new string[20];
            int num_tentativi = 0;
            int nm = 0;
            string parola, parola_segreta;

            string filePath = tema_scelta(tema);
            string[] lines = File.ReadAllLines(filePath);
            parole(lines, ref parola_scelte, ref num_tentativi, ref nm);
            parola = parola_casuale(parola_scelte, parole_uscite);
            parola_segreta = parola_da_indovina(parola);

        }

        private void parole(string[] lines, ref string[] parola_scelte, ref int num_tentativi, ref int nm)
        {
            throw new NotImplementedException();
        }

        string tema_scelta(string tema)
        {
            if (tema == "animale" || tema == "1")
            {
                return "impiccato_animale.txt";
            }
            else if (tema == "oggetto" || tema == "2")
            {
                return "impiccato_oggetto.txt";
            }
            else if (tema == "paese" || tema == "3")
            {
                return "impiccato_paese.txt";
            }
            else if (tema == "piante" || tema == "4")
            {
                return "impiccato_piante.txt";
            }
            return "error";
        }

        void parole(string[] p, ref string[] pd, ref int nt, ref int monete, string d)
        {
            int a = 0, b = 0, c = 0;

            if (d != null)
            {
                if (d == "facile" || d == "1")
                {
                    monete = 2;
                    nt = 10;
                    b = 20;
                }
                else if (d == "normale" || d == "2")
                {
                    monete = 5;
                    nt = 8;
                    a = 20;
                    b = 40;
                }
                else if (d == "difficile" || d == "3")
                {
                    monete = 8;
                    nt = 5;
                    a = 40;
                    b = p.Length;
                }
                if (b > p.Length)
                {
                    b = p.Length;
                }
                for (int i = a; i < b; i++)
                {
                    pd[c++] = p[i];
                }
            }
        }

        string parola_casuale(string[] parole, string[] parole_uscite)
        {
            int posizione = random.Next(0, 20);
            do
            {
                posizione = random.Next(0, 20);
            }
            while (parole_uscite.Contains(parole[posizione]));
            return parole[posizione];
        }

        string parola_da_indovina(string p)
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
    }
}
