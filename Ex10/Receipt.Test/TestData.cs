using System.Collections.Generic;

namespace ReceiptTests
{
    public class TestData
    {
        public static IEnumerable<object[]> Data => new List<object[]>()
        {
            new object[] {"apple", 2, 1, 2},
            new object[] {"milk", 1, 3, 3},
            new object[] {"coffee", 2, 5, 10},
            new object[] {"orange juice", 3, 2, 6}
        };
    }
}
