

using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Підключаємо українську мову
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Test();
            


            //Клас Тест
            static void Test()
            {
                Test test1 = new Test("Математика", true);
                Test test2 = new Test();

                Console.WriteLine("Інформація про тест 1:");
                Console.WriteLine(test1.ToString());

                test2.SubjectName = "Фізкультура";
                Console.WriteLine("\nІнформація про тест 2:");
                Console.WriteLine(test2.ToString());
            }
            
        }
    }
}
