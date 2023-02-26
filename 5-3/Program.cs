Console.Clear();

double[] array = FillArray(5);

Console.WriteLine($"В массиве: [{string.Join("; ", array)}] разница между min и max {GetDifferenceBetweenMinAndMaxByArray(array)}");

double[] FillArray(int size)
{
  double[] result = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < result.Length; i++)
  {
    result[i] = rnd.Next(1, 1000) + rnd.NextDouble();
  }
  return result;
}

double GetDifferenceBetweenMinAndMaxByArray(double[] array)
{
  double min = array[0];
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
    }
    if (array[i] > max)
    {
      max = array[i];
    }
  }
  double result = max - min;
  Console.WriteLine($"Max: {max}");
  Console.WriteLine($"Min: {min}");
  return result;
}