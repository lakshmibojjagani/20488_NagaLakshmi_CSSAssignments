using System;

public class Program
{
    public static void Main()
    {
        Double Basic_Salary, DA, HRA, Gross_Salary;
        
        Console.Write("Enter Basic Salary : ");
        Basic_Salary = Convert.ToInt32(Console.ReadLine());
        
        DA = (Basic_Salary * 40) / 100;
        HRA = (Basic_Salary * 20) / 100;
        Gross_Salary = Basic_Salary + DA + HRA;
        
        Console.Write("\n\nDearness Allowance 40 % of Basic Salary : " + DA);
        Console.Write("\nHouse Rent 20 % of Basic Salary : " + HRA);
        Console.Write("\nGross Salary : " + Gross_Salary);
    }
}