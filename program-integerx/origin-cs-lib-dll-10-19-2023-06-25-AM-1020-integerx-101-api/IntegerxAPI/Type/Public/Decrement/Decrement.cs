using Core;

namespace Core
{
    using System;

    public partial class Integerxapi
    {
        public static Integerxportable Decrement(Integerxportable integerx)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxdecrement.DecrementControl(integerx);

            return integerxResult;
        }
    }
}
