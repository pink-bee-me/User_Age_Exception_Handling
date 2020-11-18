using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Age_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool trueAge = false;

                DateTime currentDate = DateTime.Today;
                Console.WriteLine("Please Eneter Your Age:");
                int userAge = Convert.ToInt32(Console.ReadLine());
               if (userAge > 0)
                {
               
                
                DateTime calculation = currentDate.AddYears(-userAge);
                string yearBorn = calculation.ToString("yyyy");
                Console.WriteLine("Based on your input, you were born in the year of: {0}", yearBorn);
                Console.ReadLine();
            }


            catch (FraudException)

            { if (userAge < 0)

                {
                    Console.WriteLine("Security Alert! Fraudulent Activity Suspected or Detected! Program Execution Aborted!");
                    Console.ReadLine();
                    return;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please use digits only , no decimals or text.");
                Console.ReadLine();
                return;

            }
            catch (Exception)
            {
                Console.WriteLine("An error has been detected. Please contact the System Administrator.");
                Console.ReadLine();
                return;
            }
        

            
        }
    }
}