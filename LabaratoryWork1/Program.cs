
/*
 Borbuniuk Oleksii 
 group N ПЗПІп-22-2
 Laboratory work #1
 Task #2
 Task condition:
 Find the sum of 1^2+ 2^2+ 3^2+... + 10^2.
 Do not use exponentiation operation,
 take into account the peculiarities of obtaining a square
 natural number noted in the previous problem.
 */

//Variant with multiply
/*create variable result#1#
int result = 0;
/*create for iteration from 1 to 10#1#
for (int i = 1; i <= 10; i++)
{
 /*according to the condition each iterathion is the square of a number (i)
  and the result is a sum of square i#1#
 result += i * i;
}
/*show to the console our result#1#
Console.WriteLine("Result is: " + result);*/

//Variant without multiply
/*/#1#*create variable result#1#1#
int result1 = 0;
/*create for iteration from 1 to 10#1#
for (int i = 1; i <= 10; i++)
{
/*according to the condition each iterathion is the square of a number (i)
 and the result is a sum of square i#1#
for (int j = 0; j < i; j++)
{
 result1 += i;
}
}
/*show to the console our result#1#1#
Console.Write(result1);*/

int result2 = 0;
int temp = 0;
for (int i = 1; i <= 10; i++)
{
 temp += i + i - 1;
 result2 += temp;
}
Console.Write(result2);
