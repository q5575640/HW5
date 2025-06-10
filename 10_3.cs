using System;

// 定義介面 IPrice
public interface IPrice
{
    double GetPrice(); // 取得價格的方法
}

// 定義類別 Car，實作 IPrice 介面
public class Car : IPrice
{
    // 屬性
    public double Price { get; set; }
    public string Name { get; set; }

    // 建構子
    public Car(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // 實作介面方法
    public double GetPrice()
    {
        return Price;
    }

    // 額外方法：取得車名
    public string GetName()
    {
        return Name;
    }
}

// 測試程式
class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", 800000);
        Console.WriteLine("車名: " + car1.GetName());
        Console.WriteLine("價格: " + car1.GetPrice());
    }
}
