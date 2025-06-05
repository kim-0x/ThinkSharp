public class BookFormView {
    public string FormTitle { get; set; } = "Add New Book";
    public string LabelTitle { get; private set; } = "Title: ";
    public string? EntryTitle { get; set; }

    public string LabelAuthor { get; private set; } = "Author: ";
    public string? EntryAuthor { get; set; }

    public string LabelPageCount {get; private set; } = "Page Count: ";
    public int EntryPageCount {get; set; } = 0;

    public string LabelCategory {get; private set; } = "Category (0 - 8): ";
    public Category EntryCategory {get; set; } = 0;
    public BookFormView() {
        this.Load();
    }

    public Book GetBook() {
        return new Book() {
            Title = EntryTitle ?? "",
            Author = EntryAuthor ?? "",
            PageCount = EntryPageCount,
            Category = EntryCategory,
        };
    }

    private void Load() {
        Console.WriteLine(FormTitle);
        SetTitle();
        SetAuthor();
        SetPageCount();
        SetCategory();
    }

    private void SetTitle() {
        Console.Write(LabelTitle);
        EntryTitle = Console.ReadLine();
    }

    private void SetAuthor() {
        Console.Write(LabelAuthor);
        EntryAuthor = Console.ReadLine();
    }

    private void SetPageCount() {
        Console.Write(LabelPageCount);
        int.TryParse(Console.ReadLine(), out var result);
        EntryPageCount = result;
    }

    private void SetCategory() {
        Console.Write(LabelCategory);
        Enum.TryParse<Category>(Console.ReadLine(), out var result);
        EntryCategory = result;
    }
}