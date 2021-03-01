using OpenMod.API;
using OpenMod.API.Permissions;
using OpenMod.API.Plugins;
using OpenMod.Core.Plugins;
using System;
using System.Threading.Tasks;

[assembly: PluginMetadata("SilK.CooldownQuickFix", Author = "SilK", DisplayName = "Cooldown Quick Fix")]
namespace CooldownQuickFix
{
    public class CooldownQuickFixPlugin : OpenModUniversalPlugin
    {
        public CooldownQuickFixPlugin(
            IRuntime runtime,
            IPermissionRegistry permissionRegistry,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            permissionRegistry.RegisterPermission(runtime, "cooldowns.immune", "Grants immunity to all command cooldowns.");
        }

        protected override Task OnLoadAsync()
        {
            return Task.CompletedTask;
        }

        protected override Task OnUnloadAsync()
        {
            return Task.CompletedTask;
        }
    }
}