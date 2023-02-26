Console.Clear();

int[] array = FillArray(10);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}] четных элементов {GetCountEvenNumbersByArray(array)}");

int[] FillArray(int size)
{
  int[] result = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < result.Length; i++)
  {
    result[i] = rnd.Next(100, 1000);
  }
  return result;
}

int GetCountEvenNumbersByArray(int[] array)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] % 10;
    if (array[i] % 2 == 0 || array[i] == 0)
      result++;
  }
  return result;
}
