using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace MachineASous
{
    class Program
    {
        static void Main()
        {
            char[] pos = new char[3];
            Random random = new Random();
            Random rotations = new Random();
            int num = 0;
            double bet = 0;
            double prize = 0;
            double credit = 0;
            bool dividable = false;

            //Splash
            Console.WriteLine("::::::::::: ::::::::::: :::::::::::\n:+:     :+: :+:     :+: :+:     :+:\n       +:+         +:+         +:+ \n      +#+         +#+         +#+  \n     +#+         +#+         +#+    \n    #+#         #+#         #+#     \n    ###         ###         ###     \n");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("\n\n         A production from\n         Ferluc R&D Inc.");
            Thread.Sleep(2500);
            Console.Clear();

            //If initial number of credits is dividable by 5
            while (dividable == false)
            {
                Console.WriteLine("How many money do you want to burn??");
                credit = int.Parse(Console.ReadLine());
                Console.Clear();
                if (credit % 5 == 0)
                {
                    dividable = true;
                }
            }

            //Consitions to win/stop the game
            do
            {
                bet = 1;
                Console.WriteLine("Credit: {0}\nWhat is your bet? (1/2/3/5)", credit);
                bet = double.Parse(Console.ReadLine());
                Console.Clear();

                //Is the user is betting more than he has?
                if (bet > credit)
                {
                    Console.WriteLine("You're too poor! Get the f*ck outta here!");
                }
                else
                {

                    for (int i = 0; i < rotations.Next(5, 10); i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            num = random.Next(0, 6);
                            switch (num)
                            {
                                case 0:
                                    pos[j] = '7';
                                    continue;
                                case 1:
                                    pos[j] = '*';
                                    continue;
                                case 2:
                                    pos[j] = '-';
                                    continue;
                                case 3:
                                    pos[j] = '=';
                                    continue;
                                case 4:
                                    pos[j] = '$';
                                    continue;
                                case 5:
                                    pos[j] = '0';
                                    continue;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("{0}{1}{2}", pos[0], pos[1], pos[2]);
                        Thread.Sleep(200);

                    }
                    if ((pos[0] == '7') && (pos[1] == '7') && (pos[2] == '7'))
                    {
                        Console.WriteLine("JACKPOT!! bet x40");
                        prize = bet * 40;
                    }
                    else if ((pos[0] == '=') && (pos[1] == '=') && (pos[2] == '='))
                    {
                        Console.WriteLine("WOW! bet x30");
                        prize = bet * 30;
                    }
                    else if ((pos[0] == '-') && (pos[1] == '-') && (pos[2] == '-'))
                    {
                        Console.WriteLine("Nice! bet x20");
                        prize = bet * 20;
                    }
                    else if ((pos[0] == '*') && (pos[1] == '*') && (pos[2] == '*'))
                    {
                        Console.WriteLine("Good! bet x10");
                        prize = bet * 10;
                    }
                    else if (((pos[0] == '-') || (pos[0] == '=')) && ((pos[1] == '-') || (pos[1] == '=')) && ((pos[2] == '-') || (pos[2] == '=')))
                    {
                        Console.WriteLine("What? bet x5");
                        prize = bet * 5;
                    }
                    else if (((pos[0] == '*') && (pos[1] == '*')) || ((pos[1] == '*') && (pos[2] == '*')) || ((pos[0] == '*') && (pos[2] == '*')))
                    {
                        Console.WriteLine("Ehh ok? bet x5");
                        prize = bet * 5;
                    }
                    else if ((pos[0] == '*') || (pos[1] == '*') || (pos[2] == '*'))
                    {
                        Console.WriteLine("Participation prize! bet x2");
                        prize = bet * 2;
                    }
                    else
                    {
                        Console.WriteLine("Too bad, you lost... loser");
                    }
                    credit = credit - bet;
                    Console.Read();
                    credit = credit + prize;
                }
            }
            while (credit < 2500);
            if (credit > 2500)
            {
                Console.WriteLine("You win!");
                Console.Read();
            }
        }
    }
}
