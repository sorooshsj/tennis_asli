using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tennis
{
    class Tennis
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter right player name:");
            string PRname = Console.ReadLine();
            Console.WriteLine("enter left player name:");
            string PLname = Console.ReadLine();

            int PRscore = 0, PLscore = 0, scorePR = 0, scorePL = 0, PRset = 0, PLset = 0, PRgame = 0, PLgame = 0, PRmatch = 0, PLmatch = 0;
            bool match = false;
            bool game = false;
            var pressedkey = Console.ReadKey().Key;
            //while (match == false)
            //{
            //    while (game == false)
            //    {
              //   while (scorePR == 4 || scorePL == 4)
                    {
                        if (pressedkey == ConsoleKey.RightArrow)

                            Console.WriteLine(scorePR++);    

                        else if (pressedkey == ConsoleKey.LeftArrow)

                            Console.WriteLine(scorePL++);
                        else
                        {
                            Console.WriteLine("");

                        }
                                        switch (scorePR)
                                        {

                    
                   
                                            case 1:
                                                scorePR = 15;
                                                break;
                                            case 2:
                        scorePR = 30;
                                                break;
                                            case 3:
                        scorePR = 40;
                                                break;
                                            case 4:
                        scorePR = 0;
                                                break;
                                            default:
                                                break;
                                        }
                                        switch (scorePL)
                                        {
                                            case 1:
                        scorePL = 15;
                                                break;
                                            case 2:
                        scorePL = 30;
                                                break;
                                            case 3:
                        scorePL = 40;
                                                break;
                                            case 4:
                        scorePL = 0;
                                                break;
                                            default:
                                                break;
                                        }

                        //            }
                        //            if (scorePR == 4)
                        //            {
                        //                PRset++;
                        //            }
                        //            else if (scorePL == 4)
                        //            {
                        //                PLset++;
                        //            }
                        //            if (((PRset + PLset) == 6 && (PRset < PLset )) || ((PRset + PLset) > 6 && (PRset == (PLset - 2))))
                        //            {
                        //                PLgame++;
                        //                continue;
                        //            }
                        //            else
                        //            if (((PRset + PLset) == 6 && (PLset < PRset - 2)) || ((PRset + PLset) > 6 && (PLset == (PRset - 2))))
                        //            {
                        //                PRgame++;
                        //                continue;
                        //            }
                        //            if ((PRgame + PLgame) == 5)
                        //            {
                        //                game = true;
                        //            }
                        //        }
                        //        if (PRgame > PLgame)
                        //        {
                        //            PRmatch++;
                        //            match = true;
                        //        }
                        //        else if (PLgame > PRgame)
                        //        {
                        //            PLmatch++;
                        //            match = true;
                        //        }
                        //    }
                        //    Console.WriteLine("scorePR right");
                        //    Console.WriteLine(PRscore);
                        Console.ReadKey();
                    }

                }
            }
        }
    


        //}

    
    




