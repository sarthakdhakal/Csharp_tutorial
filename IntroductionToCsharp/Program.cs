using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using IntroductionToCsharp;

// using static Data.Data;

namespace IntroductionToCsharp
{
    #region delegateDeclaration

    // public delegate void HelloFriendsDelegate(string shazaam);

    // public delegate void AVerySimpleDelegate();

    #endregion

    class Program
    {
        #region codeUsedinPreviousTutorail

        // static StreamReader streamReader;
        // public override void Print()
        // {
        //     Console.WriteLine("Abstract class");
        // }

        #endregion

        static void Main(string[] args)
        {
            #region overloading of builtInFunctions

            // Customers customers = new Customers();
            // customers.FirstName = "Ram";
            // customers.LastName = "Shyam";
            // Customers customers1 = new Customers();
            // customers1.FirstName = "Ram1";
            // customers1.LastName = "Shyam";
            // Console.WriteLine(customers.ToString());
            // Console.WriteLine(customers.Equals(customers1));

            #endregion

            #region generics

            // bool equal = Calculate.isEqual<string>("X", "X");
            // if (equal)
            // {
            //     Console.WriteLine("Equal");
            // }
            // else
            // {
            //     Console.WriteLine("Not equal");
            // }

            #endregion

            #region codeUsedInTheMainMethodInPreviousExcercises

            // AVerySimpleDelegate simpleDelegate, simpleDelegate1, simpleDelegate2, simpleDelegate3;
            // simpleDelegate1 = new AVerySimpleDelegate(SampleFunction);
            // simpleDelegate2 = new AVerySimpleDelegate(SampleFunction1);
            // simpleDelegate3 = new AVerySimpleDelegate(SampleFunction2);
            // simpleDelegate = simpleDelegate1 + simpleDelegate2 + simpleDelegate3;
            // simpleDelegate();
            // Console.WriteLine("Input your first number" );
            // double num1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Input your second number" );
            // double num2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(num1+num2);
            // IList<Data> DataList = new List<Data>()
            // {
            //     new Data() {Id = 1, Name = "John", Age = 45},
            //     new Data() {Id = 3, Name = "Ram", Age = 44},
            //     new Data() {Id = 2, Name = "Shyam", Age = 44},
            //     new Data() {Id = 4, Name = "Hari", Age = 44},
            // };
            // IList arrayList = new ArrayList();
            // arrayList.Add(1);
            // arrayList.Add("Hi is a string");

            // foreach (var x in DataList)
            // // {
            // var a = DataList.Where(s => s.Age > 30 && s.Age <= 43);
            // foreach (var x in a)
            // {
            //    Console.WriteLine(x.Name); 
            // }
            //
            // Console.Write(a);
            // }
            // var b = arrayList.OfType<String>();
            // foreach (var x in b)
            // {
            //     Console.WriteLine(x); 
            // }
            // var x = DataList.OrderBy(d => d.Age);
            // foreach (var a in x)
            // {
            //     Console.WriteLine(a.Name); 
            // }
            // var x = DataList.OrderBy(d => d.Age).ThenBy(d=>d.Id);
            // foreach (var a in x)
            // {
            //     Console.WriteLine(a.Name ); 
            // }
            // var groupBy= DataList.GroupBy(d => d.Age);
            // foreach (var a in groupBy)
            // {
            //     Console.WriteLine("For the age: {0}",a.Key);
            //     foreach (var data in a)
            //     {
            //         Console.WriteLine(data.Name);
            //     }
            // }
            //     int Total = 0;
            //     bool satisfied = false;
            //     while (!satisfied)
            //     {
            //         Console.WriteLine("Do you want to buy a coffee");
            //
            //         Console.WriteLine("Press(S) for small, (M) for medium and (L) for large");
            //         string choice = Console.ReadLine().ToUpper();
            //
            //         switch (choice)
            //         {
            //             case "S":
            //                 Total += 1;
            //                 break;
            //             case "M":
            //                 Total += 2;
            //                 break;
            //             case "L":
            //                 Total += 3;
            //                 break;
            //             default:
            //                 Console.WriteLine("Your choice is invalid");
            //                 break;
            //         }
            //
            //         Decision:
            //         Console.WriteLine("Do you want to buy another coffee? (Yes) to continue and (No) to show the bill");
            //         String decision = Console.ReadLine().ToLower();
            //         switch (decision)
            //         {
            //             case "yes":
            //                 // goto Begin; 
            //                 break;
            //
            //             case "no":
            //                 satisfied = true;
            //                 break;
            //             default:
            //                 Console.WriteLine("The input was not correct. Please select the input again");
            //                 goto Decision;
            //         }
            //     }
            //
            //     Console.WriteLine("The total amount for your coffee is {0}", Total);
            // }

            // public class Data
            // {
            //     public int Id { get; set; }
            //     public string Name { get; set; }
            //     public int Age { get; set; }
            // }
            // bool satisfied = false;
            // int i = 0;
            // do
            // {
            //     i++;
            //     Console.WriteLine("Loop runs for the {0} number of times till now",i);
            //     Decision:
            //     Console.WriteLine("Do you run the loop? (Yes) to continue and (No) to end");
            //     String decision = Console.ReadLine().ToLower();
            //     switch (decision)
            //     {
            //         case "yes":
            //             // goto Begin; 
            //             break;
            //     
            //         case "no":
            //             satisfied = true;
            //             break;
            //         default:
            //             Console.WriteLine("The input was not correct. Please select the input again");
            //             goto Decision;
            //     }
            //   
            //     
            // } while (!satisfied);

            // int[] intArr = new[] {1, 2, 4, 5, 3, 6};
            // for (int i = 0; i < intArr.Length; i++)
            // {
            //     Console.WriteLine(intArr[i]);
            // }
            //
            // foreach (var x in intArr)
            // {
            //     Console.WriteLine(intArr[x-1]);
            // }
            // int a = 5;
            // int b = 2;
            // int product = 0;
            // Multiply(a, b, out product);
            // Console.WriteLine("The product of the numbers {0} and {1} is {2}", a, b, product);
            // Data.HiMethod();
            // Console.WriteLine(x);
            // Add(a, b);
            // ChangeNumber(ref a);
            // Console.WriteLine(a);
            // Circle c1 = new Circle(22);
            // double area = c1.CalculateArea();
            // Console.WriteLine(area);
            // FullTimeEmployee fte = new FullTimeEmployee();
            // fte.Name = "John";
            // Console.WriteLine(fte.Name);
            // Customer c1 = new Customer();
            // c1.Name = "Shyam";
            // Customer c2 = new Customer();
            // c2.Name = "Simon";
            // Customer c3 = new Customer();
            // c3.Name = "Shree";
            // c1.PrintName();
            // c2.PrintName();
            // c3.PrintName();
            // c1.Print1();
            // c1.PrintName();
            // ((ICustomer1)c2).PrintName();
            // Customer program = new Program();
            // program.Print();
            // HelloFriendsDelegate del= new HelloFriendsDelegate(HelloDarknessMyOldFriend);
            // del("What up what up?");
            // List<Chef> chefList = new List<Chef>();
            // chefList.Add(new Chef()
            // {
            //     Id = 1, Name = "John", Salary = 50000, Experience = 3
            // });
            // chefList.Add(new Chef()
            // {
            //     Id = 2, Name = "Mary", Salary = 50000, Experience = 2
            // });
            // chefList.Add(new Chef()
            // {
            //     Id = 3, Name = "Shyam", Salary = 70000, Experience = 5
            // });
            // // IsPromotable isPromotable = new IsPromotable(IsEligibleToPromote);
            // Chef.ChefPromote(chefList, chef=>chef.Experience>=2);
            // AVerySimpleDelegate simpleDelegate = SampleFunction;
            // simpleDelegate += SampleFunction1;
            // simpleDelegate += SampleFunction2;
            // simpleDelegate -= SampleFunction;
            // simpleDelegate();
            // try
            // {
            //     streamReader = new StreamReader(@"C:\Users\sarth\OneDrive\Desktop\requirements1.txt");
            //     Console.WriteLine(streamReader.ReadToEnd());
            //
            // }
            // catch (FileNotFoundException e)
            // {
            //     Console.Write(e.FileName + " doesn't exist");
            //     // Console.Write(e.StackTrace);
            //
            // }
            // catch (Exception e)
            // {
            //     Console.Write(e.Message);
            // }
            // finally
            // {
            //     if (streamReader != null)
            //     {
            //         streamReader.Close();
            //     }
            //    
            //     Console.WriteLine("File loaded or exception handled");
            // }
            // try
            // {
            //     try
            //     {
            //         Console.WriteLine("Input a number");
            //         int first = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Input another number");
            //         int second = int.Parse(Console.ReadLine() ?? string.Empty);
            //         int result = first / second;
            //         Console.WriteLine("The divided value is " + result);
            //
            //     }
            //     catch (Exception e)
            //     {
            //         var filePath = @"C:\Users\sarth\OneDrive\Desktop\logS.txt";
            //         if (File.Exists(filePath))
            //         {
            //             StreamWriter streamWriter = new StreamWriter(filePath);
            //             streamWriter.Write(e.GetType().Name);
            //             streamWriter.Close();
            //         }
            //         else
            //         {
            //             throw new FileNotFoundException(filePath + " not found", e);
            //         }
            //     }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.GetType().Name);
            //     if (ex.InnerException != null)
            //         Console.WriteLine(ex.InnerException.GetType().Name);
            // }

            #endregion

            #region enums

            // Customer[] customers = new Customer[3];
            // customers[0] = new Customer
            // {
            //     Name = "Ram",
            //     Gender = Gender.Male
            // };
            // customers[1] = new Customer
            // {
            //     Name = "Radha",
            //     Gender = Gender.Female
            // };
            // customers[2] = new Customer
            // {
            //     Name = "Rawan",
            //     Gender = Gender.Male
            // };
            // foreach (var customer in customers)
            // {
            //     Console.Write(customer.Name);
            //     Console.WriteLine(EnumToGender(customer.Gender));
            // }

            #endregion

            #region stringBuilder

            // StringBuilder str = new StringBuilder("");
            // for (int i = 1; i < 10000; i++)
            // {
            //     str.Append("i");
            //     // str.Append(" ");
            //     Console.Write(i+" ");
            // }

            #endregion

            #region Dictionary

            

           
            Customers customers = new Customers()
            {
                Id = 1,
                FirstName = "Harry",
                Salary = 50000
            };
            Customers customers1 = new Customers()
            {
                Id = 2,
                FirstName = "Hari",
                Salary = 500000
            };
            Customers customers2 = new Customers()
            {
                Id = 3,
                FirstName = "Mary",
                Salary = 5000
            };
            Customers customers3 = new Customers()
            {
                Id = 4,
                FirstName = "Darry",
                Salary = 40000
            };
            Customers customers4 = new Customers()
            {
                Id = 5,
                FirstName = "Gary",
                Salary = 30000
            };
            Dictionary<int, Customers> dictionary = new Dictionary<int, Customers>();
            dictionary.Add(customers.Id, customers);
            dictionary.Add(customers1.Id, customers1);
            dictionary.Add(customers2.Id, customers2);
            dictionary.Add(customers3.Id, customers3);
            dictionary.Add(customers4.Id, customers4);
            Console.WriteLine(dictionary.Count(s => s.Value.Salary > 6000));
            Customers customers11 = dictionary[1];
            Console.WriteLine("The id={0} , name = {1} and salary = {2}", customers11.Id, customers11.FirstName,
                customers11.Salary);
            foreach (KeyValuePair<int, Customers> customerValuePair in dictionary)
            {
                Console.WriteLine(customerValuePair.Key);
                Customers customer = customerValuePair.Value;
                Console.WriteLine("The id is {0}, name is {1} and the salary is {2}", customer.Id, customer.FirstName,
                    customer.Salary);
            }

            Customers cust;
            if (dictionary.TryGetValue(1, out cust))
            {
                Console.WriteLine("The id is {0}, name is {1} and the salary is {2}", cust.Id, cust.FirstName,
                    cust.Salary);
            }

            List<Customers> customersArray = new List<Customers>();
            customersArray.Add(customers);
            customersArray.Add(customers1);
            customersArray.Add(customers2);
            customersArray.Add(customers3);
            customersArray.Add(customers4);
            Dictionary<int, Customers> dict = customersArray.ToDictionary(custo => custo.Id, custo
                => custo);
            foreach (KeyValuePair<int, Customers> custData in dict)
            {
                Console.WriteLine(custData.Key);
                Console.WriteLine("The id is {0}, name is {1} and the salary is {2}", custData.Value.Id,
                    custData.Value.FirstName,
                    custData.Value.Salary);
            }
            #endregion
        }
    
