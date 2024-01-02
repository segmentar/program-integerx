using Core;

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public Integerxportable Result { get; set; } = default;

        public IntegerxportableSimple()
        {
            return;
        }

        ~IntegerxportableSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public IntegerxportableSimple(String Integerx_VALUE)
        {
            var parse = Integerxportable.Parse(Integerx_VALUE);

            var result = Integerxportable.IntegerxportableMakeDefaultSurface(parse, false);

            this.Result = result;

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public IntegerxportableSimple(String Integerx_VALUE, Boolean answer_SIGN_is)
        {
            var parse = Integerxportable.Parse(Integerx_VALUE);

            var result = Integerxportable.IntegerxportableMakeDefaultSurface(parse, answer_SIGN_is);

            this.Result = result;
            
            return;
        }
    }
}
