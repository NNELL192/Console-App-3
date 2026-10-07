//Console.WriteLine("Введите команду!");
//Console.WriteLine("1вход в игру");
//Console.WriteLine("2 загрузить игру");
//Console.WriteLine("3 Выход из игры");
//string choce = Console.ReadLine();

//switch(choce)
//{
//case "1":
//Console.WriteLine("Выполнен вход в игру");
//break;
//case "2":
//Console.WriteLine("Загрузка игры");
//break;
//case "3":
//Console.WriteLine("Выход из игры");
//break;
//default: Console.WriteLine("Введите значение от 1 до 3");
//break;
//}


//for (int i = 1; i < 199; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        Console.Write($"{i * j}\t");
//    }
//    Console.WriteLine();
//}

//Random random = new Random();
//int secretNumber = random.Next(1, 100);

//int userGuess = 0;
//int atters = 0;

//Console.WriteLine("я загадал число от 0 до 100");
//{



//}
//while (userGuess != secretNumber)
//{
//    Console.WriteLine("Ваша догадка");
//    userGuess = Convert.ToInt32(Console.ReadLine());
//    atters++;

//    if (userGuess < secretNumber)
//    {
//        Console.WriteLine("загаданное число больше");
//    }
//    else if (userGuess > secretNumber)
//    {
//        Console.WriteLine("загаданное число меньше");
//    }

//}
//Console.WriteLine($"Поздравляю вы отгадали число {secretNumber}");
//Console.WriteLine("Конец программы");
//Console.WriteLine();


//Console.WriteLine("Введите вашу оценку");

//int choce = Convert.ToInt32(Console.ReadLine());

//if (choce <= 0 && choce > 100)

//{
// Console.WriteLine("ошибка");
//}
//else if (choce >= 80 )
//{
// Console.WriteLine("отлично");
//}
//else if (choce >= 65)
//{
// Console.WriteLine("хорошо");
//}
//else
//{
// Console.WriteLine("удо");
//}
//Console.ReadLine();

//Console.WriteLine("Рецепт: Идеальн6ый кофе");


//Console.WriteLine("Ингредиенты:");
//Console.WriteLine("Кофе молотый - 2 чайных ложки");
//Console.WriteLine("Вода - 200мл");
//Console.WriteLine("Сахар - по вкусу");


//Console.WriteLine("Приготовление:");
//Console.WriteLine("Вскипетить воду");
//Console.WriteLine("Залить кипиток в кружку");
//Console.WriteLine("Засыпать кофе");
//Console.WriteLine("Перемещать");

//Console.WriteLine("--Улучшенный калькулятор--");
//Console.WriteLine("Введите первое число");

//double firstNum = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine("Введите второе число");
//double twoNum = Convert.ToDouble(Console.ReadLine());



//Console.WriteLine("Введите оператор +,-,*,/");
//string oper = Console.ReadLine();

//switch (oper)
//{
//    case "+":
//        Console.WriteLine($"сложение : {firstNum}+{twoNum} = {firstNum + twoNum}");
//        break;
//    case "-":
//        Console.WriteLine($"Вычетание : {firstNum}-{twoNum} = {firstNum - twoNum}");
//         break;
//    case "*":
//        Console.WriteLine($"Умножение : {firstNum}*{twoNum} = {firstNum * twoNum}");
//        break;
//    case "/":
//        if (firstNum == 0)
//        {
//            Console.WriteLine("на ноль делить нельзя");
//        }
//        else
//        {
//            Console.WriteLine($"Деление : {firstNum}/{twoNum} = {firstNum / twoNum}");
//        }
//        break;
//    default: Console.WriteLine("Вы ввели не правильное значение");break;
//}


//Console.WriteLine("Введите значение от 0 до 10");
//int firstnum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("начало цикла for");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"Ваше значение :  {i}");
//    if (i % 2 != 0)
//    {
//        Console.WriteLine($"четные числа:{i}");
//    }
//Console.WriteLine("конец цикла for");
//Console.ReadLine();

//    else
//    {
//        Console.WriteLine($"Не четные числа:{i}");
//    }
//}

//for (int i = 15; i <= 100; i++)
//{
//    if(i % 7 == 0)
//    {
//        Console.WriteLine($"Первое число которое делиться на 7: {i * i}");
//        break;
//    }
//}


while (true)
{
    Console.WriteLine("1 вход в игру");
    Console.WriteLine("2 сохранить игру");
    Console.WriteLine("3 загрузить игру");
    Console.WriteLine("4 Выход из игры");

    int press = Convert.ToInt32(Console.ReadLine());

    if (press == 4)
    {
        Console.WriteLine("4 Выход из игры");
        break;
    }
    else if (press == 5 || press <= 0)
    {
        Console.WriteLine("Для выхода из игры нажмите кнопку 4");
    } 
}













































































































































