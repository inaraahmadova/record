using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecord std1 = new StudentRecord()
            {
                Name = "A",
                Surname = "B",
                Age = 20,
                Group="ab106",
                Uni="aztu"
            };
            
            //std1.Deconstruct(out string name, out string surname);
            //Console.WriteLine(name + " " + surname);

            //StudentRecord std2 = new StudentRecord("a", "b");

            //Console.WriteLine(std1 == std2);
            //Console.WriteLine( object.ReferenceEquals(std1, std2));

            StudentRecord std2 = std1 with { Name = "inara", Surname = "ahmadova" };
            StudentRecord std3 = std1 with { Name = "fatima", Surname = "abbasova" ,Uni="adnsu" };

            Console.WriteLine(std1);
            Console.WriteLine(std2);
            Console.WriteLine(std3);
        }
        record StudentRecord(string Name="xxx" , string Surname = "yyy" , int Age = 0 , string Group = "" , string Uni ="");
    
         class student
        {
            public string Name { get; init; }
            public string Surname { get; init; }="XXX";
        }
    }
}

