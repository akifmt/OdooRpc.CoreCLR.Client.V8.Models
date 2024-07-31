namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModel
{
    public virtual string name { get; set; }
    public virtual string model { get; set; }
    public virtual string order { get; set; }
    public virtual string info { get; set; }
    public virtual long[] field_id { get; set; }
    public virtual long[] inherited_model_ids { get; set; }
    public virtual string state { get; set; }
    public virtual long[] access_ids { get; set; }
    public virtual long[] rule_ids { get; set; }
    public virtual bool transient { get; set; }
    public virtual string modules { get; set; }
    public virtual long[] view_ids { get; set; }
    public virtual long count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_mail_thread { get; set; }
    public virtual bool is_mail_activity { get; set; }
    public virtual bool is_mail_blacklist { get; set; }
    public virtual bool is_mail_thread_sms { get; set; }
    public virtual bool website_form_access { get; set; }
    public virtual object website_form_default_field_id { get; set; }
    public virtual string website_form_label { get; set; }
    public virtual string website_form_key { get; set; }
}