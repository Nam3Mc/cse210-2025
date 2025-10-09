using System;

/*
i added a _CreatedAt atribute in goals calss to keep record of the lengh of completion for some goals when needed
i added a _completedTimes atribute in eternal goals to add a bonus each 5 times of completing a goal in the logic of record events 
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}