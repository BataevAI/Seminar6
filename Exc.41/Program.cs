// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа, а мы посчитаем, сколько из них положительных");
 
      
        string stop = "stop";
        int number;        
        int count = 0;
        String str = null;

                while (true)                
           
                    {
                        
                        str = Console.ReadLine();
                        if (str == stop)
                            {           
                                break;
                            }                  
                            
                
                            number = Convert.ToInt32(str);
                            if (number > 0)  count++;

                                 
                    }

    Console.WriteLine($"количество положительных чисел: {count}");
  

   

