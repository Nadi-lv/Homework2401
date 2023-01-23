Console.WriteLine("Проверка палиндрома");
Console.WriteLine("Введите пятизначное число: ");

int num;



while (!Int32.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Вы ввели не число. Повторите попытку: ");
}

if (num <10000 || num > 99999)
{
Console.WriteLine("Вы ввели не пятизначное число. Повторите попытку");
return;
}
Palindrom (num);


void Palindrom (int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num /10 ) % 10) 
          Console.WriteLine("yes");
    else
           Console.WriteLine("no");

}