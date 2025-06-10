using System;

public class UnitConverter
{
    // Feet to Inches (1 英尺 = 12 英吋)
    public double FeetToInches(double feet)
    {
        return feet * 12;
    }

    // Yards to Inches (1 英碼 = 3 公尺 = 3*100 公分 = 300 公分 ≈ 118.11 英吋，但這裡應該是英碼=36 英吋)
    // 所以正確轉換應為：1 英碼 = 36 英吋
    public double YardsToInches(double yards)
    {
        return yards * 36;
    }
}

// 委派型別宣告
public delegate double ConvertToInches(double value);

class Program
{
    static void Main()
    {
        UnitConverter converter = new UnitConverter();
        ConvertToInches convertDelegate;

        Console.WriteLine("請輸入數值：");
        double input = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("請選擇轉換方式：");
        Console.WriteLine("1. 英尺 -> 英吋");
        Console.WriteLine("2. 英碼 -> 英吋");
        Console.Write("輸入選項 (1 或 2)：");
        string choice = Console.ReadLine();

        // 根據選擇指派對應方法到委派
        if (choice == "1")
        {
            convertDelegate = new ConvertToInches(converter.FeetToInches);
        }
        else if (choice == "2")
        {
            convertDelegate = new ConvertToInches(converter.YardsToInches);
        }
        else
        {
            Console.WriteLine("輸入錯誤！");
            return;
        }

        // 執行委派
        double result = convertDelegate(input);
        Console.WriteLine("轉換結果為：" + result + " 英吋");
    }
}
