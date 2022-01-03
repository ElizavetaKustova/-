Console.WriteLine("Введите желаемое количество элементов в массиве и нажмите ENTER:");
int a = Convert.ToInt32(Console.ReadLine());
int[] Mass1 = new int[a];
Console.WriteLine("Заполните введённое количество элементов массива через ENTER:");
int count = 0;
for (int i = 0; i < a; i++)
{
    Mass1[i]= Convert.ToInt32(Console.ReadLine());
    if (Mass1[i] % 2 == 0) {count++;};
}
int[] Mass2 = new int[count];
int j = 0;
Console.WriteLine("Полученный массив из чётных элементов: ");
for (int i = 0; i < a; i++)
{
    if (Mass1[i] % 2 == 0) {Mass2[j]=Mass1[i]; Console.Write($"{Mass2[j]}    "); j++;};
}
