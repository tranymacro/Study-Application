using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Terms
{
    class Program

    {

        public static string [] testQuestins = new string[15];
        public static string [] testAnswer = new string [15];
        public static string [] userAnswer = new string [15];

        private static void Main(string[] args)

            
        {

            WriteLine("Terms game\nBy Walter Cooper\nPress enter");
            ReadLine();

            WriteLine("Hello and welcome player to my C# terms game, in my game you will have to find the right answer to the given Qusestion\nEasy enough rignt\n" +
             "To start press enter");
            ReadLine();


            int choose;

            WriteLine("Ok before you start the game let me gave you a few words of advice,\neach question in the game is answer with a term");


            WriteLine("For example" +
                "\nQusestion1: What language is the file name program.cs written in?\n The term will Answer: C#\nPress enter to continue");

            ReadLine();


            WriteLine("There are 15 qusestion and 15 terms, the terms are" +
                "\nStatement" +
                "\nArray" +
                "\nNamespace" +
                "\nProgram" +
                "\nValrible" +
                "\nMethod" +
                "\nC#" +
                "\nIf Statement" +
                "\nObject" +
                "\nConsole Application" +
                "\nWhile Loop" +
                "\nvoid" +
                "\nswitch" +
                "\nstring" +
                "\nidentifier");


            ReadLine();

            WriteLine("At the end of the game you will see you results,If you are ready to start enter 1 two time or press 2 to end the game");


            _ = Convert.ToInt32(ReadLine());

            try
            {
                choose = Convert.ToInt32(ReadLine());

                switch (choose)
                {


                    case 1:
                        Clear();
                        setTest();

                        break;

                    case 2:


                       
                Environment.Exit(0);
                        break;

                    default:
                        WriteLine("Sorry can't do that ");


                        break;

                }

            }
            catch
            {
                WriteLine("Sorry that can't not be done");
                ReadLine();
            }







        }
        private static void setTest()
        {
            string question1, question2, question3, question4, question5, question6, question7, question8, question9, question10, question11, question12, question13, question14, question15;




            WriteLine("Here are the terms to help" +
              "\nStatement" +
                "\nArray" +
                "\nNamespace" +
                "\nProgram" +
                "\nValrible" +
                "\nMethod" +
                "\nC#" +
                "\nIf Statement" +
                "\nObject" +
                "\nConsole Application" +
                "\nWhile Loop" +
                "\nvoid" +
                "\nswitch" +
                "\nstring" +
                "\nidentifier");



            Write("\n What can help you store multiple values in one single variable? :");
            question1 = ReadLine();

            Write("\n The struct keyword is use to create a what in C#? :");
            question2 = ReadLine();

            Write("\n In C# what is use to organize classes? :");
            question3 = ReadLine();

            Write("\n What is use to contains a series of statments in C3? ?:");
            question4 = ReadLine();

            Write("\n In c# instances are sometime called what? :");
            question5 = ReadLine();

            Write("\n What is a Console application called? :");
            question6 = ReadLine();

            Write("\n What language is the file name Gameproject.cs written in? :");
            question7 = ReadLine();

            Write("\n What is it called in C# when something loop through\na blcok of code into a specified condition is True? :");
            question8 = ReadLine();

            Write("\n What is the name giving for the container\n that storing data values in C#? :");
            question9 = ReadLine();

            Write("\n What is a program sometimes called? :");
            question10 = ReadLine();

            Write("\n What can you use as a return type of a method?:");
            question11 = ReadLine();

            Write("\n What statement allows a variable to be tested for equality against a list of values? :");
            question12 = ReadLine();

            Write("\n What is use to sequential collection of characters that is used to represent text? :");
            question13 = ReadLine();

            Write("\n What statement is use to identifies which statement to run based on the value of a Boolean expression? :");
            question14 = ReadLine();

            Write("\n What is it called when you assign a name to a type? What statement is use to identifies which statement to run based on the value of a Boolean expression? :");
            question15 = ReadLine();

            WriteLine("YOUR ANSWERS");



            testQuestins[0] = question1;
            testQuestins[1] = question2;
            testQuestins[2] = question3;
            testQuestins[3] = question4;
            testQuestins[4] = question5;
            testQuestins[5] = question6;
            testQuestins[6] = question7;
            testQuestins[7] = question8;
            testQuestins[8] = question9;
            testQuestins[9] = question10;
            testQuestins[10] = question11;
            testQuestins[11] = question12;
            testQuestins[12] = question13;
            testQuestins[13] = question14;
            testQuestins[14] = question15;


            WriteLine("Test question1: " + testQuestins[0] + "\nquestion2" + testQuestins[1]
                + "\nquestion3" + testQuestins[2]
                + "\nquestion4" + testQuestins[3]
                + "\nquestion5" + testQuestins[4]
                + "\nquestion6" + testQuestins[5]
                + "\nquestion7" + testQuestins[6]
                + "\nquestion8" + testQuestins[7]
                + "\nquestion9" + testQuestins[8]
                + "\nquestion10" + testQuestins[9]
                + "\nquestion11" + testQuestins[10]
                + "\nquestion12" + testQuestins[11]
                + "\nquestion13" + testQuestins[12]
                + "\nquestion14" + testQuestins[13]
                + "\nquestion15" + testQuestins[14]);

            ReadLine();

            testQuestins[0] = question1;
            testQuestins[1] = question2;
            testQuestins[2] = question3;
            testQuestins[3] = question4;
            testQuestins[4] = question5;
            testQuestins[5] = question6;
            testQuestins[6] = question7;
            testQuestins[7] = question8;
            testQuestins[8] = question9;
            testQuestins[9] = question10;
            testQuestins[10] = question11;
            testQuestins[11] = question12;
            testQuestins[12] = question13;
            testQuestins[13] = question14;
            testQuestins[14] = question15;




            createAnswers();




        }




        private static void createAnswers()
        {
            string answerQ1, answerQ2, answerQ3, answerQ4, answerQ5, answerQ6, answerQ7, answerQ8, answerQ9, answerQ10, answerQ11, answerQ12, answerQ13, answerQ14, answerQ15;


            WriteLine("\n\n=================Show test answers===========================");


            Write("\n1 is Arrays. \n" );
            answerQ1 = ReadLine();

            Write("\n2 is Structure. \n");
            answerQ2 = ReadLine();

            Write("\n3 is Namespace. \n");
            answerQ3 = ReadLine();

            Write("\n4 is Method. \n");
            answerQ4 = ReadLine();

            Write("\n5 is Objects.\n");
            answerQ5 = ReadLine();

            Write("\n6 is Program. \n");
            answerQ6 = ReadLine();

            Write("\n7 is C#\n");
            answerQ7 = ReadLine();

            Write("\n8 is While Loop. \n");
            answerQ8 = ReadLine();

            Write("\n9 is Valrible. \n");
            answerQ9 = ReadLine();

            Write("\n10 is Console application. \n");
            answerQ10 = ReadLine();

            Write("\n11 Void. \n");
            answerQ11 = ReadLine();

            Write("\n12 switch. \n");
            answerQ12 = ReadLine();

            Write("\n13  string. \n");
            answerQ13 = ReadLine();

            Write("\n14 If Statement. \n");
            answerQ14 = ReadLine();

            Write("\n15 identifier  \n");
            answerQ15= ReadLine();

            WriteLine("YOUR ANSWERS");


            testAnswer[0] = answerQ1;
            testAnswer[1] = answerQ2;
            testAnswer[2] = answerQ3;
            testAnswer[3] = answerQ4;
            testAnswer[4] = answerQ5;
            testAnswer[5] = answerQ6;
            testAnswer[6] = answerQ7;
            testAnswer[7] = answerQ8;
            testAnswer[8] = answerQ9;
            testAnswer[9] = answerQ10;
            testAnswer[10] = answerQ11;
            testAnswer[11] = answerQ12;
            testAnswer[12] = answerQ13;
            testAnswer[13] = answerQ14;
            testAnswer[14] = answerQ15;


            Clear();
            int choose;

            Write("press [1] to end test or press [2] to rest the game.");
            choose = Convert.ToInt32(ReadLine());


            switch (choose)

            {
                case 1:

                    Environment.Exit(0);


                    break;

                case 2:

                    

                    while (true)
                    {

                        setTest();

                       
                        if (!Console.ReadLine().StartsWith("2", StringComparison.OrdinalIgnoreCase)) break;
                    }



                    break;

                default:


                    break;

            }



        }

        private static void playerTakequiz()
        {
            string playerAnwserQ1, playerAnwserQ2, playerAnwserQ3, playerAnwserQ4, playerAnwserQ5, 
                playerAnwserQ6, playerAnwserQ7, playerAnwserQ8, playerAnwserQ9, playerAnwserQ10, 
                playerAnwserQ11, playerAnwserQ12, playerAnwserQ13, playerAnwserQ14, playerAnwserQ15;


            Write("Enter your answer: ");
            playerAnwserQ1 = ReadLine();

            Write("\nQuestion 2: " + testQuestins[1]);
            Write("Enter your answer: ");
            playerAnwserQ2 = ReadLine();

            Write("\nQuestion 3 " + testQuestins[2]);
            Write("Enter your answer: ");
            playerAnwserQ3 = ReadLine();

            Write("\nQuestion 4: " + testQuestins[3]);
            Write("Enter your answer: ");
            playerAnwserQ4 = ReadLine();

            Write("\nQuestion 5: " + testQuestins[4]);
            Write("Enter your answer: ");
            playerAnwserQ5 = ReadLine();

            Write("\nQuestion 6: " + testQuestins[5]);
            Write("Enter your answer: ");
            playerAnwserQ6 = ReadLine();

            Write("\nQuestion 7: " + testQuestins[6]);
            Write("Enter your answer: ");
            playerAnwserQ7 = ReadLine();

            Write("\nQuestion 8: " + testQuestins[7]);
            Write("Enter your answer: ");
            playerAnwserQ8 = ReadLine();

            Write("\nQuestion 9: " + testQuestins[8]);
            Write("Enter your answer: ");
            playerAnwserQ9 = ReadLine();

            Write("\nQuestion 10: " + testQuestins[9]);
            Write("Enter your answer: ");
            playerAnwserQ10 = ReadLine();

            Write("\nQuestion 11: " + testQuestins[10]);
            Write("Enter your answer: ");
            playerAnwserQ11 = ReadLine();

            Write("\nQuestion 12: " + testQuestins[11]);
            Write("Enter your answer: ");
            playerAnwserQ12 = ReadLine();

            Write("\nQuestion 13: " + testQuestins[12]);
            Write("Enter your answer: ");
            playerAnwserQ13 = ReadLine();

            Write("\nQuestion 14: " + testQuestins[13]);
            Write("Enter your answer: ");
            playerAnwserQ14 = ReadLine();

            Write("\nQuestion 15: " + testQuestins[14]);
            Write("Enter your answer: ");
            playerAnwserQ15 = ReadLine();


            testAnswer[0] = playerAnwserQ1;
            testAnswer[1] = playerAnwserQ2;
            testAnswer[2] = playerAnwserQ3;
            testAnswer[3] = playerAnwserQ4;
            testAnswer[4] = playerAnwserQ5;
            testAnswer[5] = playerAnwserQ6;
            testAnswer[6] = playerAnwserQ7;
            testAnswer[7] = playerAnwserQ8;
            testAnswer[8] = playerAnwserQ9;
            testAnswer[9] = playerAnwserQ10;
            testAnswer[10] = playerAnwserQ11;
            testAnswer[11] = playerAnwserQ12;
            testAnswer[12] = playerAnwserQ13;
            testAnswer[13] = playerAnwserQ14;
            testAnswer[14] = playerAnwserQ15;


            WriteLine("Test Anwer Here: " + testAnswer[0] +
                "\nAnwers 2:" + testAnswer[1] +
                "\nAnwers 3:" + testAnswer[2] +
                "\nAnwers 4:" + testAnswer[3] +
                "\nAnwers 5:" + testAnswer[4] +
                "\nAnwers 6:" + testAnswer[5] +
                "\nAnwers 7:" + testAnswer[6] +
                "\nAnwers 8:" + testAnswer[7] +
                "\nAnwers 9:" + testAnswer[8] +
                "\nAnwers 9:" + testAnswer[9] +
                "\nAnwers 9:" + testAnswer[10] +
                "\nAnwers 9:" + testAnswer[11] +
                "\nAnwers 9:" + testAnswer[12] +
                "\nAnwers 9:" + testAnswer[13] +
                "\nAnwers 10:" + testAnswer[14]);

            ReadLine();
           
            





        }
    }

}


