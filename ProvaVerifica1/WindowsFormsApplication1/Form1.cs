using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        private string[] nomi = { "Tizio", "Caio", "Sempronio" }; //Array di nomi 
        private string[] cognomi = { "Rossi", "Bianchi", "Verdi" };
        private string[] scuole = { "Canossa", "Pertini", "Aosta" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Padre papà = new Padre("Roberto", "Russo", 53);            // questa serie di istruzioni aggiunge un padre e un figlio alla listbox e il loro describe alle testbox.                                                                 //
            listBox1.Items.Add(papà.ToString());
            papà.describe_t(textBox1);                                //aggiunge describe in textbox sotto
            Figlio Tommaso = new Figlio("Tommaso", "Russo", 17, "Aosta");
            listBox1.Items.Add(Tommaso.ToString());
            Tommaso.describe_t(textBox2);                             //aggiunge describe in textbox sotto

            /* for (int i = 0; i < 5; i++)          --> con queste istruzioni fa più persone random e le aggiunge a listbox
               generateRandomFiglio();
               generateRandomPadre();

               listBox1.Items.Add(generateRandomFiglio().ToString());
               listBox1.Items.Add(generateRandomPadre().ToString());
            // List<Padre> persone = new List<Padre>();                  --> se serve così si fa una lista 
            // persone.Add(new Padre("Roberto", "Russo", 53));
         }
          Random rnd = new Random();
          private Padre generateRandomPadre()
          {
              return new Padre(nomi[rnd.Next(0, 3)], cognomi[rnd.Next(0, 3)], rnd.Next(18, 50));
          }

          Random rnd1 = new Random(); // rnd1 perchè non può avere stesso nome di quello sopra
          private Figlio generateRandomFiglio()
          {
              return new Figlio(nomi[rnd.Next(0, 3)], cognomi[rnd.Next(0, 3)], rnd.Next(18, 50), scuole[rnd.Next(0, 3)]);
          }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)   // nb non togliere sta roba se no crasha
        {

        }
    }
}
