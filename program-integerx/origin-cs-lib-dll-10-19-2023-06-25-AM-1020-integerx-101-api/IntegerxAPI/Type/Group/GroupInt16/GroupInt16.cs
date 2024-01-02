using Core;

namespace Core
{
    using System;

    public partial class Integerxapi
    {
        public static Int16 GroupInt16(Integerxportable integerx)
        {
            Int16 integerResult = default;

            integerResult = Integerxhost.GroupInt16(integerx);

            return integerResult;
        }
    }
}
