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
                else if (userAge <= 0)
                {
                    throw new FraudException();
                }
            }
            catch (FraudException)

            {
                Console.WriteLine("Suspected Fraudulent Activity Detected. User Input Is Unacceptable.");

            }
            catch (Exception)
            {
                Console.WriteLine("An error has been detected. Please contact the System Administrator.");

            }
            Console.ReadLine();
        }
            
        }
    }
