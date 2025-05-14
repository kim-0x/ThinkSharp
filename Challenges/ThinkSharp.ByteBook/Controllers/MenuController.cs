public class MenuController {
    private int _selectedItem;
    private readonly MenuView menuView = new MenuView() {
        MenuItems = ["Add Book", "Show List", "Search Books"],
        HeaderText = ["Item #", "Menu Item",]
    };
    public void DisplayMenu() {
        menuView.Open();
        menuView.ActivateKey();
        this._selectedItem = menuView.SelectedItem;
    }

    public int SelectedItem => this._selectedItem;
}