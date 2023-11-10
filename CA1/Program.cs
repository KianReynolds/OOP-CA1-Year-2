using System.Security.Cryptography;

namespace CA1
{
    internal class Program
    {
        static int playerScore;
        static int dealerScore;


        static void Main(string[] args)
        {
            //Deck deck = new Deck();
            //deck.DisplayCards();
            //deck.shuffleDeck();



            Random rng = new Random();

            Hand c1 = new Hand(rng);
            int player1 = c1.Value;

            Hand c2 = new Hand(rng);
            int player2 = c2.Value;

            Hand c3 = new Hand(rng);
            int player3 = c3.Value;

            Hand c4 = new Hand(rng);
            int dealer = c4.Value;

            Hand c5 = new Hand(rng);
            int dealer2 = c5.Value;
            //Hand playerHand = new Hand(rng);
            //Hand dealerHand = new Hand(rng);

            


            //Console.ReadLine();

            Console.WriteLine("Welcome, Let's Play BlackJack");
            
            
            
            Random random = new Random();


            //get 2 numbers
            //int player1 = random.Next(1, 10);
            //int player2 = random.Next(1, 10);

            //add together
            playerScore = Sum(player1, player2);
            string option;
            bool choice = false;
            while (choice == true)
            {
                //display total
                Console.WriteLine($"The Player is dealt {c1}");
                Console.WriteLine($"The Player is dealt {c2}");
                Console.WriteLine($"The Players final score is {playerScore}");

                //ask if you want another number
                bool playAgain = false;
                Console.WriteLine("Do you want to stick or twist - s/t?");
                string response = Console.ReadLine();
                if (response == "t")
                    playAgain = true;

                while (playAgain)
                {
                    //get another
                    player3 = random.Next(1, 10);
                    Console.WriteLine(player3);

                    //add to total
                    playerScore += player3;

                    //display total
                    Console.WriteLine($"The Players final score is {playerScore}");

                    //ask for playAgain
                    Console.WriteLine("Do you want to stick or twist - s/t?");
                    response = Console.ReadLine();
                    if (response == "t")
                        playAgain = true;
                    else
                        playAgain = false;
                }

                //if so repeat

                



                dealer = random.Next(1, 10);

                dealer2 = random.Next(1, 10);


                dealerScore = dealer + dealer2;


                //Console.WriteLine("Do you want to stick or twist - s/t?");
                //string answer = Console.ReadLine();
                //Answer(answer);


                Console.WriteLine("Dealer plays");
                Console.WriteLine();
                Console.WriteLine($"The Dealer is dealt {c4}");
                Console.WriteLine($"The Dealer is dealt {c5}");
                Console.WriteLine($"The Dealers final score is {dealerScore}");


                if (playerScore > 21)
                {
                    Console.WriteLine("Player bust! Dealer wins");
                }
                else if (dealerScore > 21)
                {
                    Console.WriteLine("Dealer bust! Player wins");
                }
                else if (playerScore > dealerScore)
                {
                    Console.WriteLine("Player Wins");
                }
                else if (playerScore < dealerScore)
                {
                    Console.WriteLine("Dealer Wins");
                }
                else
                {
                    Console.WriteLine("It's a tie");
                }

                Console.WriteLine("Would you like to play another round - y/n?");

            }
            Console.WriteLine("Would you like to play again? y/n");
            //int option = Console.ReadLine();

            //if (option == "y")
            //{
            //    choice = true;
            //}
            //else
            //{
            //    choice = false;
            //}

        }

        static int Sum(int num1, int num2)
        {
            int final = 0;
            
            final = num1 + num2;
            return final;
        }

        
        
        

        







    }
}