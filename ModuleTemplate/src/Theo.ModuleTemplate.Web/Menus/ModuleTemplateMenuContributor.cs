using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Theo.ModuleTemplate.Web.Menus;

public class ModuleTemplateMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ModuleTemplateMenus.Prefix, displayName: "ModuleTemplate", "~/ModuleTemplate", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
