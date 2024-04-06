//Домашняя работа, Задание 1
/*task2();
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
}*/

/*double PI=3.1461592653;
decimal EL=2.15465413216548456M;
Console.WriteLine(PI);
Console.WriteLine(EL);*/

/*string a = "\nмоя строка 1";
string b = "\tмоя строка 2";
string c = "\aмоя строка 3";
Console.Write(a);
Console.Write(b);
Console.Write(c);*/


/*double PI = 3.14;
double r = double.Parse(Console.ReadLine());
Console.WriteLine(Math.Pow(r,2)*PI);
*/


/*Console.WriteLine("Значение Радиуса");
double R = double.Parse(Console.ReadLine());
Console.WriteLine("Значение высоты");
double h = double.Parse(Console.ReadLine());
Console.WriteLine($"Объем = {Math.PI * Math.Pow(R, 2) * h}");
Console.WriteLine($"Площадь = {2 * Math.PI * R * (R + h)}");*/


/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());*/
/*    if (a == b & c > a)
{
    Console.WriteLine("Hello");
}
else
{
    Console.WriteLine(a + b);
}*/

/*switch (a)
{
    case 1: 
        Console.WriteLine(1);
        break;
    case 2: 

    case 3: 
        Console.WriteLine(2);
        break;
    case 4: 
        Console.WriteLine(3);
        break;
    default: 
        Console.WriteLine("Yes");
        break; 
}*/

/*Console.WriteLine("Введите первое значение");
double operand1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение");
double operand2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите знак арифметической операции: *,/,+,-,%");
string sign = Console.ReadLine();
    switch (sign)
{
    case "+":
            Console.WriteLine(operand1 + operand2);
            break;
    case "-":
        Console.WriteLine($"Результат: {operand1} - {operand2} = {operand1 - operand2}");
        break;
    case "*":
            Console.WriteLine(operand1 * operand2);
            break;
    case "/":
        if (operand2 !=0 && operand1 != 0)
        {
            Console.WriteLine(operand1 * operand2);
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
            break;
    case "%":
            Console.WriteLine(operand1 % operand2);
            break;
    default:
        Console.WriteLine("Такой арифметической операции не существует!");
        break;
}
Console.ReadLine();*/


/*double operand1 = int.Parse(Console.ReadLine());
if (operand1 <= 100)
{
    if (operand1 >= 0 && operand1 <= 14)
    {
        Console.WriteLine("Число находится в промежутке [0 - 14].");
    }
    else if (operand1 >= 15 && operand1 <= 35)
    {
        Console.WriteLine("Число находится в промежутке [15 - 35].");
    }
    else if (operand1 >= 36 && operand1 <= 50)
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
    Console.WriteLine("Цифры не входят в диапозон");
}*/



/*double chis = int.Parse(Console.ReadLine());
if (chis>=0 && chis<=100)
{
    if (chis<=14)
    {
        Console.WriteLine("Число находится в промежутке [0 - 14].");
    }
    else if (chis >= 15 && chis <= 22)
    {
        Console.WriteLine("Число находится в промежутке [15 - 22].");
    }
    else if (chis >= 23 && chis <= 49)
    {
        Console.WriteLine("Число находится в промежутке [23 - 49].");
    }
    else
    {
        Console.WriteLine("Число находится в промежутке [50 - 100].");
    }
}
else
{
    Console.WriteLine("пользователь указывает число, не входящее ни в один из имеющихся числовых\r\nпромежутков");
}*/



/*string slovo = Console.ReadLine();
switch (slovo)
{
    case "Солнце":
        Console.WriteLine("solnce");
        break;    
    case "Небо":
        Console.WriteLine("nebo");
        break;    
    case "Луна":
        Console.WriteLine("luna");
        break;    
    case "Туча":
        Console.WriteLine("tucha");
        break;    
    case "Дача":
        Console.WriteLine("dacha");
        break;    
    case "Весна":
        Console.WriteLine("vesna");
        break;    
    case "Трава":
        Console.WriteLine("trava");
        break;    
    case "Вода":
        Console.WriteLine("voda");
        break;    
    case "Луч":
        Console.WriteLine("luch");
        break;
    default:
        Console.WriteLine("Такой слова не существует!");
        break;
}
Console.ReadLine();*/

double sim = double.Parse(Console.ReadLine());
double otvet = sim % 2;
if (otvet == 0)
{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("не четное число");
}

