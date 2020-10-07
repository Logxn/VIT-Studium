/*
    Author: Logan Thompson
    Date: 07.10.2020
    For: github.com/Logxn/VIT-Studium
    Description: A class that transforms a decimal number to a binary number string
*/
using System;

public class Decimal2Binary
{
    public string Dec2Bin(int dec)
    {
        var lastNum = dec;
        var binaryString = "";

        // We want to divide the starting number all the way down until we reach 0
        while(lastNum != 0)
        {
            var remainder = lastNum % 2;
            lastNum /= 2;

            binaryString += remainder.ToString();
        }

        // If the calculation above was correct, we should have a binary number in string format
        // BUT: The string must be reversed first so the binary number is in its correct order

        var charArray = binaryString.ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }
}
