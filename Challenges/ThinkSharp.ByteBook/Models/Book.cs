public class Book {
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required int PageCount { get; set; }
    public Category? Category { get; set; }
}