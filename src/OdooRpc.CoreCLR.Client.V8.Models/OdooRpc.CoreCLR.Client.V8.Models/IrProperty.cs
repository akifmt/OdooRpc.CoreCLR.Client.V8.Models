using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrProperty
{
    public virtual string name { get; set; }
    public virtual string res_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object fields_id { get; set; }
    public virtual double value_float { get; set; }
    public virtual long value_integer { get; set; }
    public virtual string value_text { get; set; }
    public virtual string value_binary { get; set; }
    public virtual string value_reference { get; set; }
    public virtual string value_datetime { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}