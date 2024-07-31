using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModelConstraint
{
    public virtual string name { get; set; }
    public virtual string definition { get; set; }
    public virtual string message { get; set; }
    public virtual object model { get; set; }
    public virtual object module { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string write_date { get; set; }
    public virtual string create_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual object write_uid { get; set; }
}