// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4





int count = 0;
string stop = "stop";


Console.WriteLine("Введите число M, обозначающее количество введенных числе, из которых будем искать положительные");

int M = Convert.ToInt32(Console.ReadLine());



        int MetodCount (int MM) {

         
            for (int i = 0; i < MM; i++) 
                
                                {
                // if (Console.ReadLine() == stop)  {           // или же if (Console.ReadLine(),Equals(stop)) {
                //     break;
                //     }                  
                // else {
                
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0) count++;

                // }
                                }

        
    return count;
        }
Console.WriteLine("ВВедите числа, а мы посчитаем, сколько из них положительных");


    int t = MetodCount(M);
    Console.WriteLine($"положительных: {t} чисел");

