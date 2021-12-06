Console.WriteLine("Welcome to my Homework program");

bool continueSoftware = true;
while(continueSoftware)
{
    Console.WriteLine("Please select the Lesson number. Then you will be asked to select the subtask number. If you want to exit, enter 'exit'");
    Console.WriteLine();
    Console.WriteLine("1. Lesson 1 - Block schemes, Asymptotic complexity, Recursions");
    //Console.WriteLine("2. Lesson 2 - Block schemes, Asymptotic complexity, Recursions");
    //Console.WriteLine("3. Lesson 3 - Block schemes, Asymptotic complexity, Recursions");
    //Console.WriteLine("4. Lesson 4 - Block schemes, Asymptotic complexity, Recursions");
    //Console.WriteLine("5. Lesson 5 - Block schemes, Asymptotic complexity, Recursions");
    Console.WriteLine();
    Console.Write("Lesson number: ");
    string lessonNumber = Console.ReadLine();

    switch (lessonNumber)
    {
        case "1": Lesson1 l = new Lesson1();
            break;
        //case "2":
        //    Lesson2 l = new Lesson2();
        //    break;
        //case "3":
        //    Lesson3 l = new Lesson3();
        //    break;
        //case "4":
        //    Lesson4 l = new Lesson4();
        //    break;
        //case "5":
        //    Lesson5 l = new Lesson5();
        //    break;
        case "exit": continueSoftware = false;
            break;
        default: 
            Console.WriteLine("You have entered incorrect lesson number. Please either enter lesson number, either enter 'exit' to exit.");
            Console.WriteLine("Now press ENTER to continue...");
            Console.ReadLine();
            break;
    }
    Console.WriteLine("To continue press ENTER...");
    Console.ReadLine();
    Console.Clear();
}


