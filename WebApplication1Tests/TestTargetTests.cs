using System;
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
                                                   cfg.ConstructServicesUsing(t => testBilder.GetInsten(t, "t"));
                                                   //cfg.ConstructServicesUsing(t => new TResolverB("t"));
                                                   //cfg.ConstructServicesUsing(t => new TResolver("t"));
                                               }).CreateMapper();
        }
    }

    public static class testBilder
    {
        public static object GetInsten(Type type, string s)
        {
            return Activator.CreateInstance(type, s);
            if (typeof(TResolver) == type)
            {
                return new TResolver(s);
            }

            if (typeof(TResolverB) == type)
            {
                return new TResolverB("");
            }

            return new TResolverB("");
        }
    }
}