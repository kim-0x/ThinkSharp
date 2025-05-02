public class MessageView {
    public string Text { private get; set; } = "";
    public void Open() {
        if (string.IsNullOrWhiteSpace(Text)) return;

        Console.WriteLine("".PadRight(Text.Length + 4, '*'));
        Console.WriteLine("* " + Text + " *");
        Console.WriteLine("".PadRight(Text.Length + 4, '*'));
    }
}