using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibreria.Entidades
{
    public class AvionComercial:Avion
    {
        #region Propiedades
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        #endregion

        #region Constructores
        public AvionComercial() { }
        public AvionComercial(string Piloto, string Copiloto, string Azafata, int Capacidad, string LineaAerea):base(Piloto,Copiloto,Azafata)
        {
            this.Capacidad = Capacidad;
            this.LineaAerea = LineaAerea;
        }
        #endregion

        #region Metodos
        public override string Aterriza() 
        {
            return "El avion de carga aterriza";
        }
        public override string Despega() 
        {
            return "El Avion de carga despega";
        }

        public override string ToString()
        {
            return base.ToString() + $", Capacidad: {Capacidad}, Linea Aerea: {LineaAerea}";
        }
        #endregion

    }
}
