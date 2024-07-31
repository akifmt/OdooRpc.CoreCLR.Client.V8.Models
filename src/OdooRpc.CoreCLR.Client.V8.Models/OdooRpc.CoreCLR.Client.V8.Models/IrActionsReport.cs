using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrActionsReport
{
    public virtual string name { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string xml_id { get; set; }
    public virtual string path { get; set; }
    public virtual string help { get; set; }
    public virtual object binding_model_id { get; set; }
    public virtual string binding_type { get; set; }
    public virtual string binding_view_types { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string model { get; set; }
    public virtual object model_id { get; set; }
    public virtual string report_type { get; set; }
    public virtual string report_name { get; set; }
    public virtual string report_file { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual bool multi { get; set; }
    public virtual object paperformat_id { get; set; }
    public virtual string print_report_name { get; set; }
    public virtual bool attachment_use { get; set; }
    public virtual string attachment { get; set; }
}