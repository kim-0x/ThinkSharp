/**
    View should be responsible for display or represent the data/model into output devices.
    For example, console, windows forms, web, or IoT device.
**/
public class LibraryView {
    public int ColumnWidth {get; set;} = 25;
    public required string[] HeaderText {get; set;}
    public void Display(IEnumerable<Book> books) {
        Border();
        Header();
        Border();
        DataRows(books);        
        Border();
    }
    private void Border() {
        var border = "";
        var columnNum = HeaderText.Length;
        for (int i = 0; i < columnNum; i++) {
            border += "+" + "".PadRight(ColumnWidth, '-');
            if (i == columnNum - 1) {
                border += "+";
            }
        }
        Console.WriteLine(border);
    }

    private void Header() {
        var headerColumns = "";
        for(int index = 0; index < HeaderText.Length; index++) {
            headerColumns += "|" + HeaderText[index].PadRight(ColumnWidth);
            if (index == HeaderText.Length - 1) {
                headerColumns += "|";
            }
        }
        Console.WriteLine(headerColumns);
    }

    private void DataRows(IEnumerable<Book> books) {
        foreach(var data in books) {
            var row = "";
            row += "|" + $"{data.Title}".PadRight(ColumnWidth);
            row += "|" + $"{data.Author}".PadRight(ColumnWidth);
            row += "|" + $"{data.PageCount}".PadRight(ColumnWidth);
            row += "|" + $"{data.Category}".PadRight(ColumnWidth) + "|";
            Console.WriteLine(row);
        }
    }
}