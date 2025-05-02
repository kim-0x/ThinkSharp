Console.WriteLine("Welcome to ByteBook!");

var libraryController = new LibraryController(new BookRepository());
libraryController.DisplayBooks();
libraryController.DisplayBookForm();
Console.WriteLine("Do you want to see all books? (Y/n)");
var keyInfo = Console.ReadKey();
if (keyInfo.Key == ConsoleKey.Y) {
    libraryController.DisplayBooks();
} else {
    Console.WriteLine("Bye!");
}