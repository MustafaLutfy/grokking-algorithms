public class numOfSteps
{
    public static int CountSteps()
    {
        //This code count the Maximum number of steps needed to find a value and return it's index using Binary Search algorithem
        int wordsNumber = 128;
        int countSteps = 0;

        while(wordsNumber > 1 || wordsNumber != 1)
        {
            wordsNumber = wordsNumber/2;
            countSteps++;
        }
       
        return countSteps;

    }
}

