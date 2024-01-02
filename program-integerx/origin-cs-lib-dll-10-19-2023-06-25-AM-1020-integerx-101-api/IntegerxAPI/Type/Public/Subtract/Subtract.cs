using Core;

namespace Core
{
    using System;

    public partial class Integerxapi
    {
        public static Integerxportable Subtract(Integerxportable left, Integerxportable right)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxsubtract.Subtract(left, right);

            return integerxResult;
        }
    }
}
