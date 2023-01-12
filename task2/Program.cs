Console.WriteLine("input array size");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
int sum = 0;


void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 1000);
        Console.Write(array[i] + ", ");
    }
}

for (int z = 0; z < array.Length; z+=2)
    sum = sum + array[z];

    Console.WriteLine($"sum uneven numbers = {sum}");