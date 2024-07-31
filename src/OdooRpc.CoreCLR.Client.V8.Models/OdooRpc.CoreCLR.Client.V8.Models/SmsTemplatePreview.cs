namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SmsTemplatePreview
{
    public virtual object sms_template_id { get; set; }
    public virtual string lang { get; set; }
    public virtual object model_id { get; set; }
    public virtual string body { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual bool no_record { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}