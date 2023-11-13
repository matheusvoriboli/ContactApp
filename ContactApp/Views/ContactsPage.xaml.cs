using ContactApp.Models;
using Contact = ContactApp.Models.Contact;

namespace ContactApp.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = ContactRepository.GetContacts();

		listContacts.ItemsSource = contacts;
	}

	private async void ListContacts_OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
	{
		if (listContacts.SelectedItem != null)
		{
			await Shell.Current.GoToAsync(
				$"{nameof(EditContactPage)}?Id={((Contact)listContacts.SelectedItem).ContactId}");
		}
	}
	
	private void ListContacts_OnItemTapped(object? sender, ItemTappedEventArgs e)
	{
		listContacts.SelectedItem = null; // ListContacts_OnItemSelected runs first and execute the action, after that this method is called to **remove the selection** from the item 
	}
}
