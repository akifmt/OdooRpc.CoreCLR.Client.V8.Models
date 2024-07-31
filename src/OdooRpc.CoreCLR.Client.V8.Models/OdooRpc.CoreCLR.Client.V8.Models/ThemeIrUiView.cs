using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ThemeIrUiView
{
    public virtual string name { get; set; }
    public virtual string key { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual long priority { get; set; }
    public virtual string mode { get; set; }
    public virtual bool active { get; set; }
    public virtual string arch { get; set; }
    public virtual string arch_fs { get; set; }
    public virtual string inherit_id { get; set; }
    public virtual long[] copy_ids { get; set; }
    public virtual bool customize_show { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}