        #region enums

        // public static string EnumToGender(Gender gender)
        // {
        //     switch (gender)
        //     {
        //         case Gender.Nonbinary:
        //             return "Non binary";
        //         case Gender.Male:
        //             return "Male";
        //         case Gender.Female:
        //             return "Female";
        //         default:
        //             return "Unknown";
        //     }
        // }

        #endregion
    }

    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }
    }

    #region classForGenerics

    // public class Calculate
    // {
    //     public static bool isEqual<T>(T val1, T val2)
    //     {
    //         return val1.Equals(val2);
    //     }

    #endregion

    #region classForOverRiding

    // public class Customers
    // {
    //     public string FirstName { get; set; }
    //     public string LastName { get; set; }
    //
    //     public override string ToString()
    //     {
    //         return this.FirstName + " " + LastName;
    //     }
    //
    //     public override bool Equals(object obj)
    //     {
    //         if (obj == null)
    //         {
    //             return false;
    //         }
    //
    //         if (!(obj is Customers))
    //         {
    //             return false;
    //         }
    //
    //         return this.FirstName == ((Customers) obj).FirstName &&
    //                LastName == ((Customers) obj).LastName;
    //     }
    // }

    #endregion
}

#region enums

// public enum Gender
// {
//     Nonbinary,
//     Male,
//     Female
// }
// public class Customer
// {
//     public string Name { get; set; }
//     public Gender Gender { get; set; }
// }

