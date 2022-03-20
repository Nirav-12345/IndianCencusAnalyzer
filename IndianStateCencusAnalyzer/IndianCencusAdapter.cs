using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class IndianCencusAdapter:CencusAdapter
    {
        string[] CencusData;

        Dictionary<string, CencusDTO> dataMap;
        public Dictionary<string, CencusDTO> LoadCencusData(string csvfilepath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CencusDTO>();
            CencusData = GetCencusData(csvfilepath, dataHeaders);
            foreach(string data in CencusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CencusAnalyserException("File Contains wrong delimntor", CencusAnalyserException.ExceptionType.INCORRECT_DELIMETER);
                }
                string[] column = data.Split(",");
                if (csvfilepath.Contains("IndianStateCode.csv"))
                
                    dataMap.Add(column[1], new CencusDTO(new StateCodedAo(column[0], column[1], column[2], column[3])));
                if (csvfilepath.Contains("IndianStateCencusdata.csv"))

                    dataMap.Add(column[0], new CencusDTO(new StateCodedAo(column[0], column[1], column[2], column[3])));

            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }


    }
}
