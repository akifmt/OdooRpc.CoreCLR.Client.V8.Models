namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrAttendance
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
    public virtual object employee_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual string check_in { get; set; }
    public virtual string check_out { get; set; }
    public virtual double worked_hours { get; set; }
    public virtual long color { get; set; }
    public virtual double overtime_hours { get; set; }
    public virtual double in_latitude { get; set; }
    public virtual double in_longitude { get; set; }
    public virtual string in_country_name { get; set; }
    public virtual string in_city { get; set; }
    public virtual string in_ip_address { get; set; }
    public virtual string in_browser { get; set; }
    public virtual string in_mode { get; set; }
    public virtual double out_latitude { get; set; }
    public virtual double out_longitude { get; set; }
    public virtual string out_country_name { get; set; }
    public virtual string out_city { get; set; }
    public virtual string out_ip_address { get; set; }
    public virtual string out_browser { get; set; }
    public virtual string out_mode { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual double overtime_progress { get; set; }
}