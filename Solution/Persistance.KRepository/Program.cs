using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.KRepository
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                Logger.Trace("Trace: 0");
                Logger.Debug("Debug: 0");
                Logger.Trace("Trace: 0");
                Logger.Trace("Trace: 0");
                Logger.Trace("Trace: 0");
                Logger.Trace("Trace: 0");

                System.Console.ReadKey();
            }
            catch (Exception ex)
            {

                Logger.Error(ex, "Goodbye cruel world");
            }
        }
    }
}
