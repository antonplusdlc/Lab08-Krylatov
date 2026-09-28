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