// Arquivo feito especificamente para a prática do menu interativo da etapa "Conhecendo as estruturas de repetição" do curso de C#

int input;
bool exibirOpcoes = true;

while (exibirOpcoes)
{
    Console.Clear(); // Limpa a tela
    Console.WriteLine("Digite uma das opções abaixo");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Sair");
    Console.Write("> ");
    input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("\nA opção de cadastro de cliente foi escolhida");
            Thread.Sleep(5000); // Bloqueia a execução do programa durante 5 segundos
            break;
        case 2:
            Console.WriteLine("\nA opção de buscar cliente foi escolhida");
            Thread.Sleep(5000);
            break;
        case 3:
            Console.WriteLine("\nA opção de apagar cliente foi escolhida");
            Thread.Sleep(5000);
            break;
        case 4:
            Console.WriteLine("\nEncerrando o programa...");
            Thread.Sleep(3000); 
            exibirOpcoes = false; // Encerra o programa
            break;
        default:
            Console.WriteLine("\nOPÇÃO INVÁLIDA!");
            Thread.Sleep(5000);
            break;
    }
}
