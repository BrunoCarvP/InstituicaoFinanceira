// See https://aka.ms/new-console-template for more information

using controleDeContas;

Cliente cliente1 = new Cliente("Menino Ney", 2000, "80545901563");
Conta conta1 = new Conta(123456, cliente1);
conta1.Saldo = 2341.42m;
decimal valorDeposito = 2000;
conta1.Deposito(valorDeposito);
decimal valorSaque1 = 100.00m;
conta1.Saque(valorSaque1);

Console.WriteLine($"Número da conta: {conta1.Numero} \nTitular da conta: {conta1.Titular.Nome} \nCPF do Tilutar: {conta1.Titular.Cpf} \nAno de nascimento do titular: {conta1.Titular.AnoNascimento} \nSaldo da conta: {conta1.Saldo:c2}");
Console.WriteLine();

Console.WriteLine($"Número da conta: {conta1.Numero} \nTitular da conta: {conta1.Titular.Nome} \nCPF do Tilutar: {conta1.Titular.Cpf} \nAno de nascimento do titular: {conta1.Titular.AnoNascimento} \nSaldo da conta: {conta1.Saldo:c2}");
Console.WriteLine();


Cliente cliente2 = new Cliente("Robson",2000,"12345678912");
Conta conta2 = new Conta(654321,cliente2);
conta2.Saldo = 2000.00m;
decimal valorDeposito2 = 1000;
conta2.Deposito(valorDeposito2);
decimal valorSaque2 = 100.00m;
conta2.Saque(valorSaque2);
conta2.Transferencia(conta1, 2000.00m);
/*conta2.Saldo = conta1.Saldo * 0.7m;*/


Console.WriteLine();
Console.WriteLine($"Número da conta: {conta2.Numero} \nTitular da conta: {conta2.Titular.Nome} \nCPF do Tilutar: {conta2.Titular.Cpf} \nAno de nascimento do titular: {conta2.Titular.AnoNascimento} \nSaldo da conta: {conta2.Saldo:c2}");
Console.WriteLine();



Console.WriteLine("Bem-vindo ao controle de contas!");
Console.WriteLine("Digite o numero da conta com 6 digitos:");
int numero = int.Parse(Console.ReadLine());


Console.Write("Nome do cliente: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite o ano de nascimento");
int anoNascimento = int.Parse(Console.ReadLine());

Console.Write("Número de CPF: ");
string cpf = Console.ReadLine();

Cliente cliente3 = new Cliente(nome, anoNascimento, cpf);
Conta conta3 = new Conta(numero, cliente3);

Console.Write("Saldo inicial: ");
decimal saldo = decimal.Parse(Console.ReadLine());
conta3.Saldo = saldo;


Console.WriteLine($"Saldo inicial da conta: {conta3.Saldo:C}");


Console.Write("Digite o valor do depósito: ");
decimal valorDeposito3 = decimal.Parse(Console.ReadLine());
conta3.Deposito(valorDeposito3);


Console.WriteLine($"Saldo após o depósito: {conta3.Saldo:C}");


Console.Write("Digite o valor do saque: ");
decimal valorSaque3 = decimal.Parse(Console.ReadLine());
conta3.Saque(valorSaque3);



Console.WriteLine($"Saldo após o saque: {conta3.Saldo:C}");
Console.WriteLine();
Console.WriteLine($"Número da conta: {conta3.Numero} \nTitular da conta: {conta3.Titular.Nome} \nCPF do Tilutar: {conta3.Titular.Cpf} \nAno de nascimento do titular: {conta3.Titular.AnoNascimento} \nSaldo da conta: {conta3.Saldo:c2}");