using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication1.TESTProfiler;

namespace WebApplication1
{
    public class TestTarget
    {
        private IMapper _mapper;

        public TestTarget(IMapper mapper)
        {
            _mapper = mapper;
        }

        public bool TTT()
        {
            var testClassB = _mapper.Map<TestClassB>(new TestClassA("1;"));
            return true;
        }
    }
}
