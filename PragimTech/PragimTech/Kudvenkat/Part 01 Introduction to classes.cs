//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// This class has 2 overloaded constructors
//class Customer
//{
//    // Class has state represented by these 2 fields. Data, Fields
//    string _firstName;
//    string _lastName;

//    // Initializing the fields by constructor. Constructor is use to initialize class fields

//    public Customer() : this("No FirstName provided", "No LastName Provided")
//    {

//    }

//    public Customer(string FirstName, string LastName)
//    {
//        this._firstName = FirstName;
//        this._lastName = LastName;
//    }

//    public void PrintFullName()
//    {
//        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
//    }

//    ~Customer()
//    {
//        // Clean up code
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Customer C1 = new Customer();
//        C1.PrintFullName();

//        Customer C2 = new Customer("Areeba", "Amjad");
//        C2.PrintFullName();


//        Console.ReadLine();
//    }
//}
