namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsRequest_wizard
{
    public virtual string name { get; set; }
    public virtual object requestee_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object folder_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual long res_id { get; set; }
    public virtual string activity_note { get; set; }
    public virtual long activity_date_deadline_range { get; set; }
    public virtual string activity_date_deadline_range_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}