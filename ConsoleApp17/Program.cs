using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            var day = 1;
            while (day <= 31)
            {
                stringBuilder.AppendLine($"	  +(case  WHEN [Day{day.ToString("00")}AMType] =4 then 0.5  else 0 end)+(case  WHEN [Day{day.ToString("00")}PMType] =4  then 0.5  else 0 end)");
                day++;
            }
            var text = stringBuilder.ToString();
        }
    }
}
