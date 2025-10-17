using System;
using System.ComponentModel.Design;
using System.Configuration;
using System.IO;


namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Person[] clients = new Person[3];
            string[] help = new string[2];
            /*int x = 6;
            int y = 19;
            
            //Статические методы принадлежат классу 
            int res = Example.sum(x, y);

            Example ex1 = new Example(); // count = 1
            Example ex2 = new Example(); // count = 2
            Example.Count = 0;
            Example ex3 = new Example(); // count = 1
            Example ex4 = new Example(); // count = 2*/

            StreamReader streamReader;
            StreamWriter streamWriter;
            // Помещаем только тот код, который может быть с иключением
            try
            {
                streamWriter = new StreamWriter("new_ex.txt", false); // true - дозапись, false - перезапишет информацию
                streamReader = new StreamReader("ex.txt");
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }

            string s;
            i = 0;
            while ((s = streamReader.ReadLine()) != null)  // !streamReader.EndOfStream
            {
                help = s.Split(' ');
                clients[i] = new Person(help[0], Convert.ToInt32(help[1]));
                i++;
                //Console.WriteLine(s);
                           
            }
            streamReader.Close();

            for (int j = 0; j < 3; ++j)          
            {
                streamWriter.WriteLine(clients[j]);
            }

            streamWriter.Close();
        }
    }
}
