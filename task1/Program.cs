// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] array = new int [4] {-4, -8, 8, 2};
int [] newArray = ChangeElementOfArrayOnOpposite(array);
PrintArray (newArray);

int [] ChangeElementOfArrayOnOpposite(int [] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        if (array[index] < 0)
        {
            array[index] = array[index] - array[index] * 2;
        }
        else
        {
            array[index] = array[index] - array[index] * 2;
        }        
    }
    return array;
}

void PrintArray (int [] newArray)
{
    string messsage = string.Join (", ", array);
    Console.WriteLine (messsage);
}
    
