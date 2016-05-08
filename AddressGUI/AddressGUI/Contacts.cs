// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AddressGUI
{
    public class Contacts
    {
        public const int NUM_CONTACTS = 3;
        private Contact[] contacts = new Contact[NUM_CONTACTS];

        public void ReadFromFile(string path)
        {
            if (!File.Exists(path))
                throw new Exception("File does not exist! Path=" + path);
            try
            {
                StreamReader reader = new StreamReader(path);
                for (int i = 0; i < contacts.Length; i++)
                {
                    string[] parts = reader.ReadLine().Split(';');
                    contacts[i] = new Contact(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
                }
            }
            catch
            {
                throw new Exception("Not enough contacts!");
            }
        }

        public string[] GetAllLastNames()
        {
            string[] names = new string[NUM_CONTACTS];
            for (int i = 0; i < names.Length; i++)
                names[i] = contacts[i].LastName;
            return names;
        }

        public Contact GetContactFromLastName(string lastName)
        {
            foreach (Contact contact in contacts)
                if (contact.LastName == lastName)
                    return contact;
            throw new Exception("Unknown lastname " + lastName);
        }
    }
}