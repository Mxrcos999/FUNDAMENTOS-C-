int idade = 25;
uint idadeNaoSuportaNegativo = 25;
//ushort NaoSuportaNegativo = 25;
//ulong NaoSuportaNegativo = 25;

//long
//short

double altura = 1.75;
//float altura = 1.75f;
//decimal altura = 1.75m;

string nome = Console.ReadLine();

if (string.IsNullOrEmpty(nome))
{
    Console.WriteLine("Forneça um nome válido");
    nome = Console.ReadLine();
}

bool ehEstudante = true;

// Saída de dados para o console
Console.WriteLine("Informações Pessoais:");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Altura: " + altura + "m");
//Operador ternario abaixo (é uma estrutura de condição, igual o if e else, mas simplificado 
//estrutura: condição ? (se for true executa aqui) : (senão executa aqui)
//no exemplo abaixo ehEstudante é uma variavel booleana (true ou false), se(?) ela for true  "sim" será exibido senão (:) será exibido "Não"
Console.WriteLine("É estudante? " + (ehEstudante ? "Sim" : "Não"));
Console.WriteLine();

// Estrutura condicional - if-else
if (idade >= 18)
    Console.WriteLine("Você é maior de idade.");
else
    Console.WriteLine("Você é menor de idade.");

// Estrutura condicional - switch-case
Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1. Estudar");
Console.WriteLine("2. Trabalhar");
Console.WriteLine("3. Descansar");
Console.Write("Opção: ");
int opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Você escolheu estudar.");
        break;
    case 2:
        Console.WriteLine("Você escolheu trabalhar.");
        break;
    case 3:
        Console.WriteLine("Você escolheu descansar.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.ReadLine(); // Mantém o console aberto até que o usuário pressione Enter