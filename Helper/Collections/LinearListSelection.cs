﻿// <copyright file="LinearListSelection.cs" company="Public Domain">
//     Copyright (c) 2019 Nelson Garcia. All rights reserved. Licensed under
//     GNU Affero General Public License. See LICENSE in project root for full
//     license information, or visit https://www.gnu.org/licenses/#AGPL
// </copyright>

namespace Maseya.Helper.Collections
{
    using System;
    using System.Collections.Generic;

    public class LinearListSelection : ListSelection
    {
        public LinearListSelection(int index, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            MinIndex = index;
            Count = count;
        }

        public override int Count
        {
            get;
        }

        public override int MinIndex
        {
            get;
        }

        public override int MaxIndex
        {
            get
            {
                return MinIndex + Count - 1;
            }
        }

        public override int this[int index]
        {
            get
            {
                if (!ContainsIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return MinIndex + index;
            }
        }

        public override ListSelection Move(int amount)
        {
            return new LinearListSelection(MinIndex + amount, Count);
        }

        public override bool ContainsIndex(int index)
        {
            return (index >= 0) && (index <= Count);
        }

        public override IEnumerator<int> GetEnumerator()
        {
            for (var i = MinIndex; i <= MaxIndex; i++)
            {
                yield return i;
            }
        }
    }
}
