//Simulação de um BD
var contasAtivas = new List<ContaBancaria>()
{
    new ContaBancaria(100, "1234"),
    new ContaBancaria(200, "2234"),
    new ContaBancaria(300, "2334")
};

var sistemaAtivo = true;

while (sistemaAtivo)
{
    Console.WriteLine("Bem-Vindo");
    Console.WriteLine("Informe sua senha");

    var senhaDigitada = Console.ReadLine();

    var contaExiste = contasAtivas.Where(c => c.Senha == senhaDigitada).FirstOrDefault();

    if (contaExiste == null)
    {
        Console.WriteLine("Conta não existe");
        return;
    }

    Console.WriteLine("Selecione um opção");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1 - Ver Saldo");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Deposito");
    Console.WriteLine("4 - Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            VerSaldo();
            break;

        case "2":
            Saque();
            break;

        case "3":
            Deposito();
            break;
    }


    void VerSaldo()
    {
        Console.WriteLine($"Seu saldo atual é: {contaExiste.Saldo}");
    }

    void Saque()
    {

        Console.WriteLine("Qual o valor que deseja sacar?");
        var valorDoSaque = decimal.Parse(Console.ReadLine());

       var saqueSuc = contaExiste.Withdraw(valorDoSaque);

        if (!saqueSuc)
        {
            Console.WriteLine("Algo deu errado com seu saque;");
        }

        Console.WriteLine($"Seu novo saldo é: {contaExiste.Saldo}");
    }

    void Deposito()
    {

    }


}


//Existe duas maneiras de buscar uma conta bancaria:
//var contaExiste = contasAtivas.FirstOrDefault(c => c.Senha == senhaDigitada);

public class ContaBancaria
{
    public decimal Saldo { get; set; }
    public string Senha { get; set; }

    public ContaBancaria(decimal saldo, string senha)
    {
        Saldo = saldo;
        Senha = senha;
    }

    public ContaBancaria()
    {
    }

    public ContaBancaria(string senha)
    {
        Senha = senha;
    }

    public bool Withdraw(decimal amount)
    {
        if(Saldo < amount)
        {
            Console.WriteLine("Você não tem saldo");
            return false;
        }

        var resultado = Saldo - amount;

        Saldo = resultado;

        //Saldo -= amount;

        return true;
    }
}