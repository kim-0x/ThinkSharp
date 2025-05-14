Console.WriteLine("Welcome to ByteBook!");
var menuController = new MenuController();
var libraryController = new LibraryController(new BookRepository());
ConsoleKeyInfo keyInfo;
do {
    menuController.DisplayMenu();
    switch(menuController.SelectedItem) {
        case 1: 
            libraryController.DisplayBookForm();
            break;
        case 2:
            libraryController.DisplayBooks();
            break;
        case 3: 
            Console.WriteLine("Search book form.");
            break;
        default:
            libraryController.DisplayBooks();
            break;        
    }
    Console.Write("Show Menu Again? (Y/n): ");
    keyInfo = Console.ReadKey();
    Console.WriteLine();
} while(keyInfo.Key == ConsoleKey.Y);
