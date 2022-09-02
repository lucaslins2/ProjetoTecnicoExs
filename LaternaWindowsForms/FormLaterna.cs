using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaternaWindowsForms
{
    public partial class FormLaterna : Form
    {
        Laterna laterna = new Laterna(new Bateria());
        public FormLaterna()
        {
            InitializeComponent();
            textProgressBateria.Text = " Porcetagem da Bateria: " + laterna.bateria.porcetagem;
        }

        private void BtnLigarDesligar_Click(object sender, EventArgs e)
        {
            laterna.status = laterna.status == 0 ? 1 : 0;
            BtnLigarDesligar.Text = laterna.status == 0 ? "Ligar" : "Desligar";
            if (laterna.bateria.porcetagem > 0)
                TrocarImagem(laterna.status);

        }

        private void BtnTrocarBateria_Click(object sender, EventArgs e)
        {
            int estadoLaterna = laterna.status;
            laterna = new Laterna(new Bateria());
            laterna.status = estadoLaterna;
            BtnLigarDesligar.Text = laterna.status == 0 ? "Ligar" : "Desligar";
            textProgressBateria.Text = " Porcetagem da Bateria: " + laterna.bateria.porcetagem;
            TrocarImagem(0);
        }

        public void TrocarImagem(int foto)
        {
            string path = "";
#if DEBUG
            if (foto == 1)
            {
                path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                ImgLaterna.Image = Image.FromFile(path + @"../../resources/lampadacessa.png");
            }
            else
            {
                path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                ImgLaterna.Image = Image.FromFile(path + @"../../resources/lampadapagada.png");
            }
#endif
            if (path == "")
            {
                if (foto == 1)
                {

                    path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                    ImgLaterna.Image = Image.FromFile(path + "/resources/lampadacessa.png");
                }
                else
                {
                    path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                    ImgLaterna.Image = Image.FromFile(path + @"/resources/lampadapagada.png");

                }

            }


        }

        private void timerLaterna_Tick(object sender, EventArgs e)
        {

            if (laterna.status == 1)
            {
                if (laterna.bateria.porcetagem == 0)
                {
                    TrocarImagem(0);
                }
                else
                {
                    TrocarImagem(1);
                    if (laterna.bateria.porcetagem > 0)
                        laterna.bateria.porcetagem--;
                    textProgressBateria.Text = " Porcetagem da Bateria: " + laterna.bateria.porcetagem;
                }
            }
        }
    }
}
