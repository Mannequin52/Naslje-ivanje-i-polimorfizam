using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje_i_polimorfizam
{
    class Program
    {

        //Desert
        class Dessert
        {
            string name;
            double weight;
            int cal;
            //metode
            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
            public int Cal { get => cal; set => cal = value; }
            //konstruktori
            public Dessert()
            {

            }
            public Dessert(string name, double weight, int cal)
            {
                this.Name = name;
                this.Weight = weight;
                this.Cal = cal;
            }
            public string GetDessertType()
            {
                return "Dessert";
            }
            //metoda za ispis
            public override string ToString()
            {
                string ispis = ("Ime desserta: " + this.Name + "\nTezina: " + this.Weight + "\nKalorije: " + this.Cal);
                return ispis;
            }
            
        }

        //Torta
        class Cake : Dessert
        {
            internal string ContainsGluten;
            bool constainsGluten;
            string cakeType;
            //konstruktori
            public Cake()
            {
            }

            public Cake(string name, double weight, int cal, bool constainsGluten, string cakeType)
            {
                this.Name = name;
                this.Weight = weight;
                this.Cal = cal;
                this.ConstainsGluten = constainsGluten;
                this.CakeType = cakeType;
            }
            //metode
            public bool ConstainsGluten { get => constainsGluten; set => constainsGluten = value; }
            public string CakeType { get => cakeType; set => cakeType = value; }
            public string Surename { get; internal set; }
            public int Age { get; internal set; }

            public string GetDessertType()
            {
                return this.CakeType + "Cake";
            }
            //metoda za ispis
            public override string ToString()
            {
                string ispis = ("Ime torte: " + this.Name + "\nTezina: " + this.Weight + "\nKalorije: " +  this.Cal + "\nIma gluten: " + this.ConstainsGluten
                    + "Tip torte: " + this.CakeType);
                return ispis;
            }
        }
        //Sladoled
        class Ice_Cream : Dessert
        {

            string flavour;
            string colour;
            //konstruktori
            public Ice_Cream()
            {
            }

            public Ice_Cream(string name, double weight, int cal, string flavour, string colour)
            {
                this.Name = name;
                this.Weight = weight;
                this.Cal = cal;
                this.Flavour = flavour;
                this.Colour = colour;
            }
            //metode
            public string Flavour { get => flavour; set => flavour = value; }
            public string Colour { get => colour; set => colour = value; }
            public string Surename { get; internal set; }
            public int Age { get; internal set; }

            public string GetDessertType()
            {
                return "Ice cream";
            }
            //metoda za ispis
            public override string ToString()
            {
                string ispis = ("Ime: " + this.Name + "\nTezina: " + this.Weight + "\nKalorije: " + this.Cal + "\nOkus: " + this.Flavour + "Boja: " + this.Colour);
                return ispis;
            }

        }
        //Osoba
        class Person
        {


            string name;
            string surename;
            int age;
            //konstruktori
            public Person()
            {
            }

            public Person(string name, string surename, int age)
            {
                this.Name = name;
                this.Surename = surename;
                this.Age = age;
            }
            //metode
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public string Surename { get; internal set; }
            //metoda za ispis
            public override string ToString()
            {
                string ispis = ("Ime: " + this.Name + "\nPrezime: " + this.Surename + "\nGodine: " + this.Age);
                return ispis;
            }

        }
        //Ucenik
        class Student : Person
        {
            string studentid;
            int academicYear;
            //konstruktori
            public Student()
            {
            }
            public Student(string name, string surename, int age, string studentid, int academicYear)
            {
                this.Name = name;
                this.Surename = surename;
                this.Age = age;
                this.Studentid = studentid;
                this.AcademicYear = academicYear;
            }
            //metode
            public string Studentid { get => studentid; set => studentid = value; }
            public int AcademicYear { get => academicYear; set => academicYear = value; }
            //metoda za ispis
            public override string ToString()
            {
                string ispis = ("ID ucenika: " + this.studentid + "\nGodina skolovanja: " + this.academicYear);
                return ispis;
            }
        }
        //Ucitelj
        class Teacher : Person
        {
            string email;
            string subject;
            double salary;
            //konstruktori
            public Teacher()
            {
            }
            public Teacher(string name, string surename, int age, string email, string subject, double salary)
            {
                this.Name = name;
                this.Surename = surename;
                this.Age = age;
                this.Email = email;
                this.Subject = subject;
                this.Salary = salary;
            }
            //metode
            public string Email { get => email; set => email = value; }
            public string Subject { get => subject; set => subject = value; }
            public double Salary { get => salary; set => salary = value; }
            //ispis
            public override string ToString()
            {
                string ispis = ("E-mail: " + this.email + "\nPredmet: " + this.subject + "\nPlaca: " + this.salary);
                return ispis;
            }
        }
        class CompetitionEntry
        {
            Teacher cook;
            Dessert food;
            Student ziri;
            Student ocjena;
            bool prolaz;

            public bool Prolaz { get => prolaz; set => prolaz = value; }
            internal Teacher Teach { get => cook; set => cook = value; }
            private Dessert Food { get => food; set => food = value; }
            private Student Ziri { get => ziri; set => ziri = value; }
            private Student Ocjena { get => ocjena; set => ocjena = value; }
        }
        class UniMasterChef
        {
            CompetitionEntry comp;

            private CompetitionEntry Comp { get => comp; set => comp = value; }
        }
        public double addRating(Student s1, )
        {

        }
        static void Main(string[] args)
        {
            Dessert genericDessert = new Dessert("Chocolate Mousse", 120, 300);
            Cake cake1 = new Cake("Raspberry chocolate cake #3", 350.5, 400, false, "birthday");

            Person p1 = new Person("Ivo", "Ivic", 20);
            Person p2 = new Person("Ivo", "Ivic", 20);
            Student p3 = new Student("Ivo", "Ivic", 20, "0036312123", (short)3);
            Student p4 = new Student("Marko", "Marić", 25, "0036312123", (short)5);
            Student s1 = new Student("Janko", "Horvat", 18, "0036312123", (short)1);
            Student s2 = new Student("Ana", "Kovač", 19, "0036387656", (short)2);
            Student s3 = new Student("Ivana", "Stanić", 19, "0036392357", (short)1);
            /*
            UniMasterChef competition = new UniMasterChef(2);
            CompetitionEntry e1 = new CompetitionEntry(t1, genericDessert);
            competition.addEntry(e1);
            */

            Teacher q1 = new Teacher("Dario", "Tušek", 42, "dario.tusek@fer.hr", "OOP", 10000);
            Teacher q2 = new Teacher("Doris", "Bezmalinović", 43, "doris.bezmalinovic@fer.hr","OOP", 10000);
            

            
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p3.Equals(p4));
            
            Console.ReadKey();
        }
    }
}