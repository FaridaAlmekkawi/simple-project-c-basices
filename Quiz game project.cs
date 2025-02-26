using System.Globalization;

namespace Quiz_game_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Quaz game ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("please Answer The following question :   ");

            string[] question = new string[]
            {
                "1 - What is the capital of italy ?",
                "2 - What is the red planet ? ",
                "3- What is the Largest animal ? "
            };
            String[] Answer = new string[]
          { "Roma", "Mars", "whale"
          };
            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                string  userAnswer = Console.ReadLine();
                int AnswerCont = 0;

                try
                {
                   bool result = Comparition(userAnswer, Answer[i]);


                    if (result == true)

                    {
                        Console.WriteLine("Answer is True ");
                        AnswerCont++;
                    }
                    else
                    {
                        Console.WriteLine($"Answer is false , True Answer {Answer[i]} ");
                    }

                }
                catch(Exception ex )
                { 
                    Console.WriteLine(ex.Message);
                }
               


            }
            Console.WriteLine("Quiz is completed , Thank you for playing ");
          
            




        }
        private static bool Comparition(string userInput , string Answer )
        {
            if (string.IsNullOrEmpty (userInput)) 
            {
                throw new Exception( "the answer is empty : try your answer ");
            }
            if  (userInput == Answer)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
