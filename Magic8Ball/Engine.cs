using System;

namespace Magic8Ball
{
    class Engine
    {
        public void Magic8()
        {
            int answer;
            bool check = false;
            string[] yesNo = { "Yes", "No", "Maybe", "Probably", "Depends", "Absolutely Not", "Ask Again" };
            string[] colors = { "Blue", "Green", "Yellow", "Red", "Purple", "Pink", "Brown", "Black", "Turquoise" };
            //string[] swearWords = { "fuck", "stupid", "dumb", "bitch", "asshole", "shit"};
            Console.Write("Ask your question: ");
            string question = Console.ReadLine();
            Random rndAnswer = new Random();
            if (question.ToLowerInvariant().Contains("color"))
            {
                answer = rndAnswer.Next(1, colors.Length);
                Console.WriteLine($"{colors[answer]}");
                Console.WriteLine("Would you like to ask another question?");
            }
            else if (question.ToLowerInvariant().Contains("fuck") || question.ToLowerInvariant().Contains("stupid") || question.ToLowerInvariant().Contains("bitch") || question.ToLowerInvariant().Contains("asshole") || question.ToLowerInvariant().Contains("dumb") || question.ToLowerInvariant().Contains("shit")
            {
                Console.WriteLine("No you're stupid.");
                Console.WriteLine("Would you like to ask another question?");
            }
            else
            {
                answer = rndAnswer.Next(1, yesNo.Length);
                if(colors[answer] == "Ask Again")
                {
                    Magic8();
                }
                Console.WriteLine($"{yesNo[answer]}");
                Console.WriteLine("Would you like to ask another question?");
            }
            do
            {
                string askAgain = Console.ReadLine();
                if (askAgain.ToLowerInvariant() == "yes")
                {
                    check = true;
                    Console.Clear();
                    Magic8();
                }
                else if(askAgain.ToLowerInvariant() == "no")
                {
                    Console.WriteLine("Until the next time you want your fortune told.");
                    Environment.Exit(0);
                }
            } while (check == false);
        }
        static void Main(string[] args)
        {
            Engine Magic = new Engine();
            Console.WriteLine($"I am the great and powerful Magic 8 Ball.");
            Magic.Magic8();
        }
    }
}
