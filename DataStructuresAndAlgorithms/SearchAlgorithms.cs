public class SearchAlgorithms
{
    public int LinearSearch(int[] array, int searchValue)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == searchValue)
                return i;
        }

        return -1;
    }

    public int BinarySearch(int[] array, int searchValue)
    {
        int lowerBound = 0;
        int upperBound = array.Length - 1;

        while (lowerBound <= upperBound)
        {
            var midPoint = (upperBound + lowerBound) / 2;
            var valueAtMidPoint = array[midPoint];

            if (searchValue == valueAtMidPoint)
                return midPoint;
            if (searchValue < valueAtMidPoint)
                upperBound = midPoint - 1;
            else
                lowerBound = midPoint + 1;
        }

        return -1;
    }
}