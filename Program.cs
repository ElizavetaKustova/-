void Clear(int[] arr)
{
    for (int n = 0; n < arr.Length; n++) {arr[n] = 0;};
}

Console.WriteLine("Введите желаемое количество элементов в массиве и нажмите ENTER:");
int a = Convert.ToInt32(Console.ReadLine());
int[] Mass1 = new int[a];

void NewArr(int[] arr)
{
    Console.WriteLine("Полученный массив из чётных элементов: ");
    int j = 0;
    for (int i = 0; i < a; i++)
    {
        if (Mass1[i] % 2 == 0) {arr[j]=Mass1[i]; Console.Write($"{arr[j]}    "); j++;};
    }
    if (arr.Length == 0) {Console.WriteLine("В исходном массиве нет чётных элементов");};
}

Console.WriteLine("Заполните введённое количество элементов массива через ENTER:");
int count = 0;
for (int i = 0; i < a; i++)
{
    Mass1[i]= Convert.ToInt32(Console.ReadLine());
    if (Mass1[i] % 2 == 0) {count++;};
}
int[] Mass2 = new int[count];
NewArr(Mass2);
Clear(Mass1);
Clear(Mass2);
count = 0;
Console.WriteLine();

Console.WriteLine("Эта программа также может заполнять исходный массив рандомными числами типа int, например: ");
Random rand = new Random();
for (int i = 0; i < a; i++)
{
    Mass1[i]= rand.Next();
    Console.Write($"{Mass1[i]}    ");
    if (Mass1[i] % 2 == 0) {count++;};
}
int[] Mass3 = new int[count];
Console.WriteLine();
NewArr(Mass3);