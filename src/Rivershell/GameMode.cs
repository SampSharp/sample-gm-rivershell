// RiverShell
// Copyright 2015 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Rivershell.World;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.SAMP;

namespace Rivershell
{
    public class GameMode : BaseMode
    {
        public static Team BlueTeam = new()
        {
            Id = 1,
            Color = 0x7777DDFF,
            GameTextTeamName = "~b~BLUE ~w~team",
            Target = new Vector3(2329.4226f, 532.7426f, 0.5862f),
            FixedSpectatePosition = new Vector3(2221.5820f, -273.9985f, 61.7806f),
            FixedSpectateLookAtPosition = new Vector3(2220.9978f, -273.1861f, 61.4606f),
            ResupplyPosition = new Vector3(2140.83f, -235.13f, 7.13f)
        };

        public static Team GreenTeam = new()
        {
            Id = 2,
            Color = 0x77CC77FF,
            GameTextTeamName = "~g~GREEN ~w~team",
            Target = new Vector3(2135.7368f, -179.8811f, -0.5323f),
            FixedSpectatePosition = new Vector3(2274.8467f, 591.3257f, 30.1311f),
            FixedSpectateLookAtPosition = new Vector3(2275.0503f, 590.3463f, 29.9460f),
            ResupplyPosition = new Vector3(2318.73f, 590.96f, 6.75f)
        };

        protected override void OnInitialized(EventArgs e)
        {
            Teams.Add(BlueTeam);
            Teams.Add(GreenTeam);

            SetGameModeText("Rivershell");
            ShowPlayerMarkers(0);
            ShowNameTags(true);
            Server.SetWorldTime(17);
            Server.SetWeather(11);
            UsePlayerPedAnimations();
            EnableVehicleFriendlyFire();
            SetNameTagDrawDistance(110.0f);
            DisableInteriorEnterExits();

            // Green classes
            AddPlayerClass(162, new Vector3(2117.0129f, -224.4389f, 8.15f), 0, Weapon.M4, 100, Weapon.MP5, 200, Weapon.Sniper, 10);
            AddPlayerClass(157, new Vector3(2148.6606f, -224.3336f, 8.15f), 347.1396f, Weapon.M4, 100, Weapon.MP5, 200, Weapon.Sniper, 10);

            // Blue classes
            AddPlayerClass(154, new Vector3(2352.9873f, 580.3051f, 7.7813f), 178.1424f, Weapon.M4, 100, Weapon.MP5, 200, Weapon.Sniper, 10);
            AddPlayerClass(138, new Vector3(2281.1504f, 567.6248f, 7.7813f), 163.7289f, Weapon.M4, 100, Weapon.MP5, 200, Weapon.Sniper, 10);
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("  Rivershell port");
            Console.WriteLine("  Original by Kye 2006-2013");
            Console.WriteLine("----------------------------------");

            base.OnInitialized(e);
        }
    }
}