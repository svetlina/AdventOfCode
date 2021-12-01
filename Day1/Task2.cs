namespace Day1;

static class Task2
{
    private const string InputFileName = @"Input.txt";
     
    public static void PrintResult()
    {
        int result = GetCountThreeMeasurementsWindow(GetMeasurements());
        Console.WriteLine($"Three window: {result}.");
    }

    private static int[] GetMeasurements()
    {
        int linesCounter = 0;

        string[] lines = File.ReadAllLines(InputFileName);
        int[] measurements = new int[lines.Length];

        foreach (string line in lines)
        {
            measurements[linesCounter] = Int32.Parse(line);

            linesCounter++;
        }

        return measurements;
    }

    private static int GetCountThreeMeasurementsWindow(int[] measurements)
    {
        int largerMeasurementCounter = 0;

        int[] threeMeasurements = new int[measurements.Length];
        int j = 0;

        for (int i=0; i<measurements.Length-2; i++)
        {
            threeMeasurements[j++] = measurements[i] + measurements[i+1] + measurements[i+2];

            if (j > 1 && (threeMeasurements[j - 1] > threeMeasurements[j - 2]))
                largerMeasurementCounter++;
        }

        return largerMeasurementCounter;
    }
}
