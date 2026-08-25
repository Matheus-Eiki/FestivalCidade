using FestivalCidade;

Console.WriteLine("****************Sistema de Ingressos Festival Cidade****************");
Console.WriteLine("");

Sistem sistema = new Sistema;

Console.Write("Digite o seu nome: ");
sistema.NomeFa = Console.ReadLine();

Console.Write("Digite a quantidade de dias que deseja ir ao festival: ");
sistema.Dias = int.Parse(Console.ReadLine());

Console.Write("Digite quantos pontos de fidelidade você tem: ");
sistema.PontosFidelidade = double.Parse(Console.ReadLine());

Console.Write("Digite o cupom de desconto (se houver): ");
sistema.CupomDesconto = Console.ReadLine();


