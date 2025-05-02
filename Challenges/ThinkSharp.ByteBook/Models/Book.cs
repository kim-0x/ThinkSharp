public class Book {
    public required string Title { get; init; }
    public required string Author { get; init; }
    public required int PageCount { get; init; }
    public Category? Category { get; set; }

    public void Validate() {
        if (string.IsNullOrWhiteSpace(Title)) {
            throw new ArgumentException("Title is required.");
        }

        if (string.IsNullOrWhiteSpace(Author)) {
            throw new ArgumentException("Author is required.");
        }

        if (PageCount < 0) {
            throw new ArgumentOutOfRangeException("PageCount must be non-nagative.");
        }
    }
}