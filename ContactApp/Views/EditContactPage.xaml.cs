namespace ContactApp.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    void cancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}
