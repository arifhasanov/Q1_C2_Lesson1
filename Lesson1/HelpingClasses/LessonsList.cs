class LessonsList
{
    public string[] LessonsListArray { get; private set; }
    public LessonsList()
    {
        LessonsListArray.Append("1. Lesson 1 - Block schemes, Asymptotic complexity, Recursions");
        LessonsListArray.Append("2. Lesson 2 - Massives, Lists, Search");
        LessonsListArray.Append("3. Lesson 3 - Class, Structures, Distances");
        LessonsListArray.Append("4. Lesson 4 - Trees, hash tables");
    }

    public void ShowWelcomeAndList()
    {
        Console.WriteLine("Please select the Lesson number. Then you will be asked to select the subtask number. If you want to exit, enter 'exit'");
        Console.WriteLine();
        
        for (int i = 0; i < LessonsListArray.Length; i++)
        {
            Console.WriteLine(LessonsListArray[i]);
        }
        Console.WriteLine();
        Console.Write("Lesson number: ");
    }
}
