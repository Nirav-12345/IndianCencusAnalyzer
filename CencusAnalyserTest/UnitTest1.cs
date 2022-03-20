using NUnit.Framework;

namespace IndianStateCencusAnalyzer
{
    public class Tests
    {
        static string IndianStateCencusHeaders = "State,population,areadInSqr,DensityPereSq";
        static string IndianStateCodeHeaders = "SrNo,StateName,TIN,stateCode";
        static string indianStateCencusfilepath = @"C:\Users\Nirav Raj\Desktop\day29\IndianStateCencusAnalyzer/india-districts-census-2011.csv";
        static string indianStateCencusfilepath1 = @"C:\Users\Nirav Raj\Desktop\day29\IndianStateCencusAnalyzer/india-districts-census-201.csv";
        static string indianStateCencusfilepath2 = @"C:\Users\Nirav Raj\Desktop\day29\IndianStateCencusAnalyzer/india-districts-census-2011.txt";
        static string indianStateCencusfilepath4 = @"C:\Users\Nirav Raj\Desktop\day29\IndianStateCencusAnalyzer/india-districts-census-2011.csv";
        static string indianStateCencusfilepath5 = @"C:\Users\Nirav Raj\Desktop\day29\IndianStateCencusAnalyzer/india-districts-census-2011.csv";



        IndianStateCencusAnalyzer.CencusAnalyser cencusAnalyser;
        Dictionary<string, CencusDTO> totalrecord;
        Dictionary<string, CencusDTO>staterecord;


        [SetUp]

        public void SetUp()
        {
            cencusAnalyser = new IndianStateCencusAnalyzer.CencusAnalyser();
            totalrecord = Dictionary<string, CencusDTO>();
            staterecord = Dictionary<string, CencusDTO>();
        }

        [Test]

        //tc 1.1
        public void Give_Indian_cencusdatafile_whenreaded_ShouldRetutn_cencusdataCount()
        {
            totalrecord = cencusAnalyser.LoadCencusData(Country.Indaia, indianStateCencusfilepath, IndianStateCencusHeaders);
            staterecord = cencusAnalyser.LoadCencusData(Country.Indaia, indianStateCencusfilepath, IndianStateCencusHeaders);
            Assert.AreEqual(29, totalrecord.Count);
            Assert.AreEqual(30, staterecord.Count);
        }
        [Test]
        //tc 1.2
        public void Give_Wrong_indian_state_Should_throw_Exception()
        {
            var cencusException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            var stateException= Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            Assert.AreEqual(CencusAnalyserException.ExceptionType.FILE_NOT_FOUND, cencusException.eType);
            Assert.AreEqual(CencusAnalyserException.ExceptionType.FILE_NOT_FOUND, stateException.eType);

        }

        [Test]
        //tc 1.3
        public void Given_Wrong_fileType_return_Error()
        {
            var cencusException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            var stateException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INVALID_FILE_TYPE, cencusException.eType);
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INVALID_FILE_TYPE, stateException.eType);
        }

        [Test]//1.4
        public void Given_indian_When_notproper_should_return_exception()
        {
            var cencusException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, delimeterIndiaStateCencusfilepath, IndianStateCencusHeaders));
            var stateException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, dilimeterIndiaStateCencusfilepath, IndianStateCencusHeaders));
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INCORRECT_DELIMETER, cencusException.eType);
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INCORRECT_DELIMETER, stateException.eType);
        }
        [Test] //tc 1.5
        public void Give_Indian_Wrong_should_return_exception()
        {
            var cencusException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            var stateException = Assert.Throws<CencusAnalyserException>(() => cencusAnalyser.LoadCencusData(country INDIA, WrongIndiaStateCencusfilepath, IndianStateCencusHeaders));
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INCORRECT_HEADER, cencusException.eType);
            Assert.AreEqual(CencusAnalyserException.ExceptionType.INCORRECT_HEADER, stateException.eType);
        }
    }
}