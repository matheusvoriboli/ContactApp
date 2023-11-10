namespace ContactApp.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
	}

    void btnAddContact_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    void btnEditContact_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }
}
