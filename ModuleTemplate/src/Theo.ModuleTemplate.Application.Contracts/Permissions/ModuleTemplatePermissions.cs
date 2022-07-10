using Volo.Abp.Reflection;

namespace Theo.ModuleTemplate.Permissions;

public class ModuleTemplatePermissions
{
    public const string GroupName = "ModuleTemplate";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModuleTemplatePermissions));
    }
}
