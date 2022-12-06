using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tres_en_raya_Guallichico_Adriana
{
    public partial class Form1 : Form
    {
        private string jugador1 = "JUAN";
        private string jugador2 = "JOSE";
        private bool turno = true;

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

        }
    }
}
