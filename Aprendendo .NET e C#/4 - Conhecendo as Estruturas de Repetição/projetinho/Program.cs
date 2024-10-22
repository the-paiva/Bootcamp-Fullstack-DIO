// Código referente à etapa "Conhecendo Estruturas de Repetição" do curso de C#

//===========================================================================================================================================
//                                                          Uso do FOR
//===========================================================================================================================================

// Exemplo: Tabuada de multiplacação do número 3

int numero = 3;

Console.WriteLine("Tabuada de multiplicação do 3 (Usando FOR)");

// Estrutura básica do FOR
for (int contFor = 0; contFor <= 10; contFor++)
{
    Console.WriteLine($"{numero} * {contFor} = {numero * contFor}");
}


//===========================================================================================================================================
//                                                          Uso do WHILE
//===========================================================================================================================================

// Exemplo: Tabuada de multiplicação do número 5

numero = 5;
int contWhile = 0;

Console.WriteLine("\nTabuada de multiplicação do 5 (Usando WHILE)");

// Estrutura básica do WHILE
while (contWhile <= 10)
{
    Console.WriteLine($"{numero} * {contWhile} = {numero * contWhile}");
    contWhile++;
}

// Exemplo: Tabuada de multiplicação do número 7

numero = 7;
contWhile = 0;

Console.WriteLine("\nTabuada de multiplicação do 7 (Usando WHILE e BREAK)");

// Estrutura do WHILE usando BREAK
while (contWhile <= 10)
{
    Console.WriteLine($"{numero} * {contWhile} = {numero * contWhile}");

    if (contWhile == 5)
    {
        break;
    }

    contWhile++;
}

//===========================================================================================================================================
//                                                          Uso de DO WHILE
//===========================================================================================================================================

// Exemplo: Soma iterativa

int novoNumero, soma = 0, contDo = 1;

Console.WriteLine("\nSoma iterativa (Usando Do While) - Digite 0 para encerrar");

do
{
    Console.Write($"Digite o {contDo}º número: ");
    novoNumero = Convert.ToInt32(Console.ReadLine());

    if (novoNumero == 0)
    {
        break;
    }

    soma += novoNumero;
    contDo++;
} 
while (true);

Console.WriteLine($"\nSoma dos números digitados: {soma}");
