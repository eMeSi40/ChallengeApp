﻿int number = 42782949;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if(letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

Console.WriteLine("Przekształcana liczba: " + number);

Console.WriteLine("Ilość wystąpień cyfry 0 -> " + counter0);
Console.WriteLine("Ilość wystąpień cyfry 1 -> " + counter1);
Console.WriteLine("Ilość wystąpień cyfry 2 -> " + counter2);
Console.WriteLine("Ilość wystąpień cyfry 3 -> " + counter3);
Console.WriteLine("Ilość wystąpień cyfry 4 -> " + counter4);
Console.WriteLine("Ilość wystąpień cyfry 5 -> " + counter5);
Console.WriteLine("Ilość wystąpień cyfry 6 -> " + counter6);
Console.WriteLine("Ilość wystąpień cyfry 7 -> " + counter7);
Console.WriteLine("Ilość wystąpień cyfry 8 -> " + counter8);
Console.WriteLine("Ilość wystąpień cyfry 9 -> " + counter9);




