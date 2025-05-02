/**
    Controller should be coordinate between view and model and shouldn't be know the implementation details
    of model, view or even loading any data from data source. It keeps refering or pointing to the right methods
    and keep workflow organize.
**/
public class LibraryController {
    private readonly BookRepository _bookRepository;
    public LibraryController(BookRepository bookRepository) {
        _bookRepository = bookRepository;
    }

    public void DisplayBooks() {
        var model = new Library();
        model.AddBooks(_bookRepository.GetBooks());
        
        var view = new LibraryView() {
            ColumnWidth = 25,
            HeaderText = ["Title", "Author", "Page Count", "Category"],
            BookCollection = model.Books,
        };

        view.Display();
    }
}