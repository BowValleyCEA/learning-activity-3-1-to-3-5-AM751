//LA 3.5:

using System;
 

class DonkeyKongScore
{
    static void Main()
    {
        //List of Donkey Kong Scores:

        List<int> highScores = new List<int> { 1000000, 95000, 110000, 120000, 102000 };


        //Calculaltion of Average Scores:

        double averageScore = highScores.Average();

        //Calculation of Standard deviation:

        double sumOfSquares = highScores.Select(score => Math.Pow(score - averageScore, 2)).Sum();

        double standardDeviation = Math.Sqrt(sumOfSquares / highScores.Count);

        //The output:

        Console.WriteLine($"The Average Score: {averageScore}");

        //Average score as an integer or double:
        if (averageScore % 1 == 0)
        //If the Avg is Whole number
        {
            Console.WriteLine($"Average Score (Integer): {(int)averageScore}");
        }

        else
        {
            Console.WriteLine($"Avergae Score (Double): {averageScore}");
        }

        Console.WriteLine($"standardDeviation: {standardDeviation}");
    }

}
