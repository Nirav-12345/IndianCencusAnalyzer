using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class CencusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }

        Dictionary<string, CencusDTO> dataMap;
        public Dictionary<string, CencusDTO> LoadCencusData(Country country, string csvfilepath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().loadCsvdata(country, csvfilepath, dataHeaders);
            return dataMap;
        }





    }


        
}
