// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да
int [] array = new int [5] {6, 7, 19, 345, 3};
Console.WriteLine ("введите число, которое требуется найти в массиве");
bool isParsedNumber = int.TryParse(Console.ReadLine(), out int Number);
IsThereElementInArray(array, Number);


if (!isParsedNumber)
{
    Console.WriteLine("Должно быть введено число");
    return;
}

void IsThereElementInArray(int [] array, int Number)
{
    string answer = "нет";
    for (int index = 0; index < array.Length; index ++)
    {
        
        if (array[index] == Number)
        {
            answer = "да";
            break;       
        }                                                    
    }
    Console.WriteLine (answer);        
}
