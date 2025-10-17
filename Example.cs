using System;

namespace lesson3
{
    internal class Example
    {

        int x;
        int y;
        // Статическое поле принадлежит всем обьектам
        static int count;

        public static int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        static Example()
        {
            count = 0;
        }

        
        public Example()
        {
            count++;

        }
        // Данный метод принадлежит классу
        public static int sum(int x, int y)
        {
            return x + y; 
        }
    }
}
