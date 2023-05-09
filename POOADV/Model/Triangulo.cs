using POOADV.Interfaces;
using System;

namespace POOADV.Modelo
{
    internal class Triangulo : FiguraGeometrica, IFiguraGeometrica
    {
        public double Lado1;
        public double Lado2;
        public double Lado3;



        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
            perimetro = Perimetro();
            superficie = Superficie();

        }

        public Triangulo()
        {
        }
        public double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public double Superficie()
        {
            /* 
             * Cuando el valor del semiperimetro es igual que el de uno de los lados,
             * la formula de heron no puede calculaar el area porque se hace 0 el radicando
             */
            double superficie;
            double semiperim, radic;
            semiperim = this.perimetro / 2;
            radic = semiperim * (semiperim - Lado1) * (semiperim - Lado2) * (semiperim - Lado3);
            superficie = Math.Sqrt(radic);
            Console.WriteLine(superficie);
            return superficie;
        }
        public override string ToString()
        {
            return $"Triangulo de lados: {Lado1}, {Lado2}, {Lado3}. Perim: {perimetro}, Sup: {superficie}";
        }



    }
}
