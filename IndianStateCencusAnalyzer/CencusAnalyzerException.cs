using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCencusAnalyzer
{
    public class CencusAnalyserException:Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,INVALID_FILE_TYPE,INCORRECT_DELIMETER,INCORRECT_HEADER,NO_SUCH_COUNTRY
        }

        public ExceptionType eType;
        public CencusAnalyserException(string message,ExceptionType exceptionType):base(message)
        {
            this.eType = exceptionType;
        }

    }
}
