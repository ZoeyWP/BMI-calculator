using System;
using System.Security.Cryptography.X509Certificates;

namespace BMICalculator
{
    public class Calculator
    {

        
        public static void Main()
        {
            //To calculates the Body Mass Index (BMI) of a user 

            Console.WriteLine("Welcome! This program calculates your Body Mass Index (BMI) ");
            Console.Write("Please enter your name:  ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi , " + userName);

            float weight;
            float height;

            Console.Write("Please enter your weight in kilograms (kg): ");
            string userWeight = Console.ReadLine();
            try
            {
               weight = float.Parse(userWeight);
            }
            catch (Exception)
            {

                throw;
            }


            Console.Write("Please enter your height in meters (m): ");
            string userHeight = Console.ReadLine();
            try
            {
                height = float.Parse(userHeight);
            }
            catch (Exception)
            {

                throw;
            }
            
   
           

            //BMI formula: BMI = weight (kg) / (height (m) * height (m)).
            float BMI = weight / (height * height);
            Console.WriteLine("Your BMI is: " + BMI);

          
            //method called
            WHOCategory(BMI);

            Console.WriteLine();  
            Console.Read();
        }

        //method for the different WHO weight category
        static void WHOCategory(float BMI)
        {
            
            if (BMI <= 18.5)
            {
                Console.WriteLine("You are in the underweight category according to the WHO classification.");
            }

            else if (BMI > 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("You are in the normal weight category according to the WHO classification.");
            }

            else if (BMI > 24.9 && BMI <= 29.9)
            {
                Console.WriteLine("You are in the overweight category according to the WHO classification.");
            }

            else if (BMI >= 30)
            {
                Console.WriteLine("You are in the Obese category according to the WHO classification.");
            }
            else
            {
                Console.WriteLine("Your figures are incorrect");
            }

           
        }
        
    }
}