namespace Ejercicios09Punto03.BL
{
    public class Rectangulo
    {
        public int LadoMayor { get; set; }
        public int LadoMenor { get; set; }

        public double GetPerimetro()
        {
            return 2 * LadoMayor + 2 * LadoMenor;
        }

        public double GetSuperficie()
        {
            return LadoMayor* LadoMenor;
        }

        public override string ToString()
        {
            return $"Rectángulo de lado mayor de {LadoMayor}" +
                   $" unidades y de lado menor de {LadoMenor} unidades";
        }
    }
}
