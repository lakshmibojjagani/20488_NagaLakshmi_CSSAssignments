using System;

namespace question4
{
    public class marriage
    {
        string name, address, marital_status,Dob;
        
        public marriage(string name, string address, string marital_status,string Dob)
        {
            this.name = name;
            this.address = address;
            this.marital_status = marital_status;
            this.Dob = Dob;

        }
        public string getName()
        {
            return name;
        }
        public string getAdd()
        {
            return address;
        }
        public string getMar()
        {
            return marital_status;
        }
        public string getDob()
        {
            return Dob;
        }
        public int getAge()
        {
            string dateofbirth = this.getDob();
            DateTime age = DateTime.Parse(dateofbirth);
            int theAge = DateTime.Now.AddYears(-age.Year).Year;
            return theAge;

        }
        public string canMarry()
        {
            if (this.getAge() > 18&&this.getMar().Equals("Single")) 
                return ("can marry");
            else
                return ("can not marry");
        }
        public string getString()
        {
            return (this.getName() + " lives in " + this.getAdd() + " born on, " + this.getDob() + "," + this.marital_status + "," + this.getAge() + " years old " + this.canMarry());
        }
        static void Main(string[] args)
        {
            marriage newone = new marriage("chirag", "asghfdgsfv","Single","11/11/1999");
            // Console.WriteLine(newone.getName()+" lives in "+newone.getAdd()+" born on, "+newone.getDob()+","+newone.marital_status + "," + newone.getAge()+" years old "+newone.canMarry());
            Console.WriteLine( newone.getString());
        }
    }
}