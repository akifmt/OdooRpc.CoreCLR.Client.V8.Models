namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SmsTemplate
{
    public virtual string template_fs { get; set; }
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string name { get; set; }
    public virtual object model_id { get; set; }
    public virtual string model { get; set; }
    public virtual string body { get; set; }
    public virtual object sidebar_action_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}