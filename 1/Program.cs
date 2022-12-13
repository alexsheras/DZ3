Console.WriteLine ("введите пятизначное число: ");
int r = Convert.ToInt32(Console.ReadLine());
if ((r%100000-r%10000)/10000 == r%10 && (r%10000-r%1000)/1000==(r%100-r%10)/10)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Нет");
}