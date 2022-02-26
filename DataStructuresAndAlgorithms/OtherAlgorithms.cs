public class OtherAlgorithms
{
    public bool HasDuplicateValue(int[] array)
    {
        var existingNumbers = new List<int>();
        
        foreach (var element in array)
        {
            if (existingNumbers[element] == 1)
                return true;
            existingNumbers[element] = 1;
        }

        return false;
    }
    
    public List<int> Intersection(int[] firstArray, int[] secondArray)
    {
        var result = new List<int>();

        for (var i = 0; i < firstArray.Length; i++)
        {
            for (var j = 0; j < secondArray.Length; j++)
            {
                if (firstArray[i] == secondArray[j])
                {
                    result.Add(firstArray[i]);
                    break;
                }
            }
        }

        return result;
    }
    
    
    public bool IsSubset<T>(T[] array1, T[] array2) 
        where T : struct
    {
        T[] largerArray;
        T[] smallerArray;
        var dictionary = new Dictionary<T, bool>();
        
        // Determine which array is smaller
        if (array1.Length > array2.Length)
        {
            largerArray = array1;
            smallerArray = array2;
        }
        else
        {
            largerArray = array2;
            smallerArray = array1;
        }
        
        // Store all items from largerArray inside dictionary
        foreach (var value in largerArray)
        {
            dictionary[value] = true;
        }
        
        // Iterate through each item in smallerArray and return false
        // if we encounter an item not inside the dictionary
        foreach (var value in smallerArray)
        {
            if (!dictionary.ContainsKey(value)) return false;
        }
        
        // Returns true if all items in smallerArray are not contained
        // within largerArray
        return true;
    }
}