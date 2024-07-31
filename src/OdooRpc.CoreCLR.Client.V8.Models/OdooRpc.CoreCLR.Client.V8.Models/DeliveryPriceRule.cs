using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DeliveryPriceRule
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object carrier_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string variable { get; set; }

    [JsonPropertyName("operator")]
    public virtual string operator_ { get; set; }

    public virtual double max_value { get; set; }
    public virtual double list_base_price { get; set; }
    public virtual double list_price { get; set; }
    public virtual string variable_factor { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}