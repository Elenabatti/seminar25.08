// Напишите зпрограмму, которая на вход принимает координаты точки(X:Y), причем  Xне равен 0 и Y не равен 0
//и выдаёт четверти плоскости в которой находится эта точка

Console.Clear();
Console.Write("Введитe X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

if( x>0 && y>0)
Console.WriteLine("1");
else if( x<0 && y>0)
Console.WriteLine("2");
else if( x<0 && y<0)
Console.WriteLine("3");
else if( x>0 && y<0)
Console.WriteLine("2");
