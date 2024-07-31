using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BarcodeRule
{
    public virtual string name { get; set; }
    public virtual object barcode_nomenclature_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual string encoding { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string pattern { get; set; }
    public virtual string alias { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_gs1_nomenclature { get; set; }
    public virtual string gs1_content_type { get; set; }
    public virtual bool gs1_decimal_usage { get; set; }
    public virtual object associated_uom_id { get; set; }
}