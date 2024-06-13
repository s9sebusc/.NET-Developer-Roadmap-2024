// See https://aka.ms/new-console-template for more information

using Test_Project_Repository_Pattern;

Console.WriteLine("Hello, World!");

IRepository<BookTO> bookRepository = new BookRepository();
BookService bookService = new BookService(bookRepository);

bookService.CreateBook(new BookTO("Harry Potter"));
