using System;

// Exercitiul 1.d
namespace Lab1
{
    public class Employee
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
        public DateTime StartDate;
        public DateTime EndDate;
        public double Salary;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public bool IsActive()
        {
            if(this.EndDate > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Excercitiul 1.e
        // Functia Salutation() foloseste modificatorul virtual deoarece nu este absolut necesar overriding-ul acesteia 
        // in clasele derivate, insa daca este cazul sa se poate face acest fapt
        public virtual string Salutation()
        {
            return "Hello " + this.FirstName;
        }
    }
}
