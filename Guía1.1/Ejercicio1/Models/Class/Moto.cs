using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Class
{
    internal class Moto
    {
        //string Marca;
        //int Modelo;
        //double ValorFabricacion;

        public string Marca{ get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion) 
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double DepreciacionLineal(int añoActual, int vidaUtil)
        {
            int añosUso = añoActual - Modelo;
            double valorActual = ValorFabricacion - (ValorFabricacion * añosUso / vidaUtil);
            return valorActual;
        }

        public double DepreciacionAnual(int añoActual, double tasaDepreciacion)
        {
            int añosUso = añoActual - Modelo;
            double valorActual = ValorFabricacion * Math.Pow((1 - tasaDepreciacion), añosUso);
            return valorActual;
        }

        public string VerDescripcion()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Valor de Fabricación: ${ValorFabricacion,10:f2}";
        }

    }
}
