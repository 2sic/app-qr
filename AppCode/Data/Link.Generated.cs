// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Link.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Link
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: QR Code/
// User:        2sic Web-Developer
// When:        2024-04-05 08:43:06Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Link 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Link data. <br/>
  /// Generated 2024-04-05 08:43:06Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.DisplayLinkOrTitle`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Link: AutoGenerated.ZagLink
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.Link in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagLink: Custom.Data.CustomItem
  {
    /// <summary>
    /// DisplayLinkOrTitle as bool. <br/>
    /// To get nullable use .Get("DisplayLinkOrTitle") as bool?;
    /// </summary>
    public bool DisplayLinkOrTitle => _item.Bool("DisplayLinkOrTitle");

    /// <summary>
    /// Link as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Link")
    /// </summary>
    public string Link => _item.Url("Link");

    /// <summary>
    /// LinkCurrentPage as bool. <br/>
    /// To get nullable use .Get("LinkCurrentPage") as bool?;
    /// </summary>
    public bool LinkCurrentPage => _item.Bool("LinkCurrentPage");

    /// <summary>
    /// Get the file object for Link - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile LinkFile => _item.File("Link");

    /// <summary>
    /// Get the folder object for Link.
    /// </summary>
    public IFolder LinkFolder => _item.Folder("Link");

    /// <summary>
    /// NotesInternal as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("NotesInternal", scrubHtml: true) etc.
    /// </summary>
    public string NotesInternal => _item.String("NotesInternal", fallback: "");

    /// <summary>
    /// QrCodeSettings as single item of QrCodeSettings.
    /// </summary>
    /// <remarks>
    /// Generated to only return 1 child because field settings had Multi-Value=false. The type QrCodeSettings was specified in the field settings.
    /// </remarks>
    /// <returns>
    /// A single item OR null if nothing found, so you can use ?? to provide alternate objects.
    /// </returns>
    public QrCodeSettings QrCodeSettings => _qrCodeSettings ??= _item.Child<QrCodeSettings>("QrCodeSettings");
    private QrCodeSettings _qrCodeSettings;

    /// <summary>
    /// Title as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Title", scrubHtml: true) etc.
    /// </summary>
    /// <remarks>
    /// This hides base property Title.
    /// To access original, convert using AsItem(...) or cast to ITypedItem.
    /// Consider renaming this field in the underlying content-type.
    /// </remarks>
    public new string Title => _item.String("Title", fallback: "");

    /// <summary>
    /// VarOverrideQrSettings as bool. <br/>
    /// To get nullable use .Get("VarOverrideQrSettings") as bool?;
    /// </summary>
    public bool VarOverrideQrSettings => _item.Bool("VarOverrideQrSettings");
  }
}