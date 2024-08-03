using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej1ConcesionariaMotos;

namespace Ej1ConcesionariaMotos.Models
{
    
    class Moto
    {
        
        public string Marca { get; private set; }        
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        #region Metodos
        public Moto(string marca, int modelo, double fabric)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = fabric;
        }


        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            return ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return ValorFabricacion * (Math.Pow(1 - 0.1, añoACalcular - Modelo));
        }

        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion,7:f2}";
        }
        #endregion
    }
}
