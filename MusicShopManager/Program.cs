using MusicShopManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine e = new Engine(new Database());
            e.Run();
        }
    }
}
