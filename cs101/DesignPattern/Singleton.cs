// https://www.dofactory.com/net/adapter-design-pattern
using System;

namespace DesignPattern
{
    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton getInstance()
        {

            if (_instance == null)
            {
                Console.WriteLine("Sigleton created !!");
                _instance = new Singleton();
            }

            return _instance;
        }

        public string sayHello() {
            return "hello C#, I'm here";
        }
    }
}