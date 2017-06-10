using System;

//namespace

namespace NumberGuesser
{
    //mainclass
    class MainClass
    {

        //entry point method
        public static void Main(string[] args)
        {

            //string name = "brad tra";
            //int age = 40;


            //Console.WriteLine("hello" + name +  "is" +age);
            //Console.WriteLine("{0} is {1}", name, age);


            // set app vars

            GetAppInfo();
            //ask users name
            GreetUser(); // ask for users name and greet

            while (true)
            {
                // init correct number
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);
                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("guess a number between 1 and 10");


                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get user's input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {

                        //print error message
                        PrintColorMessage(ConsoleColor.Red,"please use an actual number");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guesss to correct number
                    if (guess != correctNumber)
                    {

						PrintColorMessage(ConsoleColor.Red, "wrong number, please try again");
                    }

                }

                //print success message
				PrintColorMessage(ConsoleColor.Yellow, "Correct!!, You guessed it!");


				//ask to play again

				Console.WriteLine("play again? [Y or N]");

                //get answer

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                    
                }else if(answer == "N"){
                    return;
                }
                else 
                {
                    return;
                }
            }
        }

        //get and display app info
        static void GetAppInfo(){
			//string appName = "number guesser";
			//string appVersion = "1.0.0";
			//string appAuthor = "BRAD";

			//Console.WriteLine(appName + appVersion + appAuthor);

			//change text color
			Console.ForegroundColor = ConsoleColor.Green;

			//reset text color
			Console.ResetColor();
        }


        //ask users name and greet

        static void GreetUser(){
			Console.WriteLine("what is your name?");

			//get user input
			string inputName = Console.ReadLine();

			Console.WriteLine("hello {0}, lets play a game", inputName);
        }

        //print color message

        static void  PrintColorMessage(ConsoleColor color, string message){
			//change text color
			Console.ForegroundColor = color;

			//tell use its not a number
			Console.WriteLine(message);
			//reset text color
			Console.ResetColor();
        }
    }
}
