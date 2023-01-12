

Console.WriteLine("input array size");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine($"{count} even");

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
        Console.Write(array[i] + ", ");
    }
}
