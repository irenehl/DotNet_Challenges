// using Microsoft.CSharp.RuntimeBinder;
//
// class Employee
// {
//     private int _type;
//     static final int ENGINEER = 0;
//     static final int SALESMAN = 1;
//     static final int MANAGER = 2;
//     
//     public double MonthlySalary { get; set; }
//     public double Commission { get; set; }
//     public double Bonus { get; set; }
//
//     public Employee(int type)
//     {
//         _type = type;
//     }
//
//     public int GetPaymentAmount()
//     {
//         switch (_type)
//         {
//             case 0 :
//                 return MonthlySalary;
//             case 1 :
//                 return MonthlySalary + Commission;
//             case 2:
//                 return MonthlySalary + Bonus;
//             default:
//                 throw new RuntimeBinderException("Incorrect employee");
//         }
//     }
// }

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager(1000, 200);
            var eng = new Engineer(1000);
            var salesman = new Salesman(1000, 300);
            

            Console.WriteLine("Manager: " + manager.GetPaymentAmount());
            Console.WriteLine("Engineer: " + eng.GetPaymentAmount());
            Console.WriteLine("Salesman: " + salesman.GetPaymentAmount());
        }
    }
}

