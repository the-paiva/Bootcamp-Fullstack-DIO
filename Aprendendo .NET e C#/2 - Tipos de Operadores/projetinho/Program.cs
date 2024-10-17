// Código referente à etapa "Tipos de Operadores" do curso de C#


//======================================================================================================================================
//                                                          Casting
//======================================================================================================================================

// Formas de converter um tipo de dado para int
int numeroAleatorio = Convert.ToInt32("10"); // Aceita valor do tipo null
int respostaUniversal = int.Parse("42"); // Não aceita valor do tipo null

// Forma de converter um tipo de dado para string
string numeroEmString = 2004.ToString();

// Casting implícito
int numeroInt = 12;
double numeroDouble = numeroInt; // O número inteiro é, implicitamente, convertido para double

// Saída de dados
Console.WriteLine(numeroAleatorio);
Console.WriteLine(respostaUniversal);
Console.WriteLine(numeroEmString);
Console.WriteLine(numeroInt);
Console.WriteLine(numeroDouble);


//======================================================================================================================================
//                                                  Operadores Condicionais (If)
//======================================================================================================================================

// Exemplo: Venda do produto de um estoque

// Declaração das variáveis necessárias
int quantidadeEmEstoque = 10;
int quantidadeDaCompra = 4;
bool ehPossivelVender = quantidadeEmEstoque >= quantidadeDaCompra;
string mensagemDeVenda;

// Sintaxe de estrutura condicional
if (quantidadeDaCompra == 0)
{
    mensagemDeVenda = "Venda inválida!";
}
else if (ehPossivelVender)
{
    mensagemDeVenda = "É possível realizar a venda do produto desejado";
}
else
{
    mensagemDeVenda = "Não possuímos a quantidade do produto desejado em nosso estoque";
}

// Saída de dados
Console.WriteLine($"\nQuantidade do produto em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade desejada para compra do produto: {quantidadeDaCompra}");
Console.WriteLine($"{mensagemDeVenda}");


//======================================================================================================================================
//                                                  Input de Dados e Uso do Switch
//======================================================================================================================================

// Input através do Readline
Console.WriteLine("\nDigite uma letra: ");
string? letra = Console.ReadLine();

string tipoDaLetra;

// Estrutura do Switch
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        tipoDaLetra = "VOGAL";
        break;
    default:
        tipoDaLetra = "CONSOANTE";
        break;
}

// Saída de dados
Console.WriteLine($"{letra} é uma {tipoDaLetra}");


//======================================================================================================================================
//                                                          Operador OR (||)
//======================================================================================================================================

// Exemplo: Entrada de uma pessoa em uma boate

bool ehMaiorDeIdade = true;
bool temAutorizacaoDeResponsavel = false;
string mensagemDeAutorizacao;

// Uso do OR em uma condicional
if (ehMaiorDeIdade || temAutorizacaoDeResponsavel)
{
    mensagemDeAutorizacao = "Entrada autorizada";
}
else
{
    mensagemDeAutorizacao = "Entrada não autorizada";
}

Console.WriteLine($"\nMaioridade: {ehMaiorDeIdade}");
Console.WriteLine($"Autorização dos responsáveis: {temAutorizacaoDeResponsavel}");
Console.WriteLine(mensagemDeAutorizacao);


//======================================================================================================================================
//                                                          Operador AND (&&)
//======================================================================================================================================

// Exemplo: Aprovação (ou Reprovação) de um aluno

bool temPresencaMinima = false;
bool temMediaMinima = true;
string mensagemDeResultado;

// Uso do AND em uma condicional
if (temPresencaMinima && temMediaMinima)
{
    mensagemDeResultado = "Aluno APROVADO";
}
else
{
    mensagemDeResultado = "Aluno REPROVADO";
}

Console.WriteLine($"\nPresença mínima: {temPresencaMinima}");
Console.WriteLine($"Média mínima: {temMediaMinima}");
Console.WriteLine(mensagemDeResultado);


//======================================================================================================================================
//                                                         Operador NOT (!)
//======================================================================================================================================

// Exemplo: Pedalada

bool estaChovendo = false;
bool estaTarde = false;
string mensagemDePedalada;

// Uso do NOT em uma condicional
if (!estaChovendo && !estaTarde)
{
    mensagemDePedalada = "Vou sair para pedalar";
}
else
{
    mensagemDePedalada = "Não vou sair para pedalar";
}

Console.WriteLine($"\nEstá chovendo? {estaChovendo}");
Console.WriteLine($"Está tarde? {estaTarde}");
Console.WriteLine(mensagemDePedalada);
