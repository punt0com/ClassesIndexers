using System;
using System.Collections.Generic;

namespace indexs
{

    public class Logger
    {

        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Navegator
    {
        public void WhichNavegator()
        {
            Console.WriteLine("estas en explorer");
        }

    }
    public class HttpCookie : Navegator
    {
        private Dictionary<string, string> _dictionary;
        private Logger looger = new Logger();


        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();

        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }

            set
            {
                _dictionary[key] = value;
                looger.log("this is a test");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            cookie["name"] = "Andre";

            Console.WriteLine(cookie["name"]);
            cookie.WhichNavegator();
            

        }
    }
}
