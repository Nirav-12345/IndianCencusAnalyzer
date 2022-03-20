using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public abstract class CencusAdapter
    {
        protected string[] GetCencusData(string csvfilepath,string dataheadres)
        {
            string[] CencusData;
            if(!File.Exists(csvfilepath))
            {
                throw new CencusAnalyserException("File Not found", CencusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if(Path.GetExtension(csvfilepath!=".csv"))
            {
                throw new CencusAnalyserException("Invalid file type", CencusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            CencusData = File.ReadAllLines(csvfilepath);
            if(CencusData[0]!=dataheadres)
            {
                throw new CencusAnalyserException("Incorrect hearder", CencusAnalyserException.ExceptionType.INCORRECT_HEADER);
            }

            return CencusData;



        }

    }
}
