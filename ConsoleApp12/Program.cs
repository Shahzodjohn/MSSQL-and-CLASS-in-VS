using System;

namespace ConsoleApp12
{
    class infobase
    {
        public string name { get; set; } 
        public string surname { get; set; }
        public int dateofbirth { get; set; }
        public string job { get; set; }
        public string citizenship { get; set; }

        public infobase(string n, string s, int d, string j, string c)
        {
            this.name = n;
            this.surname = s;
            this.dateofbirth = d;
            this.job = j;
            this.citizenship = c;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name {name} \nSurname {surname} \nDate of Birth {dateofbirth} \nJob {job} \nCitizenship {citizenship}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name = ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Surname = ");
            string surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Year of Birth = ");
            var dateofbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Job = ");
            string job = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Citizenship = ");
            string citizenship = Convert.ToString(Console.ReadLine());
            infobase infobase = new infobase(name, surname, dateofbirth, job, citizenship);
            infobase.GetInfo();
        }
    }
}
