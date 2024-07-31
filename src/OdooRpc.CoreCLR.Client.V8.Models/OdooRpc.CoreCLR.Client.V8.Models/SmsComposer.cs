namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SmsComposer
{
    public virtual string composition_mode { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_model_description { get; set; }
    public virtual long res_id { get; set; }
    public virtual string res_ids { get; set; }
    public virtual long res_ids_count { get; set; }
    public virtual bool comment_single_recipient { get; set; }
    public virtual bool mass_keep_log { get; set; }
    public virtual bool mass_force_send { get; set; }
    public virtual bool mass_use_blacklist { get; set; }
    public virtual long recipient_valid_count { get; set; }
    public virtual long recipient_invalid_count { get; set; }
    public virtual string recipient_single_description { get; set; }
    public virtual string recipient_single_number { get; set; }
    public virtual string recipient_single_number_itf { get; set; }
    public virtual bool recipient_single_valid { get; set; }
    public virtual string number_field_name { get; set; }
    public virtual string numbers { get; set; }
    public virtual string sanitized_numbers { get; set; }
    public virtual object template_id { get; set; }
    public virtual string body { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}