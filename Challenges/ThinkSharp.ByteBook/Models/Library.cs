public class Library {
    public IList<Book> Books { get; private set; } = new List<Book>();
    public void AddBooks(IEnumerable<Book> books) {
        foreach(var book in books) {
            this.Books.Add(book);
        }
    }
}