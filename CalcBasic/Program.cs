// See https://aka.ms/new-console-template for more information
using СalcBasic;

IClacBasic calc1 = new ClacBasic();


while (true)
{
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("+ = Сложение");
    Console.WriteLine("- = Вычитание");
    Console.WriteLine("* = Умножение");
    Console.WriteLine("/ = Деление");
    Console.WriteLine("sin = Синус");
    Console.WriteLine("cos = Косинус");
    Console.WriteLine("tan = Тангенс");
    Console.WriteLine("sqr = Квадрат числа");

    Console.Write("Введите символ операции: ");
    string operation = Console.ReadLine();

    try
    {
        double result = 0;
        double num1 = 0, num2 = 0, angle = 0, num = 0;

        // Сначала определяем операцию, потом запрашиваем нужные числа
        switch (operation)
        {
            case "+":
            case "-":
            case "*":
            case "/":
                // Для бинарных операций запрашиваем два числа
                Console.Write("Введите первое число: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num2 = double.Parse(Console.ReadLine());
                break;

            case "sin":
            case "cos":
            case "tan":
                // Для тригонометрических функций запрашиваем угол
                Console.Write("Введите угол в градусах: ");
                angle = double.Parse(Console.ReadLine());
                break;

            case "sqr":
                // Для квадрата запрашиваем одно число
                Console.Write("Введите число: ");
                num = double.Parse(Console.ReadLine());
                break;

            default:
                Console.WriteLine("Неизвестная операция!");
                continue;
        }
        /// Теперь выполняем вычисления
        switch (operation)
        {
            case "+":
                result = calc1.Add(num1, num2);
                break;

            case "-":
                result = calc1.Sub(num1, num2);
                break;

            case "*":
                result = calc1.Mult(num1, num2);
                break;

            case "/":
                result = calc1.Dive(num1, num2);
                break;

            case "sin":
                result = calc1.Sin(angle);
                break;

            case "cos":
                result = calc1.Cos(angle);
                break;

            case "tan":
                result = calc1.Tan(angle);
                break;

            case "sqr":
                result = calc1.Square(num);
                break;
        }

        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("Если вы закончили, напишите 'да'");
        if (Console.ReadLine().Trim().ToLower() == "да")
        {
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}

/// $ - это медот который используется для более удобного способа форматирования строк(также это называют строковая интерполяция) и чтобы не использовать sring.Format().
/// string.Format() - это статичный медот форматирования строк.
/// Console.ReadLine - это медот для чтения ввода пользователем из консоли.
/// WriteLine - это медотдля вывода текста в консоль с переходом на новую строку.
/// Console.ReadLine().Trim().ToLower() - это цепочка медотов,которая обрабатывает пользовательский ввод.
/// Console.Write - это медот для вывода текста в консоль бех перехода на новую строку.