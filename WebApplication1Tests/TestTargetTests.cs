using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.TESTProfiler;

namespace WebApplication1.Tests
{
    [TestClass]
    public class TestTargetTests
    {
        private IMapper _mapper1;

        [TestMethod]
        public void TTTTest()
        {
            var tt = new TestTarget(_mapper1);
            tt.TTT();
            Assert.IsFalse(false);
        }

        [TestInitialize]
        public void TI()
        {
            _mapper1 = new MapperConfiguration(cfg =>
                                               {
                                                   cfg.AddProfile<TestProfile>();
                                                   cfg.ConstructServicesUsing(t => TestBuilder.GetInstance(t, "t"));
                                               }).CreateMapper();
        }
    }
}