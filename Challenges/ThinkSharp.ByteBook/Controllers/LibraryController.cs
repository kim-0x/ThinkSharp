/**
    Controller should be coordinate between view and model and shouldn't be know the implementation details
    of model, view or even loading any data from data source. It keeps refering or pointing to the right methods
    and keep workflow organize.
**/
public class LibraryController {
    private readonly BookRepository _bookRepository;
    private readonly Library _libraryModel = new Library();
    private readonly LibraryView _libraryView = new LibraryView() {
        ColumnWidth = 25,
        HeaderText = ["Title", "Author", "Page Count", "Category"],
    };
    public LibraryController(BookRepository bookRepository) {
        _bookRepository = bookRepository;

        foreach(var book in _bookRepository.GetBooks()) {
            _libraryModel.AddBook(book);
        }
    }

    public void DisplayBooks() {
        _libraryView.Display(_libraryModel.Books);
    }

    public void DisplayBookForm() {
        BookFormView bookFormView = new BookFormView();
        var book = bookFormView.GetBook();
        _libraryModel.AddBook(book);

        MessageView messageView = new()
        {
            Text = $"New book title {book.Title} is added."
        };
        messageView.Open();
    }
}