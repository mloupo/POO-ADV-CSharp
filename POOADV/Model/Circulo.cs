using POOADV.Interfaces;
using System;

namespace POOADV.Modelo
{
    internal class Circulo : FiguraGeometrica, IFiguraGeometrica
    {
        public double radio;

        public Circulo()
        {
        }

        public Circulo(double radio)
        {
            this.radio = radio;
            this.perimetro = Perimetro();
            this.superficie = Superficie();
        }

        public double Perimetro()
        {
            double perim;
            perim = (2 * Math.PI * radio);
            return perim;
        }

        public double Superficie()
        {
            double area;
            area = Math.PI * Math.Pow(radio, 2);
            return area;

        }
        public override string ToString()
        {
            return $"Circulo de radio: {radio}. Perim: {perimetro}, Sup: {superficie}";
        }
    }
}
