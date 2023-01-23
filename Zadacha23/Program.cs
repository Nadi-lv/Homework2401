Console.WriteLine("Таблица кубов");
Console.WriteLine("Введите число N ");

int num;
int i = 1;

while (!Int32.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Вы ввели не число. Повторите попытку: ");
}
cube (i, num);
void cube (int i, int num)
{
    while (i < num+1)
    {
          Console.Write(Math.Pow(i,3) + "   ");
          i++;
    }

}
