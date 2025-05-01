public class ConsoleTable {
    public int ColumnWidth {get; set;} = 25;
    public int ColumnNum {get; set; } = 4;
    public required string[] HeaderText {get; set;}
    public required IEnumerable<Book> DataSource { get; set; }
    public void Display() {
        Border();
        Header();
        Border();
        DataRows();        
        Border();
    }
    private void Border() {
        var border = "";
        for (int i = 0; i < ColumnNum; i++) {
            border += "+" + "".PadRight(ColumnWidth, '-');
            if (i == ColumnNum - 1) {
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

    private void DataRows() {
        foreach(var data in DataSource) {
            var row = "";
            row += "|" + $"{data.Title}".PadRight(ColumnWidth);
            row += "|" + $"{data.Author}".PadRight(ColumnWidth);
            row += "|" + $"{data.PageCount}".PadRight(ColumnWidth);
            row += "|" + $"{data.Category}".PadRight(ColumnWidth) + "|";
            Console.WriteLine(row);
        }
    }
}