//Code for Controls/PlayerJoinView (Container)
using GumRuntime;
using GumFormsSample.Components;
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using System.Linq;

using MonoGameGum.GueDeriving;
namespace GumFormsSample.Components
{
    public partial class PlayerJoinViewRuntime:ContainerRuntime
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        public static void RegisterRuntimeType()
        {
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PlayerJoinView", typeof(PlayerJoinViewRuntime));
        }
        public ContainerRuntime InnerPanelInstance { get; protected set; }
        public PlayerJoinViewItemRuntime PlayerJoinViewItem1 { get; protected set; }
        public PlayerJoinViewItemRuntime PlayerJoinViewItem2 { get; protected set; }
        public PlayerJoinViewItemRuntime PlayerJoinViewItem3 { get; protected set; }
        public PlayerJoinViewItemRuntime PlayerJoinViewItem4 { get; protected set; }

        public PlayerJoinViewRuntime(bool fullInstantiation = true, bool tryCreateFormsObject = true)
        {
            if(fullInstantiation)
            {
                var element = ObjectFinder.Self.GetElementSave("Controls/PlayerJoinView");
                element?.SetGraphicalUiElement(this, global::RenderingLibrary.SystemManagers.Default);
            }



        }
        public override void AfterFullCreation()
        {
            InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as ContainerRuntime;
            PlayerJoinViewItem1 = this.GetGraphicalUiElementByName("PlayerJoinViewItem1") as PlayerJoinViewItemRuntime;
            PlayerJoinViewItem2 = this.GetGraphicalUiElementByName("PlayerJoinViewItem2") as PlayerJoinViewItemRuntime;
            PlayerJoinViewItem3 = this.GetGraphicalUiElementByName("PlayerJoinViewItem3") as PlayerJoinViewItemRuntime;
            PlayerJoinViewItem4 = this.GetGraphicalUiElementByName("PlayerJoinViewItem4") as PlayerJoinViewItemRuntime;
            CustomInitialize();
        }
        //Not assigning variables because Object Instantiation Type is set to By Name rather than Fully In Code
        partial void CustomInitialize();
    }
}
