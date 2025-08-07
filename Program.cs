using Demmo_OOP_02.Encapsulation;
using System.Security.Cryptography.X509Certificates;

namespace Demmo_OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Struct
            #region Example 01
            //Point p1;
            ////Declare For Variable | Object From Type "Point"
            ////CLR Will Allocate 8 Unitintialzed Bytes At Stack

            ////Console.WriteLine(p1.X);//Invalid

            //p1 = new Point();
            //// new=> Is just for constructor selection that will used to initialized p1 attribute
            //Console.WriteLine(p1.Y);//0
            //Console.WriteLine(p1.X);//0
            //p1 = new Point(10,20);
            //Console.WriteLine(p1.Y);//20
            //Console.WriteLine(p1.X);//10
            //p1 = new Point(10);
            //Console.WriteLine(p1.Y);//10
            //Console.WriteLine(p1.X);//10
            //Console.WriteLine(p1);//Demmo_OOP_02.Point because cw==<p1.ToString
            //Console.WriteLine(p1.ToString());//Demmo_OOP_02.Point

            //p1 = new(20);//sentax sugar 
            #endregion

            #region Examble  02
            //Point p1 = new(1, 2);
            //Console.WriteLine($"P1 = {p1}");

            //Point p2 = new(100, 200);
            //Console.WriteLine($"P1 = {p2}");

            //p2 = p1;
            //Console.WriteLine("After Assign P2=P1");
            //Console.WriteLine($"P1 = {p1}");
            //Console.WriteLine($"P2 = {p2}");

            //p1.X = 500;
            //p1.Y = 500;

            //Console.WriteLine("After Changing P1");
            //Console.WriteLine($"P1 = {p1}");
            //Console.WriteLine($"P2 = {p2}");
            #endregion
            #endregion

            #region Encapsulation
            Emolyee emp01 = new Emolyee(10, "nada", 100000, 21);
            Console.WriteLine(emp01);

            emp01.Id = 1;//Set Id Directly Through Attribute
            Console.WriteLine(emp01);//Get Id Directly Through Attribute

            emp01.SetName("Ahmed Mohamed");//Set Name Using Set Method
            Console.WriteLine(emp01.GetName());//Get Name Using Get Method

            emp01.Salary = 5000;//set salary using property as a get
            Console.WriteLine(emp01.Salary);//get salary using property as a set
            Console.WriteLine(emp01.Deduction);
            #endregion

            #region Phonebook
            PhoneNotebook notebook = new PhoneNotebook(3);
            Console.WriteLine(notebook.Size);

            notebook.AddPerson(0, "Ali", 123);
            notebook.AddPerson(1, "Samy", 456);
            notebook.AddPerson(2, "Ahmed", 789);


            #endregion
        }
    }
}