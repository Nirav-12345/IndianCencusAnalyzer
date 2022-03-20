using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class StateCodedAo
    {
        public int serialNumber;
        public string statename;
        public int tin;
        public string statecode;

        public StateCodedAo(string v1, string v2, string v3, string v4)
        {
            serialNumber = Convert.ToInt32(v1);
            statename = v2;
            tin = Convert.ToInt32(v3);
            statecode = v4;
        }



    }
}
