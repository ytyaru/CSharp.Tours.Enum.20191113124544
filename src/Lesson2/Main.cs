using System;

namespace Tour.Enum.Lesson2 {
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
            foreach (string name in System.Enum.GetNames(typeof(Color))) {
                Console.WriteLine($"{name}: {(int)System.Enum.Parse(typeof(Color), name)}");
            }
        }
    }
}

