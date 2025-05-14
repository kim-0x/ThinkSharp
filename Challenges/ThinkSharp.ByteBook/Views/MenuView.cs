public class MenuView {
    public required string[] MenuItems { get; set; }
    public int SelectedItem { get; set; } = 1;
    public required string[] HeaderText {get; set;}
    public int ColumnWidth {get; set; } = 20;
    public void ActivateKey() {
        ConsoleKeyInfo keyInfo;
        do {
            keyInfo = Console.ReadKey();
            Console.Clear();
            if (keyInfo.Key == ConsoleKey.UpArrow) {
                if (SelectedItem == 1) SelectedItem = MenuItems.Length;
                else {
                    SelectedItem--;
                }             
            } else if (keyInfo.Key == ConsoleKey.DownArrow) {
                if (SelectedItem == MenuItems.Length) SelectedItem = 1;
                else {
                    SelectedItem++;
                }
            }
            Open();
        } while(keyInfo.Key != ConsoleKey.Enter);
    }
    public void Open() {
        int index = 1;
        Border();
        Header();
        Border();
        var menuItems = new List<KeyValuePair<int,string>>();
        foreach (var item in this.MenuItems) {
            if (string.IsNullOrWhiteSpace(item)) return;
            menuItems.Add(KeyValuePair.Create(index++, item));
        }
        DataRows(menuItems);
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

    private void DataRows(IEnumerable<KeyValuePair<int, string>> items) {
        foreach(var data in items) {
            var row = "";
            var key = (data.Key == this.SelectedItem) ?$"> {data.Key}" : $"  {data.Key}";
            row += "|" + key.PadRight(ColumnWidth);
            row += "|" + $"{data.Value}".PadRight(ColumnWidth) + "|";
            Console.WriteLine(row);
        }
    }
}