namespace Rhombus_of_Stars
{
    using System;
    using System.Text;

    public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            DrawTopPart(sb, n);            
            DrawLineOfStars(n, sb);
            DrawBottomPart(sb, n);
            
            Console.WriteLine(sb);
        }

        public static void DrawLineOfStars(int numberOfStars, StringBuilder sb)
        {           
            for (int star = 0; star < numberOfStars; star++)
            {
                sb.Append('*');
                if (star < numberOfStars - 1)
                {
                    sb.Append(' ');
                }
            }
            // sb.Append(new string(' ', n - i - 1));
            sb.AppendLine();         
        }
        public static void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(i, sb);
            }
        }
        public static void DrawBottomPart(StringBuilder sb, int numberOfStars)
        {
            for (int i = numberOfStars - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', numberOfStars - i));
                DrawLineOfStars(i, sb);
            }
        }
    }
}
