#region Q1
static int Sum111(int k)//int[] a, int[] b)
{

  int last = 0;
  int sum = 0;
  for (int i = 0; i < k; i++)
  {
    last = last * 10 + 1;
    sum += last;
    //Console.WriteLine(last);
  }
  return sum;
}
Console.WriteLine(Sum111(4));
#endregion
#region Q2
int[] a = { 1, 2, 3, 4, 5, 6 };
int[] b = { 1, 2, 3, 4, 5 };
for (int i = 0; i < a.Length - 1; i++)
{
  if ((a[i] + a[i + 1]) != b[i])
    b[i] = -1;
}
#endregion
#region Q3
static void Mofa(int[] arr)
{
  bool found = false;
  int count = 0;
  foreach (int num in arr)
  {
    if (num < 0)
      count++;
    else if (count != 0)
    {
      found = true;
      Console.Write(count + " ");
      count = 0;
    }
  }
  if (!found)
    Console.WriteLine(0);
  else if (count != 0)
    Console.WriteLine(count);
}

static string Mofa2(int[] arr)
{
  int counter = 0;
  string final = "";
  for (int i = 0; i < arr.Length; i++)
  {
    while (i < arr.Length && arr[i] < 0)
    {
      counter++;
      i++;
    }
    if (counter > 0)
    {
      final += counter + ",";
      counter = 0;
    }
  }
  if (final != "")
    return final;
  return "0";
}
static void Mofa3(int[] arr)
{
  int counter = 0, check = 0, zeroNegative = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < 0)
    {
      zeroNegative++;
      counter++;
      check = 0;
    }
    else
      check++;
    if (check > 0 && counter > 0) //&& not ||
    {
      Console.Write(counter + " ");
      counter = 0;
    }
  }
  if (zeroNegative == 0)
    Console.WriteLine(zeroNegative);
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nMofa - Q3");
int[] nums2 = { 6, 6, -3, -2, 9, 9, -1, -2, -3, -4, -5, 8, 9, 0, 12, 9, -3, 8, 9, -1, -2, -9 };
Mofa(nums2);
Console.WriteLine("\n" + Mofa2(nums2));
Mofa3(nums2);

#endregion
#region Q4
static int CancelMax(int[] arr)
{
  int inxMax = 0;
  for (int i = 1; i < arr.Length; i++)
    if (arr[i] > arr[inxMax])
      inxMax = i;
  int res = arr[inxMax];
  arr[inxMax] = 0;
  return res;
}
static int CancelMaxG(int[] arr)
{
  int n = 0;
  int num = 0, num1 = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    num = arr[i];
    if (num > arr[i + 1])
    {
      num1 = num;
    }
    else
    {
      num1 = arr[i + 1];
      n = i + 1;
    }
  }
  arr[n] = 0;
  return num1;
}
static void MainQ4()
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("\nSolution to Q4: CancelMax Sorting");
  Random rnd = new Random();
  int[] orig = new int[10];
  int[] special = new int[10];
  for (int i = 0; i < 10; i++)
    orig[i] = rnd.Next(1, 1001);
  for (int i = 0; i < 10; i++)
    special[i] = CancelMax(orig);
  foreach (var n in special)
    Console.WriteLine(n);
}
MainQ4();
Console.ForegroundColor = ConsoleColor.White;
#endregion