#endregion

#region codeUsedEarlier

// public static void SampleFunction()
// {
//     Console.WriteLine("Here");
// }
//
// public static void SampleFunction1()
// {
//     Console.WriteLine("Here1");
// }
//
// public static void SampleFunction2()
// {
//     Console.WriteLine("Here2");
// }
// public static bool IsEligibleToPromote(Chef chef)
// {
//     if (chef.Experience >= 3)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// public static void Multiply(int a, int b, out int product)
// {
//     product= a * b;
// }
//
// public static void Add(int a, int b)
// {
//     Console.WriteLine(a + b);
// }
//
// public static void ChangeNumber(ref int x)
// {
//     x = 22;
// }
// public static void HelloDarknessMyOldFriend(string shazaam)
// {
//     Console.WriteLine(shazaam);
// }


// public delegate bool IsPromotable(Chef chef);

// public class Chef
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Salary { get; set; }
//     public int Experience  { get; set; }

// public static void ChefPromote(List<Chef> chefList, IsPromotable isPromotable)
// {
//     foreach (Chef chef in chefList)
//
//     {
//         if (isPromotable(chef))
//         {
//             Console.WriteLine(chef.Name + " is promoted");
//         }
//     }
// }
// abstract class Customer
// {
//     public abstract void Print();
// }
// public class Circle
// {
//     static double pi;
//     int radius;
//
//     static Circle()
//     {
//         pi = 3.14;
//     }
//
//     public Circle(int radius)
//     {
//         this.radius = radius;
//     }
//
//     public double CalculateArea()
//     {
//         return pi * radius * radius;
//     }
// }
// public class Employee
// {
//     public int Age { get; set; }
//     public string Email { get; set; }
//
//     public virtual void PrintName()
//     {
//         Console.WriteLine(Name);
//     }
// public Employee(string name, int age, int email)
// {
//     this.name = name;
//     this.age = age;
//     this.email = email;
// }

// protected Employee()
// {
//
// }
// public string Name { get; set; }
// public void PrintName()
// {
//     Console.WriteLine(name);
// }
// }

// public class FullTimeEmployee : Employee
// {
//     private double yearlySalary;
//
//     public override void PrintName()
//     {
//         Console.WriteLine(Name + "fte");
//     }
// }

// public class PartTimeEmployee : Employee
// {
//     private double hourlyRate;
// }
//
// public struct Customer : ICustomer,ICustomer1
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//
// public Customer(int id, string name)
// {
//     this.Id = id;
//     this.Name = name;
// }
//
// public void PrintName()
// {
//     Console.WriteLine(Name);
// }
// void ICustomer1.PrintName()
// {
//     Console.WriteLine(Name);
//     }
//     public void Print1()
//     {
//         Console.WriteLine("Print action performed");
//     }
// }

// public interface ICustomer 
// {
//     void PrintName();
// }

// public interface ICustomer1
// {
//     void PrintName();
// }

#endregion