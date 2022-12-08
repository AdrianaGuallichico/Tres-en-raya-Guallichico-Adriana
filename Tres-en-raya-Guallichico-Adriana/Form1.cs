using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Tres_en_raya_Guallichico_Adriana
{
    public partial class Form1 : Form
    {
        private string jugador1 = "JUAN";
        private string jugador2 = "JOSE";
        private bool turno = true;
        private int Ganar = 0;
        private int Movimientos = 0;

        private int[] jugadas = { 0, 0, 0, 0, 0, 0, 0, 0, 0};
        
        public Form1()
        {
            InitializeComponent();
        }
        private void quienjuega(bool turno)
        {
            if(turno)
            this.lbljugador.Text = $"TURNO DEL JUGADOR {jugador1}";
            else
            this.lbljugador.Text = $"TURNO DEL JUGADOR {jugador2}";
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void pintarPicture(PictureBox picture)
        {
            if (turno)
                picture.Image = Tres_en_raya_Guallichico_Adriana.Properties.Resources.circu;
            else
                picture.Image = Tres_en_raya_Guallichico_Adriana.Properties.Resources.estre;
           
            int tag = Int32.Parse(picture.Tag.ToString());
            Console.WriteLine("el valor de tag{0}",tag);
            jugadas[tag] = turno ? 1 : 2;
            Console.WriteLine("el valos del vector de jugadas");
            foreach(int valor in jugadas)
            {
                Console.WriteLine("{0}", valor);
            }
        }
        private void desactivarJuego()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
        }
        private void ganar()
        {
           //horizontal
            if (jugadas[0] == 1 && jugadas[1] == 1 && jugadas[2] == 1)
            {
                Ganar = 1;
            }
            else if (jugadas[3] == 1 && jugadas[4] == 1 && jugadas[5] == 1)
            {
                Ganar = 1;
            }
            else if (jugadas[6] == 1 && jugadas[7] == 1 && jugadas[8] == 1)
            {
                Ganar = 1;
            }
            //Vertical
            else if (jugadas[0] == 1 && jugadas[3] == 1 && jugadas[6] == 1)
            {
                Ganar = 1;
            }
            else if (jugadas[1] == 1 && jugadas[4] == 1 && jugadas[7] == 1)
            {
                Ganar = 1;
            }
            else if (jugadas[2] == 1 && jugadas[5] == 1 && jugadas[8] == 1)
            {
                Ganar = 1;
            }
            //Diagonal
            else if (jugadas[0] == 1 && jugadas[4] == 1 && jugadas[8] == 1)
            {
                Ganar = 1;
            }
            else if (jugadas[6] == 1 && jugadas[4] == 1 && jugadas[2] == 1)
            {
                Ganar = 1;
            }
            //jugador 2
            //horizontal
            else if (jugadas[0] == 2 && jugadas[1] == 2 && jugadas[2] == 2)
            {
                Ganar = 2;
            }
            else if (jugadas[3] == 2 && jugadas[4] == 2 && jugadas[5] == 2)
            {
                Ganar = 2;
            }
            else if (jugadas[6] == 2 && jugadas[7] == 2 && jugadas[8] == 2)
            {
                Ganar = 2;
            }
            //vertical
            else if (jugadas[0] == 2 && jugadas[3] == 2 && jugadas[6] == 2)
            {
                Ganar = 2;
            }
            else if (jugadas[1] == 2 && jugadas[4] == 2 && jugadas[7] == 2)
            {
                Ganar = 2;
            }
            else if (jugadas[2] == 2 && jugadas[5] == 2 && jugadas[8] == 2)
            {
                Ganar = 2;
            }
            //Diagonal
            else if (jugadas[0] == 2 && jugadas[4] == 2 && jugadas[8] == 2)
            {
                Ganar = 2;
            }
            else if (jugadas[6] == 2 && jugadas[4] == 2 && jugadas[2] == 2)
            {
                Ganar = 2;
            }
            if (Ganar == 1)
            {
                MessageBox.Show($"El jugador {jugador1} ha ganado.");
                desactivarJuego();
                btnRepetir.Enabled = true;
                return;
            }
            else if (Ganar == 2)
            {
                MessageBox.Show($"El jugador {jugador2} ha ganado.");
                desactivarJuego();
                btnRepetir.Enabled = true;
                return;
            }
            if (Movimientos == 9)
            {
                MessageBox.Show($"Empate.");
                desactivarJuego();
                btnRepetir.Enabled = true;
                return;
            }
        }

        private void desactivarPicture(PictureBox picture)
        {
            picture.Enabled = false;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            pintarPicture(this.pictureBox1);
            desactivarPicture(pictureBox1);
            turno = !turno;
            quienjuega(turno);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quienjuega(turno);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox7);
            desactivarPicture(pictureBox7);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox2);
            desactivarPicture(pictureBox2);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox3);
            desactivarPicture(pictureBox3);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox4);
            desactivarPicture(pictureBox4);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox5);
            desactivarPicture(pictureBox5);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox6);
            desactivarPicture(pictureBox6);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox8);
            desactivarPicture(pictureBox8);
            turno = !turno;
            quienjuega(turno);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pintarPicture(pictureBox9);
            desactivarPicture(pictureBox9);
            turno = !turno;
            quienjuega(turno);
        }
       

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            Form1 Juego = new Form1();
            Juego.Show();
            this.Dispose(false);
        }

        private void btlSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
