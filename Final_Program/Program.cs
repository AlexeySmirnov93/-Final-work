int GetArrayFilling(string[] inputArray)
{
   int count = 0;

   for(int i = 0; i < inputArray.Length; i++)
   {     
        Console.WriteLine($"Введите значение № {i+1}: ");
        inputArray[i] =  Console.ReadLine()!;
        
        if(inputArray[i].Length <= 3)
        {
            count++;
        }     
        
    }
    return count;
}

void GetArraySorting(string[] inputArray, string[] outputArray)
{  
   int j = 0;

   for (int i = 0; i < inputArray.Length; i++)
   {
        if (inputArray[i].Length <= 3)
        {
           outputArray[j] = inputArray[i];
           j++;
        }

    }

}

void PrintArraiy(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i > 0)
        {
            Console.Write("; ");
        }
        Console.Write(array[i]);
    }
}

Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());

string[] inputArray = new string[size];
int count = GetArrayFilling(inputArray);

string[] outputArray = new string[count];
GetArraySorting(inputArray,outputArray);

PrintArraiy(inputArray);
Console.Write(" -> ");
PrintArraiy(outputArray);
