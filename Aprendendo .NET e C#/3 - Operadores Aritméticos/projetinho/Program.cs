// Código referente à etapa "Operadores Aritméticos" do curso de C#

using projetinho.Models;


//=====================================================================================================================================
//                                                      Classe Calculadora
//=====================================================================================================================================

Calculadora calculadoraSimples = new();

calculadoraSimples.Somar(10, 43);
calculadoraSimples.Subtrair(30, 16);
calculadoraSimples.Multiplicar(9, 8);
calculadoraSimples.Dividir(120, 40);
calculadoraSimples.CalcularPotencia(5, 2);
calculadoraSimples.CalcularRaizQuadrada(25);
calculadoraSimples.CalcularSeno(30);
calculadoraSimples.CalcularCosseno(30);
calculadoraSimples.CalcularTangente(30);


//=====================================================================================================================================
//                                                     Incremento e Decremento
//=====================================================================================================================================

int x = 10;
int y = 15;

Console.WriteLine($"\nX: {x}");
Console.WriteLine($"Y: {y}");

x++;
y--;

Console.WriteLine($"\nX incrementado: {x}");
Console.WriteLine($"Y decrementado: {y}");
