﻿using Artemis.Core;
using Artemis.Plugins.Games.TruckSimulator.ViewModels;
using Artemis.UI.Shared;

namespace Artemis.Plugins.Games.TruckSimulator
{
    public class Bootstrapper : PluginBootstrapper
    {
        public override void OnPluginLoaded(Plugin plugin)
        {
            plugin.ConfigurationDialog = new PluginConfigurationDialog<TruckSimulatorConfigurationViewModel>();
        }
    }
}
