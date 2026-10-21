using System;
using System.Text;

namespace hwUserMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("EMPLOYEE");
            Employee emp1 = new Employee("pug1", 15000);
            Employee emp2 = new Employee("pug2", 15000);
            Employee emp3 = new Employee("pug3", 300);

            Console.WriteLine("Початкові дані:");
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine();

            emp1 = emp1 + 2500;
            Console.WriteLine($"pug1 після + 2500: {emp1.Salary} грн");

            emp1 = emp1 - 1000;
            Console.WriteLine($"pug1 після - 1000: {emp1.Salary} грн");
            Console.WriteLine();

            emp2++;
            Console.WriteLine($"pug2 після ++ (+500 грн): {emp2.Salary} грн");

            emp3--;
            Console.WriteLine($"pug3 після --: {emp3.Salary} грн");
            Console.WriteLine();

            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}");
            Console.WriteLine($"emp1 > emp3: {emp1 > emp3}");
            Console.WriteLine($"emp3 < emp2: {emp3 < emp2}");
            Console.WriteLine();

            Employee emp4 = new Employee("pug2", 16500);
            Console.WriteLine($"Equals для pug1 і pug4: {emp1.Equals(emp4)}");
            Console.WriteLine();
            TestMatrix();
        }
        static void TestMatrix()
        {
            Console.WriteLine("MATRIX");
            Matrix m1 = new Matrix(2, 2);
            Matrix m2 = new Matrix(2, 2);

            m1[0, 0] = 1; m1[0, 1] = 2;
            m1[1, 0] = 3; m1[1, 1] = 4;

            m2[0, 0] = 5; m2[0, 1] = 6;
            m2[1, 0] = 7; m2[1, 1] = 8;

            Console.WriteLine("Матриця 1:");
            m1.Print();

            Console.WriteLine("\nМатриця 2:");
            m2.Print();

            Console.WriteLine("\nДодавання (m1 + m2):");
            (m1 + m2)?.Print();

            Console.WriteLine("\nМноження на число (m1 * 3):");
            (m1 * 3)?.Print();

            Console.WriteLine("\nМноження матриць (m1 * m2):");
            (m1 * m2)?.Print();

            Console.WriteLine($"\nm1 == m2: {m1 == m2}");
        }
    }
}