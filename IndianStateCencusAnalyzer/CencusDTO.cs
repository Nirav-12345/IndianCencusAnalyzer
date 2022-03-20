using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class CencusDTO
    {
        public int serialNumber;
        public string statename;
        public string state;
        public int tin;
        public string statecode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalarea;
        public double waterarea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public StateCodedAo(StateCodedAo statecode)
        {
            this.serialNumber = statecode.serialNumber;
            this.statename = statecode.statename;
            this.tin = statecode.tin;
            this.statecode = statecode.statecode;
        }

        public CencusDataDao(CencusDataDao cenusDataDao)
        {
            this.state = cenusDataDao.state;
            this.population = cenusDataDao.population;
            this.area = cenusDataDao.area;
            this.density = cenusDataDao.density;
        }
        
            

    }
}
