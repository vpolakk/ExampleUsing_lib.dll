using System;
using ds.test.impl;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Library.Plugins.factory.GetPluginNames;
            int error = 0;
            Library.IPlugin plugin = Library.Plugins.factory.GetPlugin("Summ",ref error);
            int a = plugin.Run(1, 2);
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
            Console.Write("Число всех классов :");
            Console.WriteLine(Library.Plugins.factory.PluginsCount);
            Console.ReadLine();
        }
       
    }
}
