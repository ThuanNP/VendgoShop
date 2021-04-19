using Btv.Vendgo.EntityFrameworkCore;

namespace Btv.Vendgo.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly VendgoDbContext _context;

        public TestDataBuilder(VendgoDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}