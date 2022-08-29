//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2 D пространстве;
 Console.Clear();
 Console.WriteLine("Input A (x, y)");
 Console.Write ("x: ");
 int x1 = Convert.ToInt16(Console.ReadLine());
 Console.Write ("y; ");
 int y1 = Convert.ToInt16(Console.ReadLine());
 Console.WriteLine("Input B(x, y)");
 Console.Write("x: ");
 int x2 = int.Parse(Console.ReadLine());
 Console.Write("y: ");
 int y2 = int.Parse(Console.ReadLine());

 Console.WriteLine(Math.Sqrt((x2-x1) * (x2-x1) + (y2 -y1) * (y2 - y1)));
