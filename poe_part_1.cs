using System;
using System.IO;
using System.Media;
using System.Text;
using static System.Net.WebRequestMethods;
using Microsoft.Win32;
using System.Configuration;

namespace part1
{
    public class poe_part_1
    {
        public poe_part_1()
        {
            welcomeMessage();
        }
        //creating a welcome message method
        private void welcomeMessage()
        {
             //calling the instant for voice greeeting
            new voice_greeting() { };

            //calling the instant for th ASCII Art
            new logo_design() { };


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ================================================ ");

            //welcoming the user 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           [welcome to the chatBot]               ");



            //the following design is for chatBot
            //reset the color to white 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ================================================ ");

            // Ask the user for their name
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();



            // Greet the user
            //setting the colour for chatBot
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" chatBot:-> ");
            Console.WriteLine("Hey!" + userName + "!" + "I'm here to help you with various topics. Feel free to ask me anything about Cyber Security.");


            //reseting the color to white
            Console.ForegroundColor = ConsoleColor.White;

            //array to store user questions
            string[] questions = new string[] { "How are you?", "what can i ask you about?", "what's your purpose?", "Password safety?", "Phishing?", "safe browsing?" };

            // Responses corresponding to each question
            string[] responses = new string[] { "I'm doing well, thank you for asking. how can i help you today?",
                "You can ask me about password safety, phishing, safe browsing, and other security-related topics",
                "My purpose is to help you with important topics like password safety, phishing, and safe browsing",
                "It's important to use strong, unique passwords and enable two-factor authentication.",
                "Phishing is a form of cyber attack where attackers try to trick you into giving them sensitive information.",
                " safe browsing, ensure you are visiting trusted websites, use HTTPS, and be cautious about downloading files from unknown sources.", };

            




            // loop to handle user input
            while (true)
            {
                // Setting the color for the user
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("User: ");
                string userInput = Console.ReadLine();

                //reset the color back to white
                Console.ForegroundColor = ConsoleColor.White;

                // Exit condition
                if (userInput == "exit")
                {
                    // Set color for the chatBot
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("chatBot: Goodbye! thank you for using chatBot");
                    //reset the color to white
                    Console.ForegroundColor = ConsoleColor.White;
                    //exit the loop if the user types exit
                    break;
                }

                // Flag to check if the question matches
                bool found = false;

                // Loop through the questions
                for (int i = 0; i < questions.Length; i++)
                {
                    // If the user input matches a question
                    if (userInput.Equals(questions[i], StringComparison.OrdinalIgnoreCase))
                    {
                        // Set color for the chatBot (green)
                        Console.ForegroundColor = ConsoleColor.Green;
                        //feedbank to user's input
                        Console.WriteLine("chatBot: " + responses[i]);
                        // Reset color to white
                        Console.ForegroundColor = ConsoleColor.White;
                        found = true;
                        //leave the loop if found
                        break;
                    }
                }


                // If no match was found
                if (!found)
                {
                    // Set color for the chatBot
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("chatBot:I didn't quite understand that, could you rephrase?");
                    // Reset color to white
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine(" ========= ");



            }
        }


    }
}
        

