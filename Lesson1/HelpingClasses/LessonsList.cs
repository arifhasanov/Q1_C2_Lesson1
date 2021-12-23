class LessonsList
{
    List<string> LessonsListArray = new List<string>();
    public LessonsList()
    {
        LessonsListArray.Add("1. Lesson 1 - Block schemes, Asymptotic complexity, Recursions");
        LessonsListArray.Add("2. Lesson 2 - Massives, Lists, Search");
        LessonsListArray.Add("3. Lesson 3 - Class, Structures, Distances");
        LessonsListArray.Add("4. Lesson 4 - Binary search tree");
        LessonsListArray.Add("5. Lesson 5 - Binary search tree, Width search and Depth search");
    }

    public void ShowWelcomeAndList()
    {
        Console.WriteLine("Please select the Lesson number. Then you will be asked to select the subtask number. If you want to exit, enter 'exit'");
        Console.WriteLine();
        
        for (int i = 0; i < LessonsListArray.Count; i++)
        {
            Console.WriteLine(LessonsListArray[i]);
        }
        Console.WriteLine();
        Console.Write("Lesson number: ");
    }
}
