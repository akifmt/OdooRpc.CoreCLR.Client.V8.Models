namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentInvite
{
    public virtual object website_id { get; set; }
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
    public virtual string access_token { get; set; }
    public virtual string short_code { get; set; }
    public virtual bool short_code_format_warning { get; set; }
    public virtual bool short_code_unique_warning { get; set; }
    public virtual bool disable_save_button { get; set; }
    public virtual string base_book_url { get; set; }
    public virtual string book_url { get; set; }
    public virtual string redirect_url { get; set; }
    public virtual long[] appointment_type_ids { get; set; }
    public virtual string appointment_type_info_msg { get; set; }
    public virtual long appointment_type_count { get; set; }
    public virtual string schedule_based_on { get; set; }
    public virtual long[] suggested_resource_ids { get; set; }
    public virtual long suggested_resource_count { get; set; }
    public virtual long[] suggested_staff_user_ids { get; set; }
    public virtual long suggested_staff_user_count { get; set; }
    public virtual string resources_choice { get; set; }
    public virtual long[] resource_ids { get; set; }
    public virtual long[] staff_user_ids { get; set; }
    public virtual long[] calendar_event_ids { get; set; }
    public virtual long calendar_event_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string appointment_type_warning_msg { get; set; }
}