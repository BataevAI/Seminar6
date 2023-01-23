// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите четыре параметра двух прямых: y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine("А мы выведем координаты точки пересечения (x, y)");

Console.WriteLine("Введите коэффициент b1"); 
    int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");            // k1 * x + b1 = k2 * x + b2
    int k1 = Convert.ToInt32(Console.ReadLine());       // x = (b2 - b1)/(k1 - k2)
Console.WriteLine("Введите коэффициент b2");            
    int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
    int k2 = Convert.ToInt32(Console.ReadLine());

    double[] GetCrossPoint(double b11, double k11, double b22, double k22) {

                       
            double[] arr = new double[2];

            arr[0] = (b22 - b11)/(k11 - k22);
            arr[1] = arr[0] * k11 + b11;

        return arr;
    }

        if(k1 == k2 && b1 == b2) 
        {
            Console.WriteLine("Прямые совпадают!");  
        }
        
        else if (k1 == k2 ) 
            {
                    Console.WriteLine("Прямые параллельны, точек пересечения нет!");
                   
            }
        else 
        {
double[] array = GetCrossPoint(b1,k1,b2,k2);
Console.Write($"Координаты (X, Y): ({Math.Round(array[0], 2)}, {Math.Round(array[1], 2)}");

        }


