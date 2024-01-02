using Core;

namespace Core
{
    using System;

    public partial class Integerxincrement
    {
        public static void Increment(Integerxportable value_INTEGERX)
        {
            try
            {
                Integerxportable.Import(value_INTEGERX);

                if (ForgeIncrementRecurse())
                {
                    Integerxportable.PositionStack.Pop();

                    Increment(value_INTEGERX);
                }
                else
                {
                    IncrementReturn(true, false);
                }

                if (ForgeIncrementShuffleShould() is true)
                {
                    IncrementShuffle();
                }
                else
                    "false".ToString();

                Integerxportable.Export(value_INTEGERX);
            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{IntegerxCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxfatal.Increment().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
