using System;

namespace _09012020
{
    class Program
    {

        static void Main(string[] args)
        {
            //Random random = new Random();
            //int misteryNumber = random.Next(10);
            //int trys = 0;
            //Boolean GameResult = false;




            //    while ( GameResult == false && trys < 3){
            //    int answer;
            //    trys++;

            //    answer = Game("Enter the mistery number:" );
            //    GameResult = CheckAnswer(answer, misteryNumber);

            //    if (trys >= 3 && GameResult == false)
            //    {
            //    Console.WriteLine("You have maxed out your trys. \nThe Mistery Number was " + misteryNumber);
            //    break; 
            //    }
            //     }

            //        static Boolean CheckAnswer(int answer, int number){
            //            if (answer != number)
            //            {
            //                return false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Congratulations, you get nothing.");
            //                return true;
            //            }
            //        }
            //        static int Game(string message){
            //                int answer;
            //                Console.WriteLine(message);
            //                answer = int.Parse(Console.ReadLine());

            //                return answer;
            //        }



            Boolean lapYear = CalculateLapYear("Enter your Birthday Year:");

            if (lapYear == true) {
                Console.WriteLine("You were born in a lap year");
            } 
            else
            {
                Console.WriteLine("Not a lap year, please try again on your next life.");
            }

            static Boolean CalculateLapYear(string m){
                Console.WriteLine(m);
                int birthYear = int.Parse(Console.ReadLine());

                if (birthYear % 4 == 0 && birthYear % 100 != 0)
                {
                    return true;
                } else
                {
                    return false;
                }

                
            }

            

            }

        

        }
    
}
