using Asociaciones.ManyToOne;
using Asociaciones.OneToOne;

Console.WriteLine("///////////////// OneToOne /////////////////////");

Address address = new Address { Id=1,Street="Calle 1", City="Madrid"};

Customer customer = new Customer { Id = 1,Name = "Customer1", Age = 30, Address = address};

Console.WriteLine(customer);
Console.WriteLine(address);

Console.WriteLine("///////////////// ManyToOne /////////////////////");

Author author = new Author { Id = 1, Name="Richel",Age=25 };
Book book1 = new Book { Id = 1, Title = "Peste vil", Author = author };
Book book2 = new Book { Id = 2, Title = "La sombra oscura", Author = author };
Book book3 = new Book { Id = 3, Title = "Pinocho", Author = author };

//author.Books = new List<Book> { book1, book2, book3 };//resetea la lista de libros
/*
author.Books.Add(book1);
author.Books.Add(book2);
author.Books.Add(book3);
*///Aqui inicializas uno por uno reiniciando

author.Books.AddRange(new List<Book> { book1, book2, book3 });

Console.WriteLine(author.Books[1]);
Console.WriteLine(book1);