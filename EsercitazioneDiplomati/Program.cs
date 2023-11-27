using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EsercitazioneDiplomati
{
    class Diplomati
    {
        protected string _Nome { get; set; }
        protected string _Cognome { get; set; }
        protected int _Voto { get; set; }

        public Diplomati(string Nome, string Cognome, int Voto) 
        { 
            _Nome = Nome;
            _Cognome = Cognome;
            _Voto = Voto;
        }

        public void Registrazione()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
