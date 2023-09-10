
using learningProperties;
using System.Security.Claims;

Box box = new Box(3, 7 , 2);

Console.WriteLine("Box length is " + box.GetLength());
box.Width= 2;
Console.WriteLine("Box width is " + box.Width);

box.DisplayInfo();

