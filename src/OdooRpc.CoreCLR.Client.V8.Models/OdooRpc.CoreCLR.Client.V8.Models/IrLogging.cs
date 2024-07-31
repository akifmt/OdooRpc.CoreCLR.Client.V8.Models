using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrLogging
{
    public virtual long create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual long write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string name { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string dbname { get; set; }
    public virtual string level { get; set; }
    public virtual string message { get; set; }
    public virtual string path { get; set; }
    public virtual string func { get; set; }
    public virtual string line { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}