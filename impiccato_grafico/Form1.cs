namespace impiccato_grafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CheckBox[] tema = { ckbAnimal, ckbObject, ckbPaese, ckbPiante };
            CheckBox[] difficolta = { ckbEasy, ckbNormal, ckbDifficult };

            int tema_scelta = 0;
            int difficolta_scelta = 0;
            bool checkTema = false;
            bool checkDifficult = false;

            while(!checkTema)
            {
                tema_scelta = scelta(tema);

                if (tema_scelta != 0)
                {
                    checkTema = true;
                }
                else
                {
                    lblError_scelta.Visible = true;
                }
            }

            while (!checkDifficult)
            {
                difficolta_scelta = scelta(difficolta);

                if (difficolta_scelta != 0)
                {
                    checkDifficult = true;
                }
                else
                {
                    lblError_scelta.Visible = true;
                }
            }
        }

        int scelta(CheckBox[] checkBoxes)
        {
            int scelta = 0;
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    scelta++;
                }
            }

            if (scelta > 1)
            {
                lblError_scelta.Visible = true;
            }
            else
            {
                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
    }
}
