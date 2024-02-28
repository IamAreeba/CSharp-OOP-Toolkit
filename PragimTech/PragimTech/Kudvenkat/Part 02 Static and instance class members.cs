using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Circle
{
    //float _PI = 3.141F;
    static float _PI;
    public static string _staticField;
    int _Radius;

    // Static Constructor
    static Circle()
    {
        Console.WriteLine("Static Constructor Called \n");
        Circle._PI = 3.141f;
        Circle._staticField = "Firstly i have made myseld public so in main i have been directly accessed but i am init the static constructor so when u are aceesing me i am init before u have called me ";
    }

    // Instance Constructor
    public Circle(int Radius)
    {
        Console.WriteLine("\nInstance Constructor Called");
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        //return this._PI * this._Radius * this._Radius;
        return Circle._PI * this._Radius * this._Radius;
    }

    public static void Print()
    {
        Console.WriteLine("\n I am static method. And i have 1 field static which is _PI = {0}", Circle._PI);
    }

}


class Program
{
    public static void Main()
    {

        Console.WriteLine(Circle._staticField);

        Circle C1 = new Circle(5);
        float Area1 = C1.CalculateArea();
        Console.WriteLine("Area1 = {0}", Area1);

        Circle C2 = new Circle(6);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);

        Circle.Print();

        Console.ReadLine();
    }
}