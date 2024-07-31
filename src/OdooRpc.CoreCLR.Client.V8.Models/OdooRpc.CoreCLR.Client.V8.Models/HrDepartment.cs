namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrDepartment
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
    public virtual string name { get; set; }
    public virtual string complete_name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual object manager_id { get; set; }
    public virtual long[] member_ids { get; set; }
    public virtual long total_employee { get; set; }
    public virtual long[] jobs_ids { get; set; }
    public virtual long[] plan_ids { get; set; }
    public virtual long plans_count { get; set; }
    public virtual string note { get; set; }
    public virtual long color { get; set; }
    public virtual string parent_path { get; set; }
    public virtual object master_department_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}