﻿using Core;

namespace Core
{
    using System;

    public partial class Integerxapi
    {
        public static Integerxportable Increment(Integerxportable integerx)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxincrement.IncrementControl(integerx);

            return integerxResult;
        }
    }
}
