namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SlideChannelPartner
{
    public virtual bool active { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string member_status { get; set; }
    public virtual long completion { get; set; }
    public virtual long completed_slides_count { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_email { get; set; }
    public virtual object channel_user_id { get; set; }
    public virtual string channel_type { get; set; }
    public virtual string channel_visibility { get; set; }
    public virtual string channel_enroll { get; set; }
    public virtual object channel_website_id { get; set; }
    public virtual object next_slide_id { get; set; }
    public virtual string invitation_link { get; set; }
    public virtual string last_invitation_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long nbr_certification { get; set; }
    public virtual bool survey_certification_success { get; set; }
}