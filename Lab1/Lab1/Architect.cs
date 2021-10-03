using System;

// Exercitiul 1.c
// Comentariile reprezinta rezolvarea subpunctelor inainte de exercitiul 1.e

namespace Lab1
{
    class Architect : Employee
    {
        // public Guid Id;
        // public string FirstName;
        // public string LastName;
        // public DateTime StartDate;
        // public DateTime EndDate;
        // public double Salary;
        public Architect(string First, string Last, DateTime Start, DateTime End, double Sal)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = First;
            this.LastName = Last;
            this.StartDate = Start;
            this.EndDate = End;
            this.Salary = Sal;
        }
        // public string GetFullName()
        // {
        //    return this.FirstName + " " + this.LastName;
        // }

        // public string IsActive()
        // {
        //    if (this.EndDate > DateTime.Now)
        //    {
        //        return this.GetFullName() + " (Id: " + this.Id + ") is still active";
        //    }
        //    else
        //    {
        //        return this.GetFullName() + " (Id: " + this.Id + ") is no longer active";
        //    }
        // }

        // public override string Salutation()
        // {
        //      return "Hello architect " + this.GetFullName();
        // }
    }
}
