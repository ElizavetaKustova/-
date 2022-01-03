Console.WriteLine("Введите желаемое количество элементов в массиве и нажмите ENTER:");
int a = Console.Read();
int[] Mass1 = new int[a];
Console.WriteLine("Заполните введённое количество элементов массива через ENTER:");
for (int i = 1; i < a; i++)
{
    Mass1[i]= Console.Read();
}
