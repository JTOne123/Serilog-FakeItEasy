using System.Collections.Generic;

namespace Serilog_FakeItEasy.SampleCoreWebApi.Data
{
    public class MockValueData
    {
        private static IEnumerable<ValueEntity> Values;

        private static IEnumerable<ValueEntity> SetValues()
        {
            if (Values != null) return Values;

            var values = new List<ValueEntity>();
            values.AddRange(new[]
            {
                new ValueEntity {Id = 1, Value = "Value1"},
                new ValueEntity {Id = 2, Value = "Value2"},
                new ValueEntity {Id = 3, Value = "Value3"},
                new ValueEntity {Id = 4, Value = "Value4"},
                new ValueEntity {Id = 5, Value = "Value5"}
            });

            return Values = values;
        }

        public static IEnumerable<ValueEntity> GetValues()
        {
            return SetValues();
        }
    }
}
