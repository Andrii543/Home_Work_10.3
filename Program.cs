using System.Text;

namespace Home_Work_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            string inputUser = Console.ReadLine();
            StringBuilder builderInpuUser = new StringBuilder();

            foreach(char item in inputUser)
            {
                if(item == ' ')
                {
                    builderInpuUser.Append(item);
                }
            }


            Console.WriteLine($"Результат : {builderInpuUser}");


        }
    }
}
