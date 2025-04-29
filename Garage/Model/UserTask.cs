using Garage.Wind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Model
{
    internal class UserTask
    {
        static readonly user17Entities db = new user17Entities();
        public static user17Entities OpenDb { get { return db; } set { } }

    }
}
