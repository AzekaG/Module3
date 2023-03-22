using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса.*/


namespace Task4
{
    internal class Program
    {

        class WebSite
        {
            private string name;
            private string url;
            private string description;
            private string ip;


            public WebSite(string name, string url, string description, string ip)
            {
                this.name = name;
                this.url = url;
                this.description = description;
                this.ip = ip;
            }


            public string GetName() { return name; }
            public string GetUrl() { return url; }
            public string GetDescription() { return description; }
            public string GetIp() { return ip; }

            public void SetName(string name) { this.name = name; }
            public void SetUrl(string url) { this.url = url; }
            public void SetDescription(string description) { this.description = description; }
            public void SetIp(string ip) { this.ip = ip; }

            public void SetAllInfo()
            {
                this.name = Console.ReadLine();
                this.url = Console.ReadLine();
                this.description = Console.ReadLine();
                this.ip = Console.ReadLine();
            }

        }

    

        
        static void Main(string[] args)
        {
            WebSite Site = new WebSite("Bambooc", "www.Bambook.com", "Sailing Closes", "192.168.0.1" );
            Console.WriteLine(Site.GetName() + "  " +  Site.GetUrl() + "  " + Site.GetIp() + "   " + Site.GetDescription());

        }
    }
}
