using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Figlio : Padre
    {
        public string scuola { get; set; }

        public Figlio(string nome, string cognome, int anni, string scuola) : base(nome, cognome, anni) // codtruttore figlio richiama padre
        {
            this.scuola = scuola;
        }

        public override string Describe()
        {
            return base.Describe() + "scuola: ";
        }
    }
}
