using System;

public class MathHelper
{
    // Cube 方法：int 版本
    public int Cube(int value)
    {
        return value * value;
    }

    // Cube 方法：double 版本
    public double Cube(double value)
    {
        return value * value;
    }

    // MinElement 方法：接收 3 個 int 參數
    public int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    // MinElement 方法：接收 4 個 int 參數
    public int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}

// 測試主程式
class Program
{
    static void Main()
    {
        MathHelper helper = new MathHelper();

        // 測試 Cube 方法
        Console.WriteLine("Cube(5) = " + helper.Cube(5));         // int
        Console.WriteLine("Cube(3.2) = " + helper.Cube(3.2));     // double

        // 測試 MinElement 方法
        Console.WriteLine("Min of (4, 7, 2) = " + helper.MinElement(4, 7, 2));
        Console.WriteLine("Min of (8, 5, 6, 1) = " + helper.MinElement(8, 5, 6, 1));
    }
}
