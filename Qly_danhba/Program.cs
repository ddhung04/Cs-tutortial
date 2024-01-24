using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_danhba
{
    // Class đại diện cho một liên lạc
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }

    // Interface định nghĩa các phương thức liên quan đến quản lý danh bạ
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        void RemoveContact(Contact contact);
        List<Contact> GetAllContacts();
    }

    // Class quản lý lưu trữ danh bạ
    public class ContactRepository : IContactRepository
    {
        private List<Contact> contacts;

        public ContactRepository()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
    }

    // Class quản lý hiển thị danh bạ
    public class ContactViewer
    {
        private IContactRepository contactRepository;

        public ContactViewer(IContactRepository repository)
        {
            contactRepository = repository;
        }

        public void DisplayContacts()
        {
            List<Contact> contacts = contactRepository.GetAllContacts();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}, Phone: {contact.Phone}");
            }
        }
    }

    // Class chính
    class Program
    {
        static void Main()
        {
            IContactRepository contactRepository = new ContactRepository();
            ContactViewer contactViewer = new ContactViewer(contactRepository);

            // Sử dụng các chức năng của ContactRepository và ContactViewer
            Contact newContact = new Contact("John Doe", "123-456-7890");
            contactRepository.AddContact(newContact);
            contactViewer.DisplayContacts();
            Console.ReadKey();
        }
    }

}
