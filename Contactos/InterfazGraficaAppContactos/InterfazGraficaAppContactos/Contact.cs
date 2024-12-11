using System;

namespace InterfazContactos
{
    internal class Contact
    {
        private string name;
        private string phone;

        public Contact()
        {
            name = "";
            phone = "";
        }

        public Contact(string nombre, string telefono)
        {
            name = nombre;
            phone = telefono;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Contact c = (Contact)obj;
            return (Name?.Equals(c.Name) ?? false) && (Phone?.Equals(c.Phone) ?? false);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
                hash = hash * 23 + (Phone != null ? Phone.GetHashCode() : 0);
                return hash;
            }
        }
    }
}