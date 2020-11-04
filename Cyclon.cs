using System;
using System.Numerics;
using System.Xml.Schema;

namespace Proc
{
    public class DZ
    {
        //Proc20
        public void PUS ()
        {
            double h = 10;
        double a = 14;
        Console.WriteLine(TriangleP(a, h));
        }
    static int SumRange(int A, int B)
    {
        int sum = 0;
        if (A > B)
        {
            return sum;
        }
        else
        {
            for (int i = A; i <= B; i++)
                sum += i;
            return sum;
        }
    }
    //Proc21
    public void UBS()
        {
            int A = 6;
    int B = 10;
    int C = 14;
    Console.WriteLine(SumRange(A, B));
            Console.WriteLine(SumRange(B, C));
        }

//Proc1
public double USP()
        {
            int A = 0;
PowerA3(3, ref A);
Console.WriteLine(A);
        }
        public void PowerA234(int A, ref int B, ref int C, ref int D)
{
    B = (int)Math.Pow(A, 2);
    C = (int)Math.Pow(A, 3);
    D = (int)Math.Pow(A, 4);
}
//Proc2
public void UPS()
        {
            int A = 0;
PowerAt234(2, ref A);
PowerAt234(3, ref A);
PowerAt234(4, ref A);
Console.WriteLine(A);
        }
        public double Mean(int X, int Y, double AMean, double GMean)
{
    AMean = (X + Y) / 2;
    GMean = Math.Sqrt(X * Y);
}
//Proc3
public void OK ()
        {
            int A = 6;
int B = 11;
int C = 18;
int D = 3;
Console.WriteLine(Mean(A, B, AMean, GMean));
            Console.WriteLine(Mean(A, C, AMean, GMean));
            Console.WriteLine(Mean(A, D, AMean, GMean));
        }
        static int Sign(double x)
{
    if (x < 0)
        return -1;
    if (x == 0)
        return 0;
    return 1;
}

//Proc4
public void TrianglePS(in double a, out double P, out double S)
{
    P = 3 * a;
    S = a * a * Math.Sqrt(3) / 4;
}

//Proc15
public void ShiftLeft3(ref double A, ref double B, ref double C)
{
    (A, B, C) = (B, C, A);
}

//Proc26
public bool IsPower5(int k)
{
    double inputNum = k;
    while (inputNum > 1)
    {
        inputNum /= 5;
        if (inputNum == 1)
        {
            return true;
        }
        if (inputNum < 1)
        {
            return false;
        }
    }
    return true;
}

//Proc30
public int DigitCount(int k)
{
    string kString = k.ToString();
    return kString.Length;
}
//Proc18
public void KO()
        {
           int R = 15;
Console.WriteLine(CircleS(R));
        }
           static double RingS(int R1, int R2)
{
    return (Math.PI * R1 * R1) - (Math.PI * R2 * R2);
}
}