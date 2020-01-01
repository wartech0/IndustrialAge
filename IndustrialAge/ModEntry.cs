using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace IndustrialAge
{
    class ModEntry : Mod
    {

        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.GameLaunched += GameLoop_GameLaunched;
            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;
            helper.Events.GameLoop.DayStarted += GameLoop_DayStarted;
            helper.Events.Input.ButtonPressed += Input_ButtonPressed;
            helper.Events.World.ObjectListChanged += ObjectListChanged;
            helper.Events.World.LocationListChanged += LocationsListChanged;
            helper.Events.World.ChestInventoryChanged += ChestInventoryChanged;
        }

        private void LocationsListChanged(object sender, LocationListChangedEventArgs e)
        {
        }

        private void ObjectListChanged(object sender, ObjectListChangedEventArgs e)
        {
        }

        private void ChestInventoryChanged(object sender, ChestInventoryChangedEventArgs e)
        {
            foreach (ItemStackChange item in e.Changes)
                this.Monitor.Log("Chest Location: " + e.Chest.TileLocation + " Item Changes: " + item.ToString());
        }

        private void GameLoop_GameLaunched(object sender, GameLaunchedEventArgs e)
        {

        }

        private void GameLoop_SaveLoaded(object sender, SaveLoadedEventArgs e)
        {

        }

        private void GameLoop_DayStarted(object sender, DayStartedEventArgs e)
        {

        }

        private void Input_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {

        }
    }
}
