using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSCODE_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Commenting code for multiple  values
            /*int[] numarray;
            Console.WriteLine("Choose the type of the number to perform mathematical operation?");
            Console.WriteLine("a) float" + '\n' + "b) Decimal" + '\n' + "c) Integer" );

            string numtype = Console.ReadLine();
            Console.WriteLine("Enter the count of numbers");
            int numcount = Convert.ToInt32(Console.ReadLine());
            numarray = new int[numcount + 1];
            Console.WriteLine(numarray.Length);

            for (int index = 1; index <= numcount; index++)
            {
                Console.WriteLine("Enter the" + index + "number");
                numarray[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Choose the mathematical operation to perform");
            Console.WriteLine("1) Addition" + '\n' + "2) Subtraction" + '\n' + "3) Multiplication" + '\n' +
                             "4) Division" + '\n');
            int oper = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case 1:
                    int sum = 0;
                    Array.ForEach(numarray, delegate (int i) { sum += i; });
                    Console.WriteLine("Sum of the Integers" + sum);
                    Console.ReadLine();
                    break;
                case 2:
                    int subvalue = 0;
                    Array.ForEach(numarray, delegate (int i) { subvalue -= i; });
                    Console.WriteLine("subtraction of the Integers" + subvalue);
                    Console.ReadLine();
                    break;
                case 3:
                    int mulvalue = 0;
                    Array.ForEach(numarray, delegate (int i) { mulvalue *= i; });
                    Console.WriteLine("Multiplication of the Integers" + mulvalue);
                    Console.ReadLine();
                    break;
                case 4:
                    int divideValue = 0;
                    Array.ForEach(numarray, delegate (int i) { divideValue /= i; });
                    Console.WriteLine("Divide of the Integers" + divideValue);
                    Console.ReadLine();
                    break;
            }*/
            #endregion

            #region code
            int num1 = 0;
            int num2 = 0;
            int result; char action = 'Y'; int oper = 6;
            while (action == 'Y')   // add loop
            {
                Console.Clear();
                result = 0;
                Console.WriteLine("Enter the First Number:");
                try { num1 = Convert.ToInt32(Console.ReadLine());  } catch(Exception ex) { Console.WriteLine(ex.Message); }
                Console.WriteLine("Enter the Second Number:");
                try { num2 = Convert.ToInt32(Console.ReadLine()); } catch(Exception ex) { Console.WriteLine(ex.Message); }
                Console.WriteLine("Choose the mathematical operation to perform");
                Console.WriteLine("1) Addition" + '\n' + "2) Subtraction" + '\n' + "3) Multiplication" + '\n' +
                                        "4) Division" + '\n' + "5) Modulus");
                try { oper = Convert.ToInt32(Console.ReadLine()); } catch (Exception ex) { Console.WriteLine(ex.Message); }
                OperationClass ORcls = new OperationClass();

                switch (oper)
                {
                    case 1:
                        result = ORcls.Addition(num1,num2);
                        Console.WriteLine("Value is {0}", result);
                        Console.ReadLine();
                        break;
                    case 2:
                        result = ORcls.Subtraction(num1, num2); 
                        Console.WriteLine("Value is {0}", result);
                        Console.ReadLine();
                        break;
                    case 3:
                        result = ORcls.Multiplication(num1, num2);
                        Console.WriteLine("Value is {0}", result);
                        Console.ReadLine();
                        break;
                    case 4:
                        result = ORcls.Division(num1, num2);
                        Console.WriteLine("Value is {0}", result);
                        Console.ReadLine();
                        break;
                    case 5:
                        result = ORcls.Modulus(num1, num2);
                        Console.WriteLine("Value is {0}", result);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("No action performed");
                        break;
                }

                Console.WriteLine("Do you want to continue!\n");
                Console.WriteLine("Press Y to continue");
                Console.WriteLine("Press N to finish");
                action = Console.ReadKey().KeyChar;
                oper = 6;
            }

        }
    }
    public class OperationClass
    {
        public OperationClass() { }
        public int Addition(int a, int b)
        {
            int x = a + b;
            return x;
        }
        public int Subtraction(int a, int b)
        {
            int x = a - b;
            return x;
        }
        public int Multiplication(int a, int b)
        {
            int x = a * b;
            return x;
        }
        public int Division(int a, int b)
        {
            int x = a / b;
            return x;
        }
        public int Modulus(int a, int b)
        {
            int x = a % b;
            return x;
        }
    }
    #endregion
}
