﻿using System;

namespace Gum.Plugins
{
    public enum PluginShutDownReason
    {
        UserDisabled,
        PluginException,
        PluginInitiated,
        GumxUnload,
        GumShutDown
    }

    public interface IPlugin
    {
        string FriendlyName { get; }
        string UniqueId { get; set; }
        Version Version { get; }
        void StartUp();
        bool ShutDown(PluginShutDownReason shutDownReason);
    }
}
