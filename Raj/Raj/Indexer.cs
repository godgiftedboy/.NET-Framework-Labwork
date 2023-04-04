using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raj
{
    partial class Indexer
    {
        public string[] names = new string[5];
        public string this[int i] 
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
    partial class Indexer
    {
        //public string college;
        /*
        public string[] names = new string[5];
        public string this[int i] 
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        */
    }
}
