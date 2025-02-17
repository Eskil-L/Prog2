﻿using System; 
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    public class Program
    {
        static List<List<string>> boardArrayList = new List<List<string>>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string board = "[T, H, B, K, Q, B, H, T]\n[P, P, P, P, P, P, P, P]\n[', ', ', ', ', ', ', ']\n[', ', ', ', ', ', ', ']\n[', ', ', ', ', ', ', ']\n[', ', ', ', ', ', ', ']\n[p, p, p, p, p, p, p, p]\n[t, h, b, k, q, b, h, t]";


            var row1 = new List<string>() { "T", "H", "B", "K", "Q", "B", "H", "T" };
            var row2 = new List<string>() { "P", "P", "P", "P", "P", "P", "P", "P" };
            var row3 = new List<string>() { "'", "'", "'", "'", "'", "'", "'", "'" };
            var row4 = new List<string>() { "'", "'", "'", "'", "'", "'", "'", "'" };
            var row5 = new List<string>() { "'", "'", "'", "'", "'", "'", "'", "'" };
            var row6 = new List<string>() { "'", "'", "'", "'", "'", "'", "'", "'" };
            var row7 = new List<string>() { "p", "p", "p", "p", "p", "p", "p", "p" };
            var row8 = new List<string>() { "t", "h", "b", "k", "q", "b", "h", "t" };








            boardArrayList.Add(row1);
            boardArrayList.Add(row2);
            boardArrayList.Add(row3);
            boardArrayList.Add(row4);
            boardArrayList.Add(row5);
            boardArrayList.Add(row6);
            boardArrayList.Add(row7);
            boardArrayList.Add(row8);


            /*var roww2 = boardArrayList[1];
            rad[0] = "'";

            var roww3 = boardArrayList[2];
            roww3[0] = "P";*/



            //Console.WriteLine(boardArrayList[0][1]);

            Console.WriteLine("╻━━━━━━━━━BLACK━━━━━━━━━━╻");

            foreach (var row in boardArrayList)
            {
                Console.Write("| ");
                foreach (var item in row)
                {
                    Console.Write(item);
                    Console.Write(" |");
                }
                Console.Write("\n");
            }
            Console.WriteLine("╹━━━━━━━━━WHITE━━━━━━━━━━╹");





            //DrawBoard();

            Console.WriteLine("\nWelcome to the chess game!\n");
            Console.WriteLine("\nDo you know the gamerules?\n");
            string input = Console.ReadLine().ToLower();

            // exempel input:
            /*

            a1 a5 -> flytta pjäsen på a1 till a5
            - om det går att flytta så gör vi det
            - om det inte går ?
                - 
            - om det inte finns en pjäs på a1 
                - 

             */
        
            if (input == "yes")
            {
                Console.WriteLine("\nThe game begins.");
            }

            else if (input == "no")
            {
                Console.WriteLine("\nGoogle them then.");
            }

                else
                {
                Console.WriteLine("\nAnswer yes / no");
                System.Environment.Exit(0);
            }

        
            //Input för position (från) t.ex. a2 
            Console.WriteLine("Enter the piece you want to move:");
                string input1 = Console.ReadLine();

                //Input för position (från) t.ex. a4
                Console.WriteLine("Enter the position you want to move the piece to:");
                string input2 = Console.ReadLine();
                
                //Definerar variabeln letter1
                char letter1 = input1[0];
                //Definerar variabeln letter2
                char letter2 = input2[0];


                //Definerar variabeln number1
                int number1 = Int32.Parse(input1[1] + "");
                //Definerar variabeln number1
                int number2 = Int32.Parse(input2[1] + "");

                //Writeline för att kolla värdet på number1
                Console.WriteLine("input1[1]: " + input1[1]);
                
                //Writeline för att kolla värdet på number2
                Console.WriteLine("input2[1]: " + input2[1]);
                
                //Writeline för att kolla värdet på letter
                Console.WriteLine("number1: " + number1);

                //Writeline för att kolla värdet på letter
                Console.WriteLine("number2: " + number2);

            //Används för att konvertera letter1 till ett nummer som definerar kollumn 
            int letterToIndex1 = ConvertLetterToIndex(letter2);
            //Används för att konvertera letter2 till ett nummer som definerar kollumn 
            int letterToIndex2 = ConvertLetterToIndex(letter2);

            //Konverterar number1 till rätt rad
            int index1 = 8 - number1;
            //Konverterar number1 till rätt rad
            int index2 = 8 - number2;

            //Writeline för att kolla värdet på det nya numret index1
            Console.WriteLine("index: " + index1);
            //Writeline för att kolla värdet på det nya numret index2
            Console.WriteLine("index: " + index2);

            //Rad defineras med hjälp av index1 och borderarraylist
            var rad1 = boardArrayList[index1];
            //Rad defineras med hjälp av index2 och borderarraylist
            var rad2 = boardArrayList[index2];


            var piece = rad1[letterToIndex2];
            //Ersätter pjäsens ursprungliga position och gör den blank
            rad1[letterToIndex1] = "'";
            //Byter ut den blanka tomma rutan mot pjäsen
            rad2[letterToIndex2] = piece;

            Console.WriteLine(piece);




            Console.WriteLine("╻━━━━━━━━━BLACK━━━━━━━━━━╻");

                foreach (var row in boardArrayList)
                {
                    Console.Write("| ");
                    foreach (var item in row)
                    {
                        Console.Write(item);
                        Console.Write(" |");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("╹━━━━━━━━━WHITE━━━━━━━━━━╹");

            }


            static int ConvertLetterToIndex(char letter)
            {
                // test
                if (letter == 'a')
                {
                    return 0;
                }
                else if (letter == 'b')
                {
                    return 1;
                }
                else if (letter == 'c')
                {
                    return 2;
                }
                else if (letter == 'd')
                {
                    return 3;
                }
                else if (letter == 'e')
                {
                    return 4;
                }
                else if (letter == 'f')
                {
                    return 5;
                }
                else if (letter == 'g')
                {
                    return 6;
                }
                else if (letter == 'h')
                {
                    return 7;
                }
                else
                {
                    return -1;
                }
            }
        }
    }









            /*
                MAP COPY
               ╻━━━━━━━━━━━━━BLACK━━━━━━━━━━━━━╻
             8 | T ┃ H ┃ B ┃ K ┃ Q ┃ B ┃ H ┃ T │
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             7 | P ┃ P ┃ P ┃ P ┃ P ┃ P ┃ P ┃ P │
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             6 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   │
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             5 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   │
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             4 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   | 
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             3 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   | 
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             2 │ p ┃ p ┃ p ┃ p ┃ p ┃ p ┃ p ┃ p | 
               ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃
             1 │ t ┃ h ┃ b ┃ k ┃ q ┃ b ┃ h ┃ t │ 
               ╹━━━━━━━━━━━━━WHITE━━━━━━━━━━━━━╹
                 a   b   c   d   e   f   g   h
            
            
                           Console.WriteLine("Chess is a game that is played on a board with 64 boxes and with 32 pieces. These pieces have different ways of moving around the board. Let's start with the simplest and weakest piece ♟ (pawn), there are 8 of them and they have the ability to move two cases forward on the first move and then one case forward for the rest of the game. The pawn takes out pieces diagonaly. Then we got the ♜ (tower), that moves horizontly and verticaly and has no limit on how long it can move. ");


          
             */

/*
        }

        static void DrawBoard()
        {
            Console.WriteLine("  ╻━━━━━━━━━━━━━BLACK━━━━━━━━━━━━━╻");
            Console.WriteLine("8 | arr[0][0] ┃ H ┃ B ┃ K ┃ Q ┃ B ┃ H ┃ T │");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("7 | P ┃ P ┃ P ┃ P ┃ P ┃ P ┃ P ┃ P │");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("6 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   │");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("5 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   │");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("4 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   |");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("3 |   ┃   ┃   ┃   ┃   ┃   ┃   ┃   |");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("2 │ p ┃ p ┃ p ┃ p ┃ p ┃ p ┃ p ┃ p |");
            Console.WriteLine("  ┃━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┃");
            Console.WriteLine("1 │ t ┃ h ┃ b ┃ k ┃ q ┃ b ┃ h ┃ t │");
            Console.WriteLine("  ╹━━━━━━━━━━━━━WHITE━━━━━━━━━━━━━╹");
            Console.WriteLine("    a   b   c   d   e   f   g   h  ");
        }
    }
}
*/