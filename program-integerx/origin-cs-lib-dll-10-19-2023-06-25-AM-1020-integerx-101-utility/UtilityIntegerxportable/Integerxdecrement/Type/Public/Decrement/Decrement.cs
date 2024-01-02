using Core;

namespace Core
{
    using System;

    public partial class Integerxdecrement
    {
        public static void Decrement(Integerxportable value_INTEGERX)
        {
            try
            {
                Integerxportable.Import(value_INTEGERX);

                if (ForgeDecrementRecurse())
                {
                    Integerxportable.PositionStack.Pop();

                    Decrement(value_INTEGERX);
                }
                else
                {
                    DecrementReturn(true, false);
                }

                if (Object.Equals(Integerxportable.DigitLinkedList.Count, 1) is false)
                {
                    DecrementTrim();
                }
                else
                    "false".ToString();

                Integerxportable.Export(value_INTEGERX);
            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{IntegerxCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxfatal.Decrement().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
