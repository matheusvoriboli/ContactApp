namespace ContactApp.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    void cancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        // Shell.Current.GoToAsync("..");
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");

    }
}
