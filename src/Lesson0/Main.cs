using System;

namespace Tour.Enum.Lesson0 {
    enum Color
    {
        Red,
        Green,
        Blue
    }
    public class Main {
        public void Run() {
            Console.WriteLine(M1(Color.Red));
            M2(Color.Red);
        }
        string M1(Color c) => c switch {
            Color.Red => "赤",
            Color.Green => "緑",
            Color.Blue => "青",
            _ => "",
        };
        void M2(Color c) {
            switch (c) {
                case Color.Red: Console.WriteLine("赤"); break;
                case Color.Green: Console.WriteLine("緑"); break;
                case Color.Blue: Console.WriteLine("青"); break;
                default: break;
            }
        }
    }
}

