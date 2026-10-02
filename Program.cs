//CABASALFTE_LabExam
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        int code = 0;
        while (code != 7)
        {
            Console.WriteLine("Welcome to my ARRAYLIST PROGRAM");
            Console.WriteLine("Choose what you want to do?");
            Console.WriteLine("1 - Record Scores");
            Console.WriteLine("2 - Show Participant Scores ");
            Console.WriteLine("3 - Show Ranking");
            Console.WriteLine("4 - EXIT");
            Console.Write("Enter code: ");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (code)
            {
                case 1:
                    Console.WriteLine("Participants:");
                    string newData = Console.ReadLine();
                    int[,] scores = new int[3, 3];
                    int[] totalscores = new int[3];

                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.WriteLine("Score:");
                            Console.Write("Round " + (char) +(col) + (col + 1) + " : ");
                            scores[row, col] = Convert.ToInt32(Console.ReadLine());
                            totalscores[col] += scores[row, col];
                        }
                    }
                    Console.WriteLine();

                    for (int col = 0; col < 3; col++)
                    {
                        Console.WriteLine($"Total scores {(char)(col)}: {totalscores[col]}");
                    }
                    list.Add(newData);
                    Console.WriteLine("New data has been added!");

                    break;

                case 2:
                    Console.Write("Enter index location: ");
                    int insertIndex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter data to be inserted: ");
                    string insertData = Console.ReadLine();

                    if (insertIndex >= 0 && insertIndex <= list.Count)
                    {
                        list.Insert(insertIndex, insertData);
                        Console.WriteLine("Data has been inserted!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index location!");
                    }
                    break;

                case 3:
                    Console.Write("Enter index location: ");
                    int updateIndex = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter data to be updated: ");
                    string updateData = Console.ReadLine();

                    if (updateIndex >= 0 && updateIndex < list.Count)
                    {
                        list[updateIndex] = updateData;
                        Console.WriteLine("Data has been updated!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index location!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid code! Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}