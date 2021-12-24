Console.WriteLine("Welcome to my Homework program");

bool continueSoftware = true;
while(continueSoftware)
{
    LessonsList list = new LessonsList();
    list.ShowWelcomeAndList();
    switch (Console.ReadLine())
    {
        case "1": 
            Lesson1 l1 = new Lesson1();
            break;
        case "2":
            Lesson2 l2 = new Lesson2();
            break;
        case "3":
            Lesson3 l3 = new Lesson3();
            l3.Example();
            break;
        case "4":
            Lesson4 l4 = new Lesson4();
            l4.Example();
            break;
        case "5":
            Lesson5 l5 = new Lesson5();
            l5.Example();
            break;
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


