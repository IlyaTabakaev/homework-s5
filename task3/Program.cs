Console.WriteLine("input array size");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
double max = array[0];
double min = array[0];


void FillArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 1000);
        Console.Write(array[i] + ", ");
    }
}

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
        {
            max = array[z];
        }
    if (array[z] < min)
        {
            min = array[z];
        }
}
Console.WriteLine($"maxvalue = {max}, minvalue = {min}, difference = {max - min}");