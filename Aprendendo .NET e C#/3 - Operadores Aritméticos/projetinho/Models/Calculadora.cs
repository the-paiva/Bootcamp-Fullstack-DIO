using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetinho.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void CalcularPotencia(int numero, int expoente)
        {
            double potencia = Math.Pow(numero, expoente);
            Console.WriteLine($"{numero}^{expoente} = {potencia}");
        }

        public void CalcularRaizQuadrada(int x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {raiz}");
        }

        public void CalcularSeno(double angulo)
        {
            double radiana = angulo * Math.PI / 180;
            double seno = Math.Round(Math.Sin(radiana), 4);
            Console.WriteLine($"Seno de {angulo}: {seno}");
        }

        public void CalcularCosseno(double angulo)
        {
            double radiana = angulo * Math.PI / 180;
            double cosseno = Math.Round(Math.Cos(radiana), 4);
            Console.WriteLine($"Cosseno de {angulo}: {cosseno}");
        }

        public void CalcularTangente(double angulo)
        {
            double radiana = angulo * Math.PI / 180;
            double tangente = Math.Round(Math.Tan(radiana), 4);
            Console.WriteLine($"Tangente de {angulo}: {tangente}");
        }
    }
}
