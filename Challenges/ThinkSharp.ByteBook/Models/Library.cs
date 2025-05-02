public class Library {
    public IList<Book> Books { get; private set; } = [];
    public void AddBook(Book book) {
        book.Validate();
        Books.Add(book);
    }
}