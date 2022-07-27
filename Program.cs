Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine(cube);
}
//  Решение №2
int j = 1;
while (j <= n)
{
    double cube = Math.Pow(j, 3);
    Console.WriteLine(cube);
    j++;
}
