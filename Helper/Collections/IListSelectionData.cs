﻿// <copyright file="IListSelectionData.cs" company="Public Domain">
//     Copyright (c) 2019 Nelson Garcia. All rights reserved. Licensed under
//     GNU Affero General Public License. See LICENSE in project root for full
//     license information, or visit https://www.gnu.org/licenses/#AGPL
// </copyright>

namespace Maseya.Helper.Collections
{
    using System.Collections;

    public interface IListSelectionData : IDictionary
    {
        IListSelection Selection { get; }

        IListSelectionData Copy();
    }
}
