using POOADV.Interfaces;


namespace POOADV.Modelo
{
    internal class Cuadrado : FiguraGeometrica, IFiguraGeometrica
    {
        public double lado;
        public Cuadrado()
        {
        }

        public Cuadrado(double lado)
        {
            this.lado = lado;
            this.perimetro = Perimetro();
            this.superficie = Superficie();

        }

        public double Perimetro()
        {
            return lado * 4;
        }

        public double Superficie()
        {
            return lado * lado;

        }

        public override string ToString()
        {
            return $"Cuadrado de lado: {lado}. Perim: {perimetro}, Sup: {superficie}";
        }
    }
}
