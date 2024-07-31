using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrActionsAct_window
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
    public virtual object view_id { get; set; }
    public virtual string domain { get; set; }
    public virtual string context { get; set; }
    public virtual long res_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual string target { get; set; }
    public virtual string view_mode { get; set; }
    public virtual string mobile_view_mode { get; set; }
    public virtual string usage { get; set; }
    public virtual long[] view_ids { get; set; }
    public virtual string views { get; set; }
    public virtual long limit { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual object search_view_id { get; set; }
    public virtual bool filter { get; set; }
}