using ContactApp.Models;
using Contact = ContactApp.Models.Contact;

namespace ContactApp.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    void cancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    public string ContactId
    {
	    set
	    {
		    contact = ContactRepository.GetContactById((int.Parse(value)));
		    lblName.Text = contact.Name;
	    }
    }
}
