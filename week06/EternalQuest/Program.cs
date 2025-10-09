using System;

/*
i added a _completedTimes atribute in eternal goals to add a bonus each 5 times of completing a goal in the logic of record events 
i implemented the sleep method to show messages when lopading files and when saving files 
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}