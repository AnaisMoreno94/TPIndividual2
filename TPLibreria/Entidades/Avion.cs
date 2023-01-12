using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibreria.Entidades
{
    public abstract class Avion
    {
        #region Propiedades
        public string Piloto { get; set; }
        public string Copiloto { get; set;}
        public string Azafata { get; set;}
        #endregion

        #region Constructores
        public Avion() { }
        public Avion(string Piloto, string Copiloto, string Azafata) 
        {
            this.Piloto = Piloto;
            this.Copiloto = Copiloto;
            this.Azafata = Azafata;
        }
        #endregion

        #region Metodos
        //Si bien los aviones pueden aterrizar y despegar, todos, dependiendo de su estructura, tamaño o modelo tienen metodos distintos para aterrizar y despegar. Por lo cual el polimorfismo deberia ser obligatorio para estos metodos de la clase avion.
        public abstract string Aterriza();
        public abstract string Despega();

        public override string ToString()
        {
            return $"Piloto: {Piloto}, Copiloto: {Copiloto}, Azafata: {Azafata}";
        }

        #endregion

    }
}
