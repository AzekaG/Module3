using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс «Магазин». Необходимо хранить в
полях класса: название магазина, адрес, описание про-
филя магазина, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.*/


namespace Task6
{
    internal class Program
    {

        class Shop
        {
            string name;
            string adress;
            string description;
            string numberPhone;
            string email;

            public void setInfo()
            {
                Console.WriteLine("Enter a information : ");
                Console.Write("Enter a name of shop : ");
                this.name = Console.ReadLine();
                Console.Write("Enter a adress of shop : ");
                this.adress = Console.ReadLine();
                Console.Write("Write a description : ");
                this.description = Console.ReadLine();
                Console.Write("Write a phone number : ");
                this.numberPhone = Console.ReadLine();
                Console.Write("Write a email : ");
                this.email = Console.ReadLine();

            }
            public void Printinfo()
            {
                Console.WriteLine(name + " " + description);
                Console.WriteLine("Adress : " + adress);
                Console.WriteLine("Phone number  : " + numberPhone);
                Console.WriteLine("Email : " + email);
            }
            public void SetName(string name) { this.name = name; }
            public void SetAdress(string adress) { this.adress = adress; }
            public void SetDescription(string description) { this.description = description; }
            public void SetNumberPhone(string numberPhone) { this.numberPhone = numberPhone; }
            public void SetEmail(string email) { this.email = email; }

            public string GetName() { return this.name; }
            public string GetAdress() { return this.adress; }
            public string GetDescription() { return this.description; }
            public string GetNumberPhone() { return this.numberPhone; }
            public string GetEmail(string email) { return this.email; }



            static void Main(string[] args)
            {
                Shop shop = new Shop();
                shop.setInfo();
                Console.WriteLine();
                shop.Printinfo();


            }
        }
    }
}
