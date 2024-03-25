 //Домашняя работа, Задание 1
    task3();
    void task1()
    {
        double operand1 = 0;
        double operand2 = 0;
        Console.WriteLine("Введите первое число:");
        double.TryParse(Console.ReadLine(), out operand1);
        Console.WriteLine("Введите второе число:");
        double.TryParse(Console.ReadLine(), out operand2);
        Console.WriteLine("Введите знак арифметической операции (+, -, *, /):");
        string sign = Console.ReadLine();
        switch (sign)
        {
            case "+":
                Console.WriteLine($"Результат: {operand1} + {operand2} = {operand1 + operand2}");
                break;
            case "-":
                Console.WriteLine($"Результат: {operand1} - {operand2} = {operand1 - operand2}");
                break;
            case "*":
                Console.WriteLine($"Результат: {operand1} * {operand2} = {operand1 * operand2}");
                break;
            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                else
                {
                    Console.WriteLine($"Результат: {operand1} / {operand2} = {operand1 / operand2}");
                }
                break;
            default:
                Console.WriteLine("Некорректный знак арифметической операции.");
                break;
        }

        Console.ReadLine();
    }


//Домашняя работа, задание 2
void task2()
{
        Console.WriteLine("Введите число от 0 до 100:");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number >= 0 && number <= 100)
            {
                if (number >= 0 && number <= 14)
                {
                    Console.WriteLine("Число находится в промежутке [0 - 14].");
                }
                else if (number >= 15 && number <= 35)
                {
                    Console.WriteLine("Число находится в промежутке [15 - 35].");
                }
                else if (number >= 36 && number <= 50)
                {
                    Console.WriteLine("Число находится в промежутке [36 - 50].");
                }
                else
                {
                    Console.WriteLine("Число находится в промежутке [50 - 100].");
                }
            }
            else
            {
                Console.WriteLine("Число должно быть от 0 до 100.");
            }
        }
        else
        {
            Console.WriteLine("Введено некорректное число.");
        }

        Console.ReadLine();
    }

//Домашняя работа, задание 3
void task3()
{
        Dictionary<string, string> weatherDictionary = new Dictionary<string, string>
            {
                {"автомобиль", "car"},
                {"двигатель", "engine"},
                {"тормоза", "brakes"},
                {"колесо", "wheel"},
                {"скорость", "speed"},
                {"топливо", "fuel"},
                {"программирование", "programming"},
                {"переменная", "variable"},
                {"функция", "function"},
                {"цикл", "loop"}
            };

        Console.WriteLine("Введите слово о погоде на русском языке:");
        string russianWord = Console.ReadLine().ToLower();

        if (weatherDictionary.ContainsKey(russianWord))
        {
            string englishTranslation = weatherDictionary[russianWord];
            Console.WriteLine($"Перевод на английский: {englishTranslation}");
        }
        else
        {
            Console.WriteLine("Ошибка: Такого слова нет в словаре.");
        }

        Console.ReadLine();
    }