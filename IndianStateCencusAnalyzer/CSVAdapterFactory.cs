using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class CSVAdapterFactory
    {
        public Dictionary<string, CencusDTO> loadCsvdata(CencusAnalyser.Country country, string csvfilepath, string dataHeaders)
        {
            switch (country)
            {
                case (CencusAnalyser.Country.INDIA):
                    return new IndianCencusAdapter().LoadCencusData(csvfilepath, dataHeaders);

                default:
                    throw new CencusAnalyserException("NO Such COuntry", CencusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }






    }
}
