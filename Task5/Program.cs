using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс «Журнал». Необходимо хранить в
полях класса: название журнала, год основания, описа-
ние журнала, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.*/


namespace Task5
{
    internal class Program
    {


        class Journal
        {
            private string name;
            private int year;
            private string description;
            private int numberPhone;
            private string mail;


            public void SetName(string name) { this.name = name; }
            public void SetYear(int year) { this.year = year; }
            public void SetDescription(string description) { this.description = description; }
            public void GetNumberPhone(int numberPhone) { this.numberPhone = numberPhone; }
            public void SetMail(string mail) { this.mail = mail; }


            public string GetMail() { return mail; }
            public string GetName() { return name; }
            public int GetYear() { return year; }
            public string GetDescription() { return description; }
            public int GetNumberPhone() { return numberPhone; }

            public void PrintInfo()
            {
                Console.WriteLine("Name : " + this.name);
                Console.WriteLine("Description : " + this.description);
                Console.WriteLine("Year of create : " + this.year);
                Console.WriteLine("Number Phone : " + this.numberPhone);
                Console.WriteLine("Mail : " + this.mail);
            }
            public void SetInfo()
            {
                Console.WriteLine("Enter a Journal info : ");
                Console.WriteLine("Name : ");
                this.name = Console.ReadLine();
                Console.WriteLine("Description : ");
                this.description = Console.ReadLine();
                Console.WriteLine("Year of create : ");
                this.year = int.Parse(Console.ReadLine());
                Console.WriteLine("Number Phone : ");
                this.numberPhone = int.Parse(Console.ReadLine());

                Console.WriteLine("Mail : ");
                this.mail = Console.ReadLine();




            }



            static void Main(string[] args)
            {
                Journal journal = new Journal();
                journal.SetInfo();
                journal.PrintInfo();




            }
        }
    }
}
