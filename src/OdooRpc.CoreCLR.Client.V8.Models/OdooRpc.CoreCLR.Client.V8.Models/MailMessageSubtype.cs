using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailMessageSubtype
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }

    [JsonPropertyName("internal")]
    public virtual bool internal_ { get; set; }

    public virtual object parent_id { get; set; }
    public virtual string relation_field { get; set; }
    public virtual string res_model { get; set; }

    [JsonPropertyName("default")]
    public virtual bool default_ { get; set; }

    public virtual long sequence { get; set; }
    public virtual bool hidden { get; set; }
    public virtual bool track_recipients { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}