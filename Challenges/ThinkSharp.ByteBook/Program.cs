Console.WriteLine("Welcome to ByteBook!");
Console.WriteLine("Here are the suggestion books.");

var libraryController = new LibraryController(new BookRepository());
libraryController.DisplayBooks();
