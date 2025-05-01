Console.WriteLine("Welcome to ByteBook!");
Console.WriteLine("Here are the suggestion books.");

var lib = new Library();
var consoleTable = new ConsoleTable() {
    ColumnWidth = 25,
    ColumnNum = 4,
    HeaderText = ["Title", "Author", "Page Count", "Category"],
    DataSource = lib.GetBooks(),
};
consoleTable.Display();
