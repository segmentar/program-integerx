using Core;

namespace Core
{
    using System;

    public partial class Integerxdecrement
    {
        public static void DecrementDeshuffle()
        {
            try
            {
                Integerxportable.DigitLinkedList.RemoveFirst();

            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{IntegerxCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxfatal.DecrementDeshuffle().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
