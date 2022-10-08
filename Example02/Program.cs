/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

void AnswerToTask()
{
    int newNumber = (new Random()).Next(100, 1000);
    Console.WriteLine($"Base number: {newNumber}");
    string numericAssString = newNumber.ToString();
    int result = int.Parse (numericAssString[0].ToString() + numericAssString[2].ToString());
    Console.WriteLine($"Result number: {result}");
}

AnswerToTask();