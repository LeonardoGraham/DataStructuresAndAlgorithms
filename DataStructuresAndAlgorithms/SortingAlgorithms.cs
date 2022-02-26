public class SortingAlgorithms
{
    public int[] BubbleSort(int[] array)
    {
        var lastIndexSorted = array.Length - 1;
        var isSorted = false;

        while (!isSorted)
        {
            isSorted = true;
            for (var i = 0; i < lastIndexSorted; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    isSorted = false;
                }

                lastIndexSorted -= 1;
            }
        }

        return array;
    }

    public int[] SelectionSort(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var lowestNumberIndex = i;
            
            for (var j = i + 1; j < array.Length; i++)
            {
                if (array[j] < array[lowestNumberIndex])
                {
                    lowestNumberIndex = j;
                }
            }

            if (lowestNumberIndex != i)
            {
                (array[i], array[lowestNumberIndex]) = (array[lowestNumberIndex], array[i]);
            }
        }

        return array;
    }

    public int[] InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var temp = array[i];
            var position = i - 1;

            while (position >= 0)
            {
                if (array[position] > temp)
                {
                    array[position + 1] = array[position];
                    position -= 1;
                }
                else
                {
                    break;
                }
            }

            array[position + 1] = temp;
        }

        return array;
    }
}