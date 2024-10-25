// Arquivo referente aos códigos da etapa "Arrays e Listas em C#"


//====================================================================================================================================
//                                                      Array de inteiros
//====================================================================================================================================


// Declaração de um array de números inteiros
int[] arrayDeInteiros =
[
    5,
    13,
    19,
];

// Iterando sobre um array (Estrutura básica)
Console.WriteLine("Iterando sobre array - Estrutura básica");

for (int cont = 0; cont < arrayDeInteiros.Length; cont++)
{
    Console.WriteLine($"{cont + 1}º número: {arrayDeInteiros[cont]}");
}

// Iterando sobre um array (ForEach)
Console.WriteLine("\nIterando sobre array - Estrutura de ForEach");

foreach (int valor in arrayDeInteiros)
{
    Console.WriteLine($"Número: {valor}");
}

// Redimensionando um array
Console.WriteLine("\nIterando sobre um array redimensionado");
Array.Resize(ref arrayDeInteiros, arrayDeInteiros.Length * 2);

for (int cont = 0; cont < arrayDeInteiros.Length; cont++)
{
    Console.WriteLine($"{cont +1}º valor: {arrayDeInteiros[cont]}");
}

// Fazendo cópia de um array
Console.WriteLine("\nIterando sobre a cópia de um array");

int[] copiaDeArrayDeInteiros = new int[arrayDeInteiros.Length * 2];
Array.Copy(arrayDeInteiros, copiaDeArrayDeInteiros, arrayDeInteiros.Length);

for (int cont = 0; cont < arrayDeInteiros.Length; cont++)
{
    Console.WriteLine($"{cont + 1}º valor: {copiaDeArrayDeInteiros[cont]}");
}


//====================================================================================================================================
//                                                          Listas
//====================================================================================================================================


// Iterando sobre uma lista - Antes de remover dados
Console.WriteLine($"\nIterando sobre uma lista - Antes da remoção");

List<string> listaDeString = ["PI", "SP", "RJ", "CE", "MA"];

for (int cont = 0; cont < listaDeString.Count; cont++)
{
    Console.WriteLine($"{cont + 1}º estado: {listaDeString[cont]}");
}

Console.WriteLine($"\nQuantidade de elementos da lista: {listaDeString.Count}");
Console.WriteLine($"Capacidade da lista: {listaDeString.Capacity}");

// Iterando sobre uma lista - Após remover dados
Console.WriteLine($"\nIterando sobre uma lista - Após a remoção");

listaDeString.Remove("RJ");

for (int cont = 0; cont < listaDeString.Count; cont++)
{
    Console.WriteLine($"{cont + 1}º estado: {listaDeString[cont]}");
}

Console.WriteLine($"\nQuantidade de elementos da lista: {listaDeString.Count}");
Console.WriteLine($"Capacidade da lista: {listaDeString.Capacity}");
