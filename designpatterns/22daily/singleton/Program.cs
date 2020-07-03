using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TheBell bell = TheBell.Instance;
            bell.Ring();
        }
    }
}
