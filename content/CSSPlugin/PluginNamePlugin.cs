using CounterStrikeSharp.API.Core;

namespace PluginNamePlugin;

public class PluginNamePlugin : BasePlugin
{
  public override string ModuleName => "PluginName";
  public override string ModuleVersion => "0.1.0";

  public override void Load(bool hotReload)
  {
    Console.WriteLine("Hello World!");
  }
}
