// Código referente à etapa "Sintaxe e Tipos de Dados" do curso de C#

// Importa a classe Pessoa através do seu namespace
using projetinho.models;


//===========================================================================================================================================
//                                                      Manipulação de classe
//===========================================================================================================================================

// Cria uma nova instância da classe Pessoa (pessoaFisica)
Pessoa pessoaFisica = new();

// Define os atributos de pessoaFisica
pessoaFisica.Nome = "Todo Mundo";
pessoaFisica.Idade = 19;

// Chama um método de pessoaFisica
pessoaFisica.Apresentar();

// Altera os valores dos atributos da nova instância
pessoaFisica
.Nome = "Ninguém";
pessoaFisica
.Idade = 24;

// Chama novamente um método de pessoaFisica, dessa vez usando os novos valores de seus atributos
pessoaFisica.Apresentar();


//===========================================================================================================================================
//                                             Declaração de variáveis e saída de dados
//===========================================================================================================================================

// Declaração de variáveis
string apresentacao = "Ablueblueblue";
double altura = 1.80; // Double é mais apropriado para números de ponto flutuante no geral
decimal preco = 1.80M; // Decimal é mais apropriado para valores monetários por conta de sua alta precisão
bool condicao = true;

// Saída de dados
Console.WriteLine("\nFrase de apresentação: " + apresentacao);
Console.WriteLine("Altura: " + altura.ToString("0.000000")); // ToString() arredonda o valor para a quantidade de casas decimais desejadas
Console.WriteLine($"Preço: R$ {preco}");
Console.WriteLine($"Condição: {condicao}");


//===========================================================================================================================================
//                                                          O tipo DateTime
//===========================================================================================================================================

// Manipulação do tipo DateTime
DateTime dataAtual = DateTime.Now; // Declara uma variável DateTime
DateTime dataFutura = dataAtual.AddDays(5); // Acrescenta mais 5 dias à data atual
string dataFormatada = dataAtual.ToString("dd-MM-yyyy HH:mm"); // Formata a data adquirida em texto

// Saída de dados
Console.Write($"\n{dataAtual}");
Console.Write($"\n{dataFutura}");
Console.Write($"\n{dataFormatada}");
