// Защита на дурака

int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;

while(!isCorrect)
{
Console.WriteLine(message);

isCorrect = int.TryParse(Console.ReadLine(), out result);

if(!isCorrect)
Console.WriteLine("Неверный ввод, введите корректное число");

Console.WriteLine();
}

return result;
}

int number = GetNumber("Введите число");


/* 
reference (Ссылочные) - string, class, list, array, dictionary...
value (значемые) - datetime, int, enum, struct, decimal, long, double, bool...

стек и управляемая куча

стек - значимые значения
управляемая куча -ссылочные
 */