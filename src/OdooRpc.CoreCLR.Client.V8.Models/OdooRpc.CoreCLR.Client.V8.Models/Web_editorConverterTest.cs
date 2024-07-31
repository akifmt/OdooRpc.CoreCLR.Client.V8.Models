using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Web_editorConverterTest
{
    [JsonPropertyName("char")]
    public virtual string char_ { get; set; }

    public virtual long integer { get; set; }

    [JsonPropertyName("float")]
    public virtual double float_ { get; set; }

    public virtual double numeric { get; set; }
    public virtual object many2one { get; set; }
    public virtual string binary { get; set; }
    public virtual string date { get; set; }
    public virtual string datetime { get; set; }
    public virtual string selection_str { get; set; }
    public virtual string html { get; set; }
    public virtual string text { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}