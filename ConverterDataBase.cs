using System.Collections.Generic;

namespace Convertor
{
    public class ConverterDataBase
    {
        public Dictionary<int, double> fromMetresTo = new Dictionary<int, double>(8);

        public ConverterDataBase()
        {
            fromMetresTo.Add(0, 0.001d); //km
            fromMetresTo.Add(1, 1); //m
            fromMetresTo.Add(2, 100); //cm
            fromMetresTo.Add(3, 1000); //mm
        }
    }
}
