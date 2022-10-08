char REPITE = '0';
while (REPITE <= '0')
{
    double NumOne;
    double NumTwo;
    double total;
    double oper;

    Console.WriteLine("Введите первое число:");
    NumOne = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    NumTwo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. корень числа");
    Console.WriteLine("7. Высчитывание 1% от числа");
    Console.WriteLine("8. Нахождение факториала");
    Console.WriteLine("9. Закрытие программы ");
    Console.WriteLine("");
    Console.Write("Выбертие номер действия: ");

    oper = Convert.ToChar(Console.ReadLine());




    if (oper == '1')
    {
        total = NumOne + NumTwo;
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }

    else if (oper == '2')
    {
        total = NumTwo - NumOne;
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }

    else if (oper == '3')
    {
        total = NumOne * NumTwo;
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }
    else if (oper == '4')
    {
        total = NumOne / NumTwo;
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }
    else if (oper == '5')
    {
        total = Math.Pow(NumOne, NumTwo);
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }
    else if (oper == '6')
    {
        total = Math.Sqrt(NumOne);
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }
    else if (oper == '7')
    {
        total = NumOne * 0.01;
        Console.WriteLine("");
        Console.WriteLine("Ответ: " + total);
    }
    else if (oper == '8')
    {
        int f = 1;
        int i;
        for (i = 2; i <= NumTwo; i++)
        {
            f = f * i;
        }
        Console.WriteLine("");
        Console.WriteLine(f);
    }
    else if (oper == '9')
    {
        break;
    }
    else
        {
        Console.WriteLine("");
        Console.WriteLine("Неизвестный оператор.");
        }
    Console.WriteLine("                   ");
    Console.WriteLine("Что бы повторить напишите 0.");
    REPITE = Convert.ToChar(Console.ReadLine());
    }
