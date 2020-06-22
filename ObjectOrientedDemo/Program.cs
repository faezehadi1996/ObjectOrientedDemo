using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Employee e = new Employee();
            Manager m = new Manager();
            Bank b = new Bank();
            c1.name = "bardia";
            c1.birthdate = DateTime.Parse("1997-01-01");
            c1.getmoney(5000);
            string result = c1.getmoney("arezoo");
            Console.WriteLine(result);
            Console.WriteLine(BirthDate.Get(c1));
            c2.name = "arezoo";
            c2.birthdate = DateTime.Parse("1995-01-01");
            e.name = "fhd";
            e.birthdate = DateTime.Parse("1995-09-01");
            e.fathername = "hasan";
            m.name = "ebrahimi";
            m.birthdate = DateTime.Parse("1985-09-01");
            b.Address = "sare koche";
            b.manager = m;
            b.Name = "academy";
            e.getmoney(5000);
            Console.WriteLine(e.money);
            Console.Read();

        }
        public static void f(int fa)
        {
            fa = 10;
            Console.WriteLine(fa);
        }
        public static void f2(ref int fa)
        {
            fa = 10;
            Console.WriteLine(fa);
        }
    }
    static class BirthDate
    {
        public static double Get(Person p)
        {
            TimeSpan age = DateTime.Now - p.birthdate;
            return age.TotalDays / 365;
        }
    }
    class Person
    {
        public string name { get; set; }
        public string family { get; set; }
        public int money { get; set; }
        public DateTime birthdate { get; set; }
        public virtual void  getmoney(int moeny)
        {
            this.money = moeny;
        }
        public int getmoney()
        {
            return money;
        }
        public string getmoney(string name)
        {
            if(this.name == name)
            {
                return "you allowed your money is  : " + money;
            }
            else
            {
                return "You do not allow for seeing this account info";
            }
        }
    }
    class Employee : Person
    {
        public string entertime { get; set; }
        public string fathername { get; set; }
        public override void getmoney(int money)
        {
            this.money += money;
        }
    }

    public interface IPencil
    {

        bool IsSharp { get; }
    }
    public interface IPencilSharpener
    {
        void Sharpen(IPencil pencil);
    }

    class Customer : Person
    { 
        public override void getmoney(int money)
        {
            this.money -= money;
            if(this.money <0)
            {
                status = "bedehkar";
            }
            else
            {
                status = "ok";
            }
           
        }
    }
    class Manager : Person
    {
        public int salary { get; set; }
        public string cv { get; set; }
       
    }
    class Bank
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Manager manager { get; set; }
    }
}
