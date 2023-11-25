// Задайте произвольный массив, выведите его элементы начиная с конца.


Console.WriteLine("Задайте размер массива");
int number = Convert.ToInt32(Console.ReadLine());


int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(1, 100);
     Console.Write(array[i] + " ");
}

Console.WriteLine(" - Заданый массив");

void FunctionRevers(int[] array, int i = 0) {
     if (i != array.Length)
      {
         FunctionRevers(array, i + 1);
         Console.Write($"{array[i]} ");
      }
}

FunctionRevers(array);
Console.WriteLine(" - Перевёрнутый массив");
 