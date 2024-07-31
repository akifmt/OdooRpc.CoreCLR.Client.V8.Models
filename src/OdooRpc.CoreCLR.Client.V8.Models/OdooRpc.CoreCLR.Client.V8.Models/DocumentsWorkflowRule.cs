namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsWorkflowRule
{
    public virtual object domain_folder_id { get; set; }
    public virtual string name { get; set; }
    public virtual string note { get; set; }
    public virtual long sequence { get; set; }
    public virtual string condition_type { get; set; }
    public virtual string domain { get; set; }
    public virtual object criteria_partner_id { get; set; }
    public virtual object criteria_owner_id { get; set; }
    public virtual long[] required_tag_ids { get; set; }
    public virtual long[] excluded_tag_ids { get; set; }
    public virtual bool limited_to_single_record { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual long[] tag_action_ids { get; set; }
    public virtual object folder_id { get; set; }
    public virtual string create_model { get; set; }
    public virtual object link_model { get; set; }
    public virtual bool remove_activities { get; set; }
    public virtual bool activity_option { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual long activity_date_deadline_range { get; set; }
    public virtual string activity_date_deadline_range_type { get; set; }
    public virtual string activity_note { get; set; }
    public virtual bool has_owner_activity { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object journal_id { get; set; }
    public virtual long[] suitable_journal_ids { get; set; }
    public virtual bool display_journal_id { get; set; }
    public virtual string move_type { get; set; }
}