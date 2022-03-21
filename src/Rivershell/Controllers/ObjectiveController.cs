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
using SampSharp.GameMode.Controllers;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;

namespace Rivershell.Controllers
{
    [Controller]
    public class ObjectiveController : IEventListener
    {
        private bool _objectiveReached;

        public void RegisterEvents(BaseMode gameMode)
        {
            gameMode.PlayerEnterCheckpoint += checkpoint_Enter;
            gameMode.PlayerStateChanged += gameMode_PlayerStateChanged;
        }

        private void gameMode_PlayerStateChanged(object sender, StateEventArgs e)
        {
            var player = (Player)sender;

            switch (e.NewState)
            {
                case PlayerState.Driving:
                    if (player.Vehicle == player.Team.TargetVehicle)
                    {
                        // It's the objective vehicle
                        player.Color = 0xE2C063FF;
                        player.GameText("~w~Take the ~y~boat ~w~back to the ~r~spawn!", 3000, 5);
                        player.SetCheckpoint(player.Team.Target, 10.0f);
                    }
                    break;
                case PlayerState.OnFoot:
                    player.Color = player.Team.Color;
                    player.DisableCheckpoint();
                    break;
            }
        }
        
        private void checkpoint_Enter(object sender, EventArgs e)
        {
            var player = (Player)sender;

            var vehicle = player.Vehicle;

            //Check if game's already over
            if (_objectiveReached)
                return;

            //Check if we're in target vehicle
            if (vehicle != player.Team.TargetVehicle) return;

            // objective reached.
            player.Team.TimesCaptured++;
            player.Score += 5;

            if (player.Team.TimesCaptured == Config.CapturesToWin)
            {
                BasePlayer.GameTextForAll($"{player.Team.GameTextTeamName} wins!", 3000, 5);
                _objectiveReached = true;
                foreach (var p in Player.All)
                    p.PlaySound(1185);

                var exitTimer = new Timer(6000, false);
                exitTimer.Tick += (s, evt) =>
                {
                    foreach (var p in Player.All)
                        p.PlaySound(1186);
                    BaseMode.Instance.Exit();
                };

                exitTimer.IsRunning = true;
            }
            else
            {
                BasePlayer.GameTextForAll($"{player.Team.GameTextTeamName} captured the ~y~boat!", 3000, 5);
                vehicle.Respawn();
            }
        }
    }
}