using FestivalCidade;

Console.WriteLine("****************Sistema de Ingressos Festival Cidade****************");
Console.WriteLine("");

Sistema sistema = new Sistema();

Console.Write("Digite o seu nome: ");
sistema.NomeFa = Console.ReadLine();

Console.Write("Digite a quantidade de dias que deseja ir ao festival: ");
sistema.Dias = int.Parse(Console.ReadLine());

Console.Write("Digite quantos pontos de fidelidade você tem: ");
sistema.PontosFidelidade = double.Parse(Console.ReadLine());

Console.Write("Digite o cupom de desconto (se houver): ");
sistema.CupomDesconto = (Console.ReadLine() ?? "").ToUpper();


Console.WriteLine("\n --------------Ingresso--------------");
Console.WriteLine($"Nome: {sistema.NomeFa}");
Console.WriteLine($"O valor bruto do ingresso é: R$ {sistema.CalcularCustoBruto():F2}");
Console.WriteLine($"O valor final é: R$ {sistema.CalcularDesconto():F2}");
Console.WriteLine($"Acesso VIP: {(sistema.AcessoVip() ? "Sim" : "Não")}");
Console.ReadKey();