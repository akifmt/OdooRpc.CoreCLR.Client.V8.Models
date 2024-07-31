namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PrivacyLog
{
    public virtual string date { get; set; }
    public virtual string anonymized_name { get; set; }
    public virtual string anonymized_email { get; set; }
    public virtual object user_id { get; set; }
    public virtual string execution_details { get; set; }
    public virtual string records_description { get; set; }
    public virtual string additional_note { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}