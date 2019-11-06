﻿// <copyright file="DarkMountain.cs" company="Public Domain">
//     Copyright (c) 2019 Nelson Garcia. All rights reserved. Licensed under
//     GNU Affero General Public License. See LICENSE in project root for full
//     license information, or visit https://www.gnu.org/licenses/#AGPL
// </copyright>

namespace Maseya.MushROMs.Zelda3.Palette
{
    using System;
    using Maseya.Helper.Collections;

    public class DarkMountain : SelectionCollection
    {
        public DarkMountain(PaletteSelectionBuilder builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.AddBox(15, 0, 4, 3);
            builder.AddRow(15, 6, 1);
            builder.AddRow(17, 4, 3);
            builder.AddRow(19, 6, 1);
            builder.AddRow(85, 0, 4);
            builder.AddRow(85, 6, 1);
            builder.AddRow(89, 0, 4);
            WallsAndAbyss = builder.CreatePaletteSelection();

            builder.AddRow(15, 4, 2);
            builder.AddBox(18, 5, 2, 2);
            builder.AddColumn(45, 5, 3);
            builder.AddColumn(88, 5, 2);
            Ground = builder.CreatePaletteSelection();

            builder.AddRow(16, 4, 3);
            builder.AddColumn(45, 6, 3);
            builder.AddRow(47, 4, 1);
            builder.AddRow(85, 4, 2);
            builder.AddRow(89, 4, 1);
            builder.AddRow(89, 6, 1);
            Clouds = builder.CreatePaletteSelection();

            builder.AddRow(18, 0, 5);
            ShiniesAndRocks = builder.CreatePaletteSelection();

            builder.AddRow(19, 0, 5);
            builder.AddRow(19, 6, 1);
            PostsAndSteaks = builder.CreatePaletteSelection();

            builder.AddRow(86, 0, 7);
            Lava = builder.CreatePaletteSelection();

            builder.AddBox(45, 1, 4, 2);
            builder.AddRow(47, 1, 3);
            TurtleRock = builder.CreatePaletteSelection();

            builder.AddRow(87, 1, 1);
            builder.AddRow(87, 6, 1);
            GanonsTowerHighlight = builder.CreatePaletteSelection();

            builder.AddRow(87, 0, 1);
            builder.AddRow(87, 2, 4);
            GanonsTowerPrimary = builder.CreatePaletteSelection();
        }

        public IListSelection Ground
        {
            get;
        }

        public IListSelection Clouds
        {
            get;
        }

        public IListSelection WallsAndAbyss
        {
            get;
        }

        public IListSelection ShiniesAndRocks
        {
            get;
        }

        public IListSelection PostsAndSteaks
        {
            get;
        }

        public IListSelection TurtleRock
        {
            get;
        }

        public IListSelection Lava
        {
            get;
        }

        public IListSelection GanonsTowerPrimary
        {
            get;
        }

        public IListSelection GanonsTowerHighlight
        {
            get;
        }

        public override IListSelection[] AllSelections()
        {
            return new IListSelection[]
            {
                Ground,
                Clouds,
                WallsAndAbyss,
                ShiniesAndRocks,
                PostsAndSteaks,
                TurtleRock,
                Lava,
                GanonsTowerPrimary,
                GanonsTowerHighlight,
            };
        }
    }
}