using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterfazContactos
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public static bool checkPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone) || phone.Length != 9 || !long.TryParse(phone, out _))
            {
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var contact = PromptForContact();
            if (contact != null)
            {
                contacts.Add(contact);
                UpdateContactList();
                MessageBox.Show("Contacto añadido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var selectedContact = listBox1.SelectedItem as Contact;
            if (selectedContact != null)
            {
                var updatedContact = PromptForContact();
                if (updatedContact != null)
                {
                    int index = contacts.IndexOf(selectedContact);
                    contacts[index] = updatedContact;
                    UpdateContactList();
                    MessageBox.Show("Contacto actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string phone = PromptForPhone();
            if (!string.IsNullOrEmpty(phone))
            {
                var contact = contacts.Find(c => c.Phone == phone);
                if (contact != null)
                {
                    MessageBox.Show($"Contacto encontrado:\nNombre: {contact.Name}\nTeléfono: {contact.Phone}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún contacto con ese número", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var selectedContact = listBox1.SelectedItem as Contact;
            if (selectedContact != null)
            {
                contacts.Remove(selectedContact);
                UpdateContactList();
                MessageBox.Show("Contacto eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedContact = listBox1.SelectedItem as Contact;
            if (selectedContact != null)
            {
                labelNombre.Text = "Nombre: " + selectedContact.Name;
                labelTelefono.Text = "Teléfono: " + selectedContact.Phone;
            }
        }

        private void UpdateContactList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = contacts;
            listBox1.DisplayMember = "Name";
        }

        private Contact PromptForContact()
        {
            string name = PromptForInput("Introduce el nombre del contacto:");
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string phone = PromptForPhone();
            if (string.IsNullOrWhiteSpace(phone))
            {
                return null;
            }

            return new Contact { Name = name, Phone = phone };
        }

        private string PromptForInput(string message)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(message, "Entrada");
        }

        private string PromptForPhone()
        {
            string phone = PromptForInput("Introduce el número de teléfono:");
            if (!Form1.checkPhone(phone))
            {
                MessageBox.Show("Número de teléfono inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return phone;
        }
    }
}