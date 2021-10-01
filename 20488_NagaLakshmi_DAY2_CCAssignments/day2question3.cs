using System;

namespace assignment3
{
    public class EmployeeSalary
    {
        string name;
        int empid;
        int basic;
        int hr;
        int trvlall;

        public EmployeeSalary(string name,int empid,int basic,int hr,int trvlall)
        {
            this.name = name;
            this.empid = empid;
            this.basic = basic;
            this.hr = hr;
            this.trvlall = trvlall;
        }
        public string getName()
        {
            return name;
        }
        public int getEmpid()
        {
            return empid;
        }
        public int getBasic()
        {
            return basic;
        }
        public int getHr()
        {
            return basic;
        }
        public int getTrvl()
        {
            return basic;
        }
        public double tax()
        {
            if (basic * 12 < 50000 && basic * 12 > 0)
                return basic * 0;
            else if (basic * 12 > 50000 && basic * 12 < 70000)
                return basic * .15;
            else
                return basic * .2;
        }
        public int gross()
        {
            return basic + hr + trvlall;
        }
        static void Main(string[] args)
        {
            EmployeeSalary emp = new EmployeeSalary("Chirag", 20792, 6000, 1000, 500);

            Console.WriteLine("Hello"+emp.getName()+".\n Emp ID:"+emp.getEmpid()+".\n Basic salary:"+ emp.getBasic()+".\n HR Allowance:"+emp.getHr()+ ".\n Travel Allowance:" + emp.getTrvl()++".\n Tax:" + emp.tax()+".\n Gross"+emp.gross());
        }
    }
}
