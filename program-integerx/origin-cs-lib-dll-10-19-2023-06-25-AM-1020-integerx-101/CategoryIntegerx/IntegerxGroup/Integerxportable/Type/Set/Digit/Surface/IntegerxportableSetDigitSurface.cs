using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Object[] IntegerxportableDigitSetSurface(Char[] Digit_ARRAY)
        {
            Object[] arrayResult = default;

            var list = IntegerxportableDigitSet(Digit_ARRAY);

            var array = new Object[list.Count];

            list.CopyTo(array, IntegerxportablePolicy.IntegerxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
