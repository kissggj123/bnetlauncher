﻿// Copyright (C) 2016-2018 madalien.com
// This file is part of bnetlauncher.
//
// bnetlauncher is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// bnetlauncher is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with bnetlauncher. If not, see <http://www.gnu.org/licenses/>.
//
//
// Contact:
// daf <daf@madalien.com>

using System;

namespace bnetlauncher
{
    class BnetGame
    {
        public BnetGame(string key, string name, string alias = "")
        {
            this.Key = key;
            this.Name = name;
            this.Alias = alias;
        }

        /// <summary>
        /// The key is the parameter used by the battle.net client to launch the game
        /// using the uri handler battlenet://
        /// This key is case sensitive.
        /// </summary>
        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        /// <summary>
        /// Alias that can be used as a parameter in bnetlauncher to reference the game, usualy
        /// the common used abbreviasion for the game.
        /// This is case insensitive.
        /// </summary>
        public string Alias
        {
            get
            {
                return alias;
            }
            set
            {
                alias = value;
            }
        }

        /// <summary>
        /// The name of the game to which the key is associated to.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        private string key;
        private string name;
        private string alias;
    }
}
