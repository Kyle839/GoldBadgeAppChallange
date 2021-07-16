using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outings.Console
{
    class OutingsProgramUI
    {
        private readonly OutingsRepository outingsrepo = OutingsRepository();
        bool keepProgramRunning = true;
        public void Run()
        {
            outingsrepo.InitilizeDataTable();
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine()
            }
        }
    }
}
