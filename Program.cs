Console.WriteLine("Сколько чисел?");
int value = Convert.ToInt32(Console.ReadLine());
int count = 0;
void Vvod()
{
    for (int i = 0; i < value; i++)
    {
      int znak = Convert.ToInt32(Console.ReadLine());
      if (znak > 0)
      {
        count++;
      }
    }
    Console.WriteLine(count);
}

Vvod();

void uravnenie(double k, double b, double k2, double b2)
{
  double x = (b2 - b)/(k - k2);
  Console.WriteLine(x);
}

Console.WriteLine("Введите k, b, k2, b2");
double kk = Convert.ToDouble(Console.ReadLine());
double bb = Convert.ToDouble(Console.ReadLine());
double kk2 = Convert.ToDouble(Console.ReadLine());
double bb2 = Convert.ToDouble(Console.ReadLine());

uravnenie(kk, bb, kk2, bb2);
