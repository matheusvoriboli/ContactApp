namespace ContactApp.Models;

public static class ContactRepository
{
    public static List<Contact> _contacts = new List<Contact>() {
        new Contact { ContactId = 0, Name = "John", Email = "john@gmail.com" },
        new Contact { ContactId = 1, Name = "Mark", Email = "mark@gmail.com" },
        new Contact { ContactId = 2, Name = "Michele", Email = "michele@gmail.com" },
    };

    public static List<Contact> GetContacts() => _contacts;

    public static Contact GetContactById(int contactId)
    {
        return _contacts.FirstOrDefault(x => x.ContactId == contactId);
    }
}