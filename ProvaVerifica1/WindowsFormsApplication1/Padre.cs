using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // importato per potere richiamare elementi form 1


namespace WindowsFormsApplication1
{
    class Padre
    {
            private string _nome;
            public string nome { get { return _nome; } } // proprietà in sola lettura 

            private string _cognome;
            public string cognome { get { return _cognome; } }

            private int _anni;
            public int anni          // proprietà in  lettura e scrittura

            {
                set
                { if (value <= 0) value = 1; _anni = value; }

                get { return _anni; }
            }

            public string codiceFiscale
            {
                get { return nome + cognome + anni.ToString(); } // qui lo fa facendo una stringa con altri elementi (se faccio proprietà vuota lo inserisce utente)
            }


            public override string ToString()  //no input, output string
            {
                return nome + " " + cognome + " " + anni;
            }

            public virtual string Describe() //no input, output string // è virtual per modificarla nel figlio
            {
                string output = nome + " " + cognome + " " + anni + " " + codiceFiscale;
                return output;
            }

            public void describe_t(TextBox t)   // funzione per describe in testbox 
            {                                   // void lo metto se funzione non deve ridare un valore 
                t.Text = Describe();
            }

            public Padre(string nome, string cognome, int anni)  //costruttore
            {
                _nome = nome;              
                _cognome = cognome;  
                _anni = anni;                  
            }
        }
    }