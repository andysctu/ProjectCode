// ------------------------------------------------------------------- 
// Department of Electrical and Computer Engineering 
// University of Waterloo 
// 
// Student Name:    Andy Tu 
// Userid:          astu
// ID number:         20509407
// 
// Assignment:      programming assignment 2 (astu-pa2)
// Submission Date: 
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work. 
// 
// Acknowledgements: 
// Starting point pa2start.cs.txt file from Learn
// -------------------------------------------------------------------
using System;

// Class Range represents a sequence of numbers with equal-size intervals.
class Range
{
    //Declare private fields
    private double startValue;
    private double endValue;
    private double deltaValue;

    // Range Constructor initializes all three fields.
    // Arguments leading to an invalid range cause an ArgumentException.
    public Range(double startValue, double endValue, double deltaValue)
    {
        this.startValue = startValue;
        this.endValue = endValue;
        if (((endValue - startValue >= 0) && (deltaValue > 0)) ||
            ((endValue - startValue <= 0) && (deltaValue < 0)))
            this.deltaValue = deltaValue;
        else if (deltaValue == 0)
        {
            throw new ArgumentException("Invalid delta value entered." +
            " Delta value cannot equal 0.");
        }
        else
        {
            throw new ArgumentException("Invalid delta value entered.");
        }
    }

    // Property Count is a get-only property which returns the
    // number of elements in the sequence of numbers comprising the range.
    public int Count
    {
        get
        {
            return (int)((endValue - startValue) / deltaValue) + 1;
        }
    }

    // Method Sum computes the sum of the elements in the sequence of
    // numbers comprising the range.
    public double Sum()
    {
        return Count * (2 * startValue + deltaValue * (Count - 1)) / 2;
    }

    // Method Product computes the product of the elements in the sequence of
    // numbers comprising the range.
    public double Product()
    {
        double prod = startValue;
        for (int i = 1; i < Count; i++)
            prod = prod * (startValue + deltaValue * i);
        return prod;
    }

    // Method ToString returns a string of the form
    // "Range from 1.00 to 10.00 in steps of 2.00"
    // if the start, end, and delta values are 1, 10, and 2, respectively.
    // making up the range.
    public override string ToString()
    {
        return String.Format("Range from {0:F2} to {1:F2} in steps of " +
        "{2:F2}", startValue, endValue, deltaValue);
    }
}

class TestProgram
{
    // Method Main runs a simple test program for the Range class.
    // Do not modify this code.
    private static void Main()
    {
        Range range;

        double start;
        double end;
        double delta;

        Console.WriteLine();
        Console.WriteLine("Programming Assignment 2: Range Class");
        Console.WriteLine();

        Console.Write("Enter a starting value for the range    : ");
        start = double.Parse(Console.ReadLine());

        Console.Write("Enter an ending value for the range     : ");
        end = double.Parse(Console.ReadLine());

        Console.Write("Enter a step (delta) value for the range: ");
        delta = double.Parse(Console.ReadLine());

        range = new Range(start, end, delta);

        Console.WriteLine();
        Console.WriteLine(range);
        Console.WriteLine("Count of elements  : {0}", range.Count);
        Console.WriteLine("Sum of elements    : {0:f2}", range.Sum());
        Console.WriteLine("Product of elements: {0:f2}", range.Product());
        Console.WriteLine();

        Console.Read();
    }
}
