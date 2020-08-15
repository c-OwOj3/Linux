using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int Base = 0x00509B74;
        public static int Health = 0xF8;

        static void Main(string[] args)
        {

            VAMemory vam = new VAMemory("ac_client");
            int Localplayer = vam.ReadInt32((IntPtr)Base);

            while (true) {

                int address = Localplayer + Health;
                vam.WriteInt32((IntPtr)address, 888);
            }
            
        }
    }
}
