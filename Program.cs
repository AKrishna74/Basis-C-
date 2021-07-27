using System;

namespace bala
{
    class Program
    { 
         static void Main(string[] args)
        {
            Check ob = new Check();
            ob.Marksheet();
        }
       
      
    }
    class Check
    {
 public void Marksheet()
        {
            Console.Write("Give Your Maths Marks:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Your Physics Marks:");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give Your Chemistry Marks:");
            int che = Convert.ToInt32(Console.ReadLine());
            int total = math + phy + che;
            Console.WriteLine("Total=" + total);
            int avg = total / 3;
            Console.WriteLine("Average=" + avg);
            if (avg >= 40)
            {
                Console.WriteLine("You are passed");
            }
            else { Console.WriteLine("You are failed"); }


        }
       public void Numsign()
        {
            Console.Write("Give Your Number Here:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Negative number");

            }
            else
            {
                Console.WriteLine("Positive number");
            }
        }
       public void Age()
        {
            Console.Write("What is his Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("He is Short");
            }
            else
            {
                Console.WriteLine("He is Tall");
            }
        }
        public void Salary()
        {
            Console.Write("What is Salray:");
            int sal = Convert.ToInt32(Console.ReadLine());
            if (sal>5000)
            {
                Console.WriteLine("Supervisor");
            }
            else
            {
                Console.WriteLine("Clerk");
            }
            
            
        }
    }
    
    


}

