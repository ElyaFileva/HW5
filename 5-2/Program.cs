Console.Clear();

int[] array = FillArray(3);

Console.WriteLine($"В массиве: [{string.Join(" ", array)}] сумма элементов на нечетной позиции {GetSumOddPositionByArray(array)}");

int[] FillArray(int size)
{
  int[] result = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < result.Length; i++)
  {
    result[i] = rnd.Next(-100, 101);
  }
  return result;
}

int GetSumOddPositionByArray(int[] array)
{
  int result = 0;
  for (int i = 1; i < array.Length; i += 2)
  {
    result += array[i];
  }
  return result;
}
