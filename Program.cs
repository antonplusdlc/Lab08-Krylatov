using System.Reflection.Emit;

int lessonNum = 1;
int totalLessons = 5;

while (totalLessons >= lessonNum) {
    Console.WriteLine($"Para {totalLessons}");
    totalLessons--;
}

Console.WriteLine("Пары закончились");

Console.WriteLine($"Enter grades. for finish enter -1:");
int grade = int.Parse(Console.ReadLine());
int gradesCount = 0;

while (grade != -1)
{
    Console.WriteLine($"Grade: {grade}");
    gradesCount++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"finished. grades count: {gradesCount}");

int sum = 0;
int cnt = 0;
int maxGrade = 0;

Console.WriteLine("Enter grades. for finish enter -1:");
int grades = int.Parse(Console.ReadLine());

while (grades != -1)
{
    sum += grades;
    cnt++;
    maxGrade = Math.Max(grades, maxGrade);
    grades = int.Parse(Console.ReadLine());
}

if (cnt > 0) Console.WriteLine($"sr. ball: {(double)sum / cnt}");
else Console.WriteLine("0 grades");
Console.WriteLine($"max garde: {maxGrade}");

string correctPswd = "qwerty123";
int incorrectPswdCnt = 0;

while (true)
{
    Console.Write("enter password: ");
    string password = Console.ReadLine();

    if (password == correctPswd)
    {
        Console.WriteLine($"dostup razrehen!\nincorrect cnt: {incorrectPswdCnt}");
        break;
    }

    Console.WriteLine("incorrect password! try again");
    incorrectPswdCnt++;
}

string answer;

do
{
    Console.Write("enter date: ");
    string date = Console.ReadLine();
    Console.WriteLine($"date {date} added!");

    Console.Write("again? (y/n): ");
    answer = Console.ReadLine();
} while (answer == "y");

Console.WriteLine("dnevnik saved");

// Самостоятельные задания

// A

int N = 5;
int da = 1;

while (da <= 10)
{
    Console.WriteLine($"{N} x {da} = {N * da}");
    da++;
}

// Б

int namesCnt = 0;

Console.Write("Enter names: ");
string name = Console.ReadLine();

while (name != "конец")
{
    namesCnt++;
    name = Console.ReadLine();
}

Console.WriteLine($"names cnt: {namesCnt}");

// Индивидуальный вариант

/*Console.Write("famil: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("not surname!");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10).OrderBy(_ => rnd.Next()).Take(2).OrderBy(x => x).ToList();

Console.WriteLine($"tasks: {assigned[0]} and {assigned[1]}");*/

//4 8

int symbolCnt = 0;

Console.Write("Enter symbol: ");
string symbol = Console.ReadLine();

while (symbol != "q")
{
    symbolCnt++;
    symbol = Console.ReadLine();
}

Console.WriteLine($"symbols cnt: {symbolCnt}");

bool isValid = false;
string pass = "test";
int popitki = 0;

Console.Write("enter password: ");
string passw = Console.ReadLine();

while (popitki < 3 && !isValid)
{
    if (passw == pass)
    {
        Console.WriteLine("Доступ разрешён");
        isValid = true;
        break;
    }

    Console.WriteLine("неверный пароль! попробуй еще раз");
    popitki++;
    if (popitki != 3) passw = Console.ReadLine();
}

if (popitki >= 3 && !isValid) Console.WriteLine("Доступ заблокирован");

// Дополнительное задание

int correctPin = 1487;
int popitkiDop = 0;
bool validPin = false;
int sumSnatie = 0;

Console.Write("Enter pin: ");

int enteredPin = int.Parse(Console.ReadLine());

while (popitkiDop != 3 && !validPin)
{
    if (enteredPin == correctPin)
    {
        validPin = true;
        goto PIN_CORRECT;
    }
    Console.WriteLine("incorrect pin! try again");
    popitkiDop++;
    if (popitkiDop != 3) enteredPin = int.Parse(Console.ReadLine());
}

if (popitkiDop == 3 && !validPin)
{
    Console.WriteLine("Карта заблокирована");
    return;
}

PIN_CORRECT:
Console.Write("введите сумму снятия: ");
int sumSnat = int.Parse(Console.ReadLine());

while (sumSnat != 0)
{
    sumSnatie += sumSnat;
    sumSnat = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Сумма снятия: {sumSnatie}");