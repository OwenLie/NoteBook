using System;
public sealed class Program
{
    static void Main(string[] args)
    {
        Color[] colors = GetEnumValues<Color>();
        foreach (Color color in colors)
        {
            Console.WriteLine(color.ToString("D"));
            Console.WriteLine(color);
            Console.WriteLine();
        }
    }

    public static TEnum[] GetEnumValues<TEnum>() where TEnum : struct
    {
        return (TEnum[])Enum.GetValues(typeof(TEnum));
    }
}