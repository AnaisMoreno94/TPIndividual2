using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibreria.Entidades
{
    public class AvionCarga:Avion
    {
        #region Propiedades
        public float Peso { get; set; }
        public string TipoMercaderia { get; set; }
        #endregion

        #region Constructores
        public AvionCarga() { }
        public AvionCarga(string Piloto, string Copiloto, string Azafata, float Peso, string TipoMercaderia) : base(Piloto, Copiloto, Azafata)
        {
            this.Peso = Peso;
            this.TipoMercaderia = TipoMercaderia;
        }
        #endregion

        #region Metodos
        public override string Aterriza()
        {
            return "El avion  de Carga aterriza";
        }
        public override string Despega()
        {
            return "El Avion de Carga despega";
        }
        public override string ToString()
        {
            return base.ToString() + $", Peso: {Peso}Kg , Tipo de Mercaderia: {TipoMercaderia}";
        }
        #endregion
    }
}
