public class Lesson3HelpingMethods
{
    double PointDistance(PointStructDouble pointOne, PointStructDouble pointTwo)
    {
        double x = pointOne.X - pointTwo.X;
        double y = pointOne.Y - pointTwo.Y;
        return MathF.Sqrt((float)((x * x) + (y * y)));
    }

    double PointDistance(PointClassDouble pointOne, PointClassDouble pointTwo)
    {
        double x = pointOne.X - pointTwo.X;
        double y = pointOne.Y - pointTwo.Y;
        return MathF.Sqrt((float)((x * x) + (y * y)));
    }

    [Benchmark]
    public void GenerateStructRandomPoints()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int randomX = random.Next(10, 100);
            int randomY = random.Next(10, 100);
            PointStructDouble firstPoint = new PointStructDouble();
            firstPoint.X = randomX;
            firstPoint.Y = randomY;

            randomX = random.Next(10, 100);
            randomY = random.Next(10, 100);
            PointStructDouble secondPoint = new PointStructDouble();
            secondPoint.X = randomX;
            secondPoint.Y = randomY;

            double distance = Math.Round(PointDistance(firstPoint, secondPoint), 2);
            Console.WriteLine($"{i + 1}. Point 1 - X: {firstPoint.X}, Y: {firstPoint.Y} | Point 2 - X: {secondPoint.X}, Y: {secondPoint.Y} | Distance: {distance}");
        }
    }

    [Benchmark]
    public void GenerateClassRandomPoints()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int randomX = random.Next(10, 100);
            int randomY = random.Next(10, 100);
            PointClassDouble firstPoint = new PointClassDouble();
            firstPoint.X = randomX;
            firstPoint.Y = randomY;

            randomX = random.Next(10, 100);
            randomY = random.Next(10, 100);
            PointClassDouble secondPoint = new PointClassDouble();
            secondPoint.X = randomX;
            secondPoint.Y = randomY;

            double distance = Math.Round(PointDistance(firstPoint, secondPoint), 2);
            Console.WriteLine($"{i + 1}. Point 1 - X: {firstPoint.X}, Y: {firstPoint.Y} | Point 2 - X: {secondPoint.X}, Y: {secondPoint.Y} | Distance: {distance}");
        }
    }
}
