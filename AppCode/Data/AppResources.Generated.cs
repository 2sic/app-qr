// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "AppResources.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class AppResources
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: QR Code/
// User:        2sic Web-Developer
// When:        2024-04-05 08:43:06Z
namespace AppCode.Data
{
  // This is a generated class for AppResources (scope: System.App)
  // To extend/modify it, see instructions above.

  /// <summary>
  /// AppResources data. <br/>
  /// Generated 2024-04-05 08:43:06Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.PrintQrAdminHint`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  /// <remarks>
  /// This Content-Type is NOT in the default scope, so you may not see it in the Admin UI. It's in the scope System.App.
  /// </remarks>
  public partial class AppResources: AutoGenerated.ZagAppResources
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for System.App.AppResources in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagAppResources: Custom.Data.CustomItem
  {
    /// <summary>
    /// PrintQrAdminHint as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("PrintQrAdminHint", scrubHtml: true) etc.
    /// </summary>
    public string PrintQrAdminHint => _item.String("PrintQrAdminHint", fallback: "");
  }
}