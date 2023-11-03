
#region Abstração 

//Neste exemplo, a classe Carro abstrai as características e comportamentos de um carro do mundo real.

//Carro meuCarro = new Carro();
//meuCarro.Modelo = "Sedan";
//meuCarro.Cor = "Azul";
//meuCarro.Acelerar();

#endregion

#region Herança

//A classe SUV herda as características da classe Carro e adiciona recursos específicos de um SUV.

SUV meuSUV = new SUV();
meuSUV.Modelo = "SUV Espaçoso";
meuSUV.TraçãoNasQuatroRodas = true;
meuSUV.Cor = "Preto";
meuSUV.AtivarTraçãoNasQuatroRodas();

#endregion

#region Polimorfismo 

IVeiculo veiculo1 = new Caminhão();
IVeiculo veiculo2 = new Motocicleta();

veiculo1.Dirigir(); // Chama o método Dirigir do Caminhão
veiculo2.Dirigir(); // Chama o método Dirigir da Motocicleta

#endregion

#region Interfaces

interface IVeiculo
{
    void Dirigir();
}

#endregion

#region :: Classes

class Carro
{
    public string Modelo { get; set; }
    public string Cor { get; set; }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando o carro.");
    }
}

class SUV : Carro, IVeiculo
{
    public bool TraçãoNasQuatroRodas { get; set; }

    public void AtivarTraçãoNasQuatroRodas()
    {
        Console.WriteLine("Tração nas quatro rodas ativada.");
    }

    public void Dirigir()
    {
        throw new NotImplementedException();
    }
}

class Motocicleta : IVeiculo
{
    public void Dirigir()
    {
        Console.WriteLine("Pilotando uma motocicleta.");
    }
}

class Caminhão : IVeiculo
{
    public void Dirigir()
    {
        Console.WriteLine("Dirigindo um caminhão.");
    }
}


#endregion