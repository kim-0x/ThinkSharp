/**
    Repository should be responsible for loading or fetch information from the source.
    For example, string literal, file, database.
**/
public class BookRepository {
    private string _source = """
        Mastering Mind,Taylor Miller,737,SelfHelp
        Secret Guide,Emerson Davis,231,Science
        Mastering Strategy,Riley Davis,710,Programming
        Brilliant Chronicle,Taylor Johnson,478,NonFiction
        Digital Guide,Jordan Anderson,120,Business
        Lost Handbook,Emerson Brown,530,History
        Secret Path,Avery Anderson,749,Art
        Mastering Blueprint,Jordan Anderson,772,Art
        Hidden Path,Jamie Anderson,777,Business
        Ultimate Journey,Riley Brown,168,Programming
        Essential Path,Riley Brown,624,SelfHelp
        Digital Guide,Alex Davis,198,Programming
        Ultimate Handbook,Riley Lee,487,SelfHelp
        Creative Strategy,Morgan Anderson,668,Business
        Hidden Strategy,Casey Wilson,458,Programming
        Hidden System,Alex Garcia,238,NonFiction
        Essential System,Jamie Johnson,383,Art
        Lost Tale,Taylor Miller,175,SelfHelp
        Essential Mind,Quinn Miller,372,SelfHelp
        Digital Chronicle,Jordan Garcia,510,SelfHelp
        Hidden Guide,Jamie Davis,800,Science
        Essential Chronicle,Quinn Anderson,226,Business
        Modern Journey,Jamie Wilson,533,SelfHelp
        Secret Strategy,Alex Miller,608,Art
        Brilliant Strategy,Emerson Lee,318,Programming
        Creative Chronicle,Casey Davis,500,History
        Lost System,Alex Smith,634,SelfHelp
        Modern System,Emerson Davis,362,History
        Hidden Blueprint,Quinn Miller,136,Fiction
        Brilliant System,Quinn Brown,328,SelfHelp
        Brilliant Strategy,Emerson Johnson,126,Science
        Modern Journey,Alex Anderson,624,History
        Hidden Guide,Quinn Wilson,480,Art
        Essential Path,Jamie Wilson,316,Programming
        Essential Guide,Jamie Wilson,780,History
        Digital Strategy,Emerson Lee,111,History
        Creative Guide,Riley Clark,441,NonFiction
        Lost Journey,Emerson Miller,777,Programming
        Mastering Chronicle,Quinn Smith,589,Business
        Creative System,Alex Miller,608,Art
        Brilliant Handbook,Avery Brown,769,History
        Secret Strategy,Jamie Brown,246,Programming
        Hidden Mind,Taylor Johnson,494,Programming
        Digital Handbook,Jordan Miller,741,History
        Hidden Guide,Jordan Miller,204,Fiction
        Lost Handbook,Avery Brown,267,Art
        Secret Chronicle,Casey Davis,167,Programming
        Lost Mind,Jamie Brown,605,Art
        Hidden Strategy,Riley Lee,579,Art
        Brilliant Chronicle,Jamie Miller,799,SelfHelp
        """;

    public IEnumerable<Book> GetBooks() {
        var books = _source.Split("\n");
        foreach(var book in books) {
            var newBook = book.Split(",");
            yield return new Book() {
                Title = newBook[0],
                Author = newBook[1],
                PageCount = int.Parse(newBook[2]),
                Category = Enum.Parse<Category>(newBook[3]),
            };
        }
    }
}