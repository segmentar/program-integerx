﻿using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public Integerxportable(Object digitLinkedListObject, Object positionStackObject, Boolean answer_SIGN_is, Boolean answer_DEBUG_is)
        {
            this.DigitLinkedListObject = digitLinkedListObject;

            this.PositionStackObject = positionStackObject;

            if (answer_SIGN_is is true)
            {
                this.IsSign = true;
            }
            else
                "false".ToString();

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
