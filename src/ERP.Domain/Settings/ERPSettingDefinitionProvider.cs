using Volo.Abp.Settings;

namespace ERP.Settings;

public class ERPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ERPSettings.MySetting1));
    }
}
