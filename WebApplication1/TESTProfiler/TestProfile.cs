using AutoMapper;

namespace WebApplication1.TESTProfiler
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<TestClassA, TestClassB>()
                .ForMember(a => a.Member, b => b.MapFrom<TResolver>())
                .ForMember(a => a.Membe, b => b.MapFrom<TResolverB>());
        }
    }

    public class TResolverB : IValueResolver<TestClassA, TestClassB, string>
    {
        public TResolverB(string a)
        {
        }

        public string Resolve(TestClassA source, TestClassB destination, string destMember, ResolutionContext context)
        {
            return "B'";
        }
    }

    public class TResolver : IValueResolver<TestClassA, TestClassB, string>
    {
        public TResolver(string s)
        {
        }

        public string Resolve(TestClassA source, TestClassB destination, string destMember, ResolutionContext context)
        {
            return "wtf";
        }
    }

    public class TestClassA
    {
        public TestClassA(string member)
        {
            Member = member;
        }

        public string Member { get; set; }
        public string Membe { get; set; }
    }

    public class TestClassB
    {
        public string Member { get; set; }
        public string Membe { get; set; }
    }

    public class TestClassC
    {
        public string Member { get; set; }
    }

    public class TestClassD
    {
        public string Member { get; set; }
    }
}