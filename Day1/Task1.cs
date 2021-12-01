namespace Day1;

static class Task1
{
    private const string InputFileName = @"Input.txt";

    private static int linesCounter = 0;
    private static int largerMeasurementsCounter = 0;
    private static int? previous = null;

    public static void PrintResult()
    {
        foreach (string line in File.ReadLines(InputFileName))
        {
            int current = Int32.Parse(line);

            bool isLarger = linesCounter > 0 && current > previous;

            if (isLarger)
                largerMeasurementsCounter++;

            linesCounter++;
            previous = current;
        }

        Console.WriteLine($"Single window: {largerMeasurementsCounter}.");
    }
}
