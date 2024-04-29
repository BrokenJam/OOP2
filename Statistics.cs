using System;

public class Statistics
{
    public void StatisticsMethod(int statSevenOutPlayed, int statSevenOutRolls, int statThreeOrMorePlayed, List<int> statThreeOrMore)
	{
        Console.WriteLine($"Sevens Out Stats: \nTimes Played: {statSevenOutPlayed} \nTotal Times Dice Rolled: {statSevenOutRolls}");
        Console.WriteLine($"\nThree Or More Stats: \nTimes Played: {statThreeOrMorePlayed} \nTotal Times Dice Rolled: {statThreeOrMore[1]} \nTotal Score Accumulated: {statThreeOrMore[0]}");
    }
}
