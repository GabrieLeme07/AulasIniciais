#region Tipo int (inteiro)

int numeroInteiro = 42;
Console.WriteLine(numeroInteiro);

#endregion

#region Tipo double (ponto flutuante de precisão dupla)

//double numeroDouble = 3.14159265359;
//Console.WriteLine(numeroDouble);

#endregion

#region Tipo float (ponto flutuante de precisão simples)

//float numeroFloat = 2.71828f;
//Console.WriteLine(numeroFloat);

#endregion

#region Tipo decimal (número decimal de alta precisão)

//decimal numerodecimal = 123.4567890123456789012345678m;
//Console.WriteLine(numerodecimal);

#endregion

#region Tipo char (caractere Unicode)

//char caractere = 'A';

////https://symbl.cc/en/unicode/table/#basic-latin

//char letra = '\u0041';

//Console.WriteLine(letra);

#endregion

#region Tipo string (cadeia de caracteres)

//string texto = "Hello, World!";
//Console.WriteLine(texto);

#endregion

#region Tipo bool (booleano)

//bool verdadeiro = true;
//bool falso = false;
//Console.WriteLine(verdadeiro);
//Console.WriteLine(falso);

#endregion

#region Tipo byte (inteiro sem sinal de 8 bits)

//byte byteValor = 255;

//Console.WriteLine(byteValor);

#endregion

#region Tipo sbyte (inteiro com sinal de 8 bits)

//sbyte sbyteValor = 127;
//sbyteValor++;
//Console.WriteLine(sbyteValor);

#endregion

#region Tipo short (inteiro com sinal de 16 bits)

//short shortvalor = -32768;
//Console.WriteLine(shortvalor);

#endregion

#region Tipo ushort (inteiro sem sinal de 16 bits)

//ushort ushortValor = 65535;
//Console.WriteLine(ushortValor);

#endregion

#region Tipo long (inteiro com sinal de 64 bits)

//long longValor = 9223372036854775807;
//Console.WriteLine(longValor);

#endregion

#region Tipo ulong (inteiro sem sinal de 64 bits)

//ulong ulongValor = 18446744073709551615;
//Console.WriteLine(ulongValor);

#endregion

#region Tipo DateTime (data e hora)

//DateTime dataHora = DateTime.Now;

//Console.WriteLine(dataHora);

#endregion

#region Tipo TimeSpan (intervalo de tempo)

//TimeSpan intervaloTempo = TimeSpan.FromDays(2);
//Console.WriteLine(intervaloTempo);

#endregion

#region Tipo enum (enumerador)

//DiaSemana dia;
//Console.WriteLine(dia);

//enum DiaSemana
//{
//    Segunda,
//    Terça,
//    Quarta,
//    Quinta,
//    Sexta,
//    Sábado,
//    Domingo
//}


#endregion

#region Tipo null (valor nulo)

//object objetoNulo = null;
//Console.WriteLine(objetoNulo);

#endregion

#region Exemplos

#region 01
/*
Tipos de valor = bool, byte, char, decimal, duplo, float, int, longo, uint, ulong, ushort, enum, struct 
Um tipo de valor contém os dados dentro de sua própria localização de memória.
 */

//int x = 3;
//int y = x;
//x = 5;
//Console.WriteLine($"x = {x}");
//Console.WriteLine($"y = {y}");

#endregion

#region 02

/*
Tipos de referência = classe, interface, delegado, string, objeto, dinâmico, arrays
Um tipo de referência contém um ponteiro para outro local de memória que contém os dados reais.
Se você atribuir uma variável de tipo de valor a outra variável, o valor será copiado diretamente.
 */

//Person alice = new Person { Name = "Alice", Age = 36 };
//Person bob = alice;
//bob.Name = "Bob";

//Console.WriteLine($"Alice's name: {alice.Name} \nBob's name: {bob.Name}");

//int[] array1 = new int[] { 1, 2, 3 };
//int[] array2 = array1; // Atribui a referência de 'array1' para 'array2'

//array1[0] = 100; // Altera o valor no array original

//Console.WriteLine("array1[0]: " + array1[0]);
//Console.WriteLine("array2[0]: " + array2[0]);

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

#endregion

#endregion

#region Casting: conversão explícita entre tipos COMPATÍVEIS

//double a;
//float b;
//a = 5.1;
//b = (char)a;
//Console.WriteLine(result);

//double a;
//int b;
//a = 5.1;
//b = (int)a;
//Console.WriteLine(b);

//int a = 5;
//int b = 2;
//double resultado = (double)a / b;
//Console.WriteLine(resultado);

#endregion

#region Restrições e convenções de nomes

/*
    Restrições
    • Não pode começar com dígito: use uma letra ou _
    • Não usar acentos ou til
    • Não pode ter espaço em branco
    • Sugestão: use nomes que tenham um significado

    Errado:
    int 5minutos;
    int salário;
    int salario do funcionario;

    Correto:
    int _5minutos;
    int salario;
    int salarioDoFuncionario

    Convenções
    • Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)
    • Pascal Case: LastName (namespaces, classe, properties e métodos)
    • Padrão _lastName (atributos "internos" da classe)
 */

#endregion

#region Saida de dados

//double x = 10.35784;
//int y = 32;
//string z = "Maria";
//char w = 'F';

//Console.Write("Olá mundo!");
//Console.WriteLine("Bom dia!");
//Console.WriteLine("Até mais.");

//Console.WriteLine();
//Console.WriteLine(x);
//Console.WriteLine(x.ToString("F2"));
//Console.WriteLine(x.ToString("F4"));
//Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

//Console.WriteLine();
//Console.WriteLine("RESULTADO = " + x);
//Console.WriteLine("O valor do troco é " + x + " reais");
//Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

//Console.WriteLine("a paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

//Console.ReadLine();

//int idade = 32;
//double saldo = 10.35784;
//String nome = "Maria";
//Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
//Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
//Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
//+ saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

#endregion

#region Operadores aritméticos

/*
 Operador Significado
    +       adição
    -       subtração
    *       multiplicação
    /       divisão
    %       resto da divisão
 */

#endregion

#region Operadores de atribuição

/*
 Operador   Exemplo       Significado
    =       a = 10;     a RECEBE 10
    +=      a += 2;     a RECEBE a + 2;
    -=      a -= 2;     a RECEBE a - 2;
    *=      a *= 2;     a RECEBE a * 2;
    /=      a /= 2;     a RECEBE a / 2;
    %=      a %= 3;     a RECEBE a % 3; 
 */

//int a = 10;
//Console.WriteLine(a);
//a += 2;
//Console.WriteLine(a);
//a *= 3;
//Console.WriteLine(a);
//string s = "ABC";
//Console.WriteLine(s);
//s += "DEF";
//Console.WriteLine(s);


//Operadores aritméticos / atribuição

/*
 Operador    Exemplo     Significado
    ++     a++; ou ++a;    a = a + 1;
    --     a--; ou --a;    a = a - 1;
*/

//int a = 10;
//a++;
//Console.WriteLine(a);

//int a = 10;
//int b = a++;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int a = 10;
//int b = ++a;
//Console.WriteLine(a);
//Console.WriteLine(b);

#endregion
