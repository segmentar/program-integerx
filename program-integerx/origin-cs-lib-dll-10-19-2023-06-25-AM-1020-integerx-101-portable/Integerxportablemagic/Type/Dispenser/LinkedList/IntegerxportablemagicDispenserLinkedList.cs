using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportablemagic
    {
        public static LinkedList<T> IntegerxportablemagicLinkedListDispenser<T>(IEnumerable<T> enumerable_VALUE)
        {
            LinkedList<T> listResult = default;

            LinkedList<T> linkedList;

            linkedList = new LinkedList<T>(enumerable_VALUE);

            listResult = linkedList;

            return listResult;
        }
    }
}
