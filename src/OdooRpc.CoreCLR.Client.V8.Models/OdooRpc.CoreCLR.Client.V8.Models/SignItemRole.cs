using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignItemRole
{
    public virtual string name { get; set; }
    public virtual long color { get; set; }

    [JsonPropertyName("default")]
    public virtual bool default_ { get; set; }

    public virtual long sequence { get; set; }
    public virtual string auth_method { get; set; }
    public virtual bool change_authorized { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}