/*
  Tipos de listas IEnumerable, ICollection, IList, e IQueryable
 */

#region IEnumerable

/*
É uma interface que representa uma coleção de objetos que podem ser percorridos sequencialmente.
É a interface mais básica que oferece a capacidade de iteração, mas não fornece recursos de edição.
É adequada para leitura de dados em uma coleção.
*/

IEnumerable<int> enumerableNumbers = new List<int> { 5, 2, 3, 4, 1 };

foreach (var number in enumerableNumbers)
{
    Console.WriteLine(number);
}

#endregion

#region ICollection

/*
É uma interface que herda de IEnumerable e fornece métodos adicionais para manipular a coleção, como adicionar e remover elementos.
É adequada para coleções que podem ser modificadas.
*/


ICollection<int> collectionNumbers = new List<int> { 1, 2, 3, 4, 5 };

collectionNumbers.Add(6); // Adicionar um elemento
collectionNumbers.Remove(3); // Remover um elemento

foreach (var number in collectionNumbers)
{
    Console.WriteLine(number);
}

#endregion

#region IList

/*
É uma interface que herda de ICollection e fornece a capacidade de acessar elementos por índice.
É adequada para coleções que requerem acesso aleatório a elementos.
 */

//IList<int> ilistNumbers = new List<int> { 1, 2, 3, 4, 5 };

//Console.WriteLine("Elemento no índice 2: " + ilistNumbers[2]); // Acessar por índice
//ilistNumbers[0] = 10; // Modificar um elemento por índice

//foreach (var number in ilistNumbers)
//{
//    Console.WriteLine(number);
//}

#endregion

#region IQueryable

/*
É uma interface usada em consultas de banco de dados e em linq-to-sql.
É adequada para consultas a fontes de dados remotas ou consultas complexas.

Exemplo (usando Entity Framework, por exemplo):

Neste exemplo, IQueryable é usado para criar uma consulta que será executada no banco de dados quando necessário, permitindo otimizações de consulta.

 */

//using (var context = new MyDbContext())
//{
//    IQueryable<Customer> query = context.Customers.Where(c => c.City == "New York");

//    foreach (var customer in query)
//    {
//        Console.WriteLine(customer.Name);
//    }
//}

#endregion

