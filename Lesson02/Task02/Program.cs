Console.Clear();
Console.WriteLine("Веедите координаты точки, не равные 0.");
Console.Write("Координата X:");
int coordinateX = int.Parse(Console.ReadLine()!);
Console.Write("Координата Y:");
int coordinateY = int.Parse(Console.ReadLine()!);
if (coordinateX > 0 && coordinateY > 0)
    Console.WriteLine("Точка в 1 четверти");
else
    if (coordinateX < 0 && coordinateY > 0)
        Console.WriteLine("Точка в 2 четверти");
    else
        if (coordinateX < 0 && coordinateY < 0)
            Console.WriteLine("Точка в 3 четверти");
        else
            if (coordinateX > 0 && coordinateY < 0)
                Console.WriteLine("Точка в 4 четверти");
            else
                Console.WriteLine("Точка на пересечении линии координат");