namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MaintenanceEquipmentCategory
{
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual object alias_id { get; set; }
    public virtual string alias_name { get; set; }
    public virtual object alias_domain_id { get; set; }
    public virtual string alias_domain { get; set; }
    public virtual string alias_defaults { get; set; }
    public virtual string alias_email { get; set; }
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual object technician_user_id { get; set; }
    public virtual long color { get; set; }
    public virtual string note { get; set; }
    public virtual long[] equipment_ids { get; set; }
    public virtual long equipment_count { get; set; }
    public virtual long[] maintenance_ids { get; set; }
    public virtual long maintenance_count { get; set; }
    public virtual long maintenance_open_count { get; set; }
    public virtual bool fold { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string alias_full_name { get; set; }
    public virtual object alias_model_id { get; set; }
    public virtual long alias_force_thread_id { get; set; }
    public virtual object alias_parent_model_id { get; set; }
    public virtual long alias_parent_thread_id { get; set; }
    public virtual string alias_contact { get; set; }
    public virtual bool alias_incoming_local { get; set; }
    public virtual string alias_bounced_content { get; set; }
    public virtual string alias_status { get; set; }
}