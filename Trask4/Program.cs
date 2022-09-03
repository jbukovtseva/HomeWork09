int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

// int i = 101010;
// Console.WriteLine(Conversion(i));

int[] arrayResult = SelectionNumber(data,info);
OutputArrayString(arrayResult);



int[] SelectionNumber(int[] number, int[] count)
{
    int[] result = new int[count.Length];
    
    int k = 0;
    for (int i = 0; i < count.Length; i++)
    {
        string temp = String.Empty;
        for (int j = 0; j < count[i]; j++)
        {
            temp = temp + number[k];
            k++;
            
        }
        result[i] = Conversion(int.Parse(temp));
    }
    return result;
}

int Conversion(int number, int degree = 0)
{
    if (number > 0)
    {
        return number % 10 * Convert.ToInt32(Math.Pow(2, degree)) + Conversion(number /= 10, ++degree);

    }
    return 0;
    
}

void OutputArrayString(int[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"{stringArray}");
}