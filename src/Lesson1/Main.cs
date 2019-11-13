using System;

namespace Tour.Enum.Lesson1 {
    enum Color
    {
        Red = 100,
        Green,
        Blue
    }
    public class Main {
        public void Run() {
            M1();
        }
        void M1() {
            int cr = (int)Color.Red;
            Color c = (Color)100;
            Console.WriteLine($"{cr}, {c}");
        }
    }
}

