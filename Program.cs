using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = GetDayOfWeek();
            BirthdayDecision(day);
        }
        static string GetDayOfWeek() 
        {
            Console.WriteLine(" What day of the week is it?");
            string day = Console.ReadLine();

            return day;
        }

        static void BirthdayDecision(String day)
        {
            string name;

            if (day == "Monday")
            {
                name = "Joseph";
                SayHappyBirthday(name);
            }
            else if(day == "Thursday")
            {
                name = "katie";
                SayHappyBirthday(name);
            }
            else
            {
                Console.WriteLine("No birthdays today :(");
            }
        }
        static void SayHappyBirthday(string name)
        {
            Console.WriteLine("Happy Birthday"+name);
        }
    }
}
            

            
        





            

  
                
            
            
             
    
    







    

            
            
        
        
        
         
        
            
        

