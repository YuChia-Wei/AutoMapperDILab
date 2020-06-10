using System;
using System.Linq;
using System.Reflection;
using WebApplication1.TESTProfiler;

namespace WebApplication1.Tests
{
    public static class TestBuilder
    {
        public static object GetInstance(Type type, string s)
        {
            //return Activator.CreateInstance(type, s);
            if (typeof(TResolver) == type)
            {
                return new TResolver(s);
            }

            if (typeof(TResolverB) == type)
            {
                return new TResolverB(s);
            }

            return new TResolverB(s);
        }
    }
}