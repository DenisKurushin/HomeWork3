Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = new int[number];
for (int i = 1; i <= number; i++)
{ 
    array[i-1] = i*i*i;
    
}

PrintArray(array);

void PrintArray(int[] array){
    Console.WriteLine("массив: ");
    foreach (int a in array)
    {
        Console.WriteLine(a + "");
    }}