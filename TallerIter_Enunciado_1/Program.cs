using System;

namespace TallerIter_Enunciado_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaLarry, nota4Larry, notaNecLar, porcentajeLar, notaMartin, nota5Martin, notaNecMar, porcentajeMar, calculoPorc;
            double estatura, peso, indice, calculoImc;
            double notaMin = 3;

            Console.WriteLine("Ejercicio 01");

            int x = 1;
            double sumNotasLar = 0;
            while (x <= 3)
            {
                Console.WriteLine("Ingrese Nota {0} de Larry", x);
                notaLarry = double.Parse(Console.ReadLine());
                porcentajeLar = notaLarry * 0.25;
                sumNotasLar += porcentajeLar;
                x += 1;
            }

            double sumNotasMar = 0;
            while (x <= 3)
            {
                Console.WriteLine("Ingrese Nota {0} de Martin", x);
                notaMartin = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nota {0} de Martin", x);
                notaMartin = double.Parse(Console.ReadLine());
                porcentajeMar = double.Parse(Console.ReadLine());
                porcentajeMar /= 100;
                calculoPorc = notaMartin * porcentajeMar;
                sumNotasMar += calculoPorc;
                x += 1;
            }

            nota5Martin = sumNotasMar;
            nota4Larry = sumNotasLar;

            notaNecLar = (notaMin - nota4Larry) / 0.25;
            notaNecMar = (notaMin - nota5Martin) / 0.38;

            if (notaNecLar <= 5)
            {
            Console.WriteLine("Larry necesita: " + notaNecLar);
            }
            else if (notaNecLar > 5)
            {
                Console.WriteLine("No importa el resultado, Larry ya ha perdido la meteria");
            }
            else if (notaNecLar < 0)
            {
                Console.WriteLine("ingrese valores entre 0 y 5");
            }



        }
    }
}
