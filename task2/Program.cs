Console.WriteLine("введите координаты точки1");
int[] arrayA = fillarray(3);
Console.WriteLine("введите координаты точки2");
int[] arrayB = fillarray(3);

double[] arrayDif = new double[3];
for (int i =0; i < 3; i++){
arrayDif[i] = Math.Abs(arrayA[i] - arrayB[i]);
}

double first = Math.Sqrt(arrayDif[0]*arrayDif[0] + arrayDif[1]*arrayDif[1]);
double second = Math.Sqrt(first + arrayDif[2]*arrayDif[2]);

Console.WriteLine(second);

int[] fillarray(int size){
    int[] array = new int[size];
     for (int i =0; i < 3; i++){
        Console.WriteLine("введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
     }
     return array;
}
