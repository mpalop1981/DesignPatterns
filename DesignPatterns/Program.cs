using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var _log = Singleton.Log.Instance;
            _log.Save("Usando log del singleton.");
            _log.Save("Usando log del singleton 2.");
        }
    }
}
