using System.Drawing;

namespace Elipses.Entidades
{
    public class Elipse
    {
        // Atributos de la clase
        public int SemiejeMayor { get; set; }
        public int SemiejeMenor { get; set; }
        public Borde Borde { get; set; }
        public ColorElipse Color { get; set; }

        
        public Elipse(int semiejeMayor, int semiejeMenor, Borde borde, ColorElipse color)
        {
            SemiejeMayor = semiejeMayor;
            SemiejeMenor = semiejeMenor;
            Borde = borde;
            Color = color;
        }

        public Elipse()
        {
        }

        public double CalcularArea()
        {
            return Math.PI * SemiejeMayor * SemiejeMenor;
        }

        
        public double CalcularPerimetro()
        {
            return Math.PI * (3 * (SemiejeMayor + SemiejeMenor) - Math.Sqrt((3 * SemiejeMayor + SemiejeMenor) * (SemiejeMayor + 3 * SemiejeMenor)));
        }

        
        public override bool Equals(object obj)
        {
            if (obj is Elipse other)
            {
                return SemiejeMayor == other.SemiejeMayor && SemiejeMenor == other.SemiejeMenor;
            }
            return false;
        }

        
        public override int GetHashCode()
        {
            return HashCode.Combine(SemiejeMayor, SemiejeMenor);
        }
    }
}
