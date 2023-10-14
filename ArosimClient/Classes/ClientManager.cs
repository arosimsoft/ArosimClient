using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArosimClient.Classes
{
    class ClientManager
    {
        public static List<Joint> jointsList = new List<Joint>();

        public static AutoResetEvent coordsSignal = new AutoResetEvent(false);
    }
}
