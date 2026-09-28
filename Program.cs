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