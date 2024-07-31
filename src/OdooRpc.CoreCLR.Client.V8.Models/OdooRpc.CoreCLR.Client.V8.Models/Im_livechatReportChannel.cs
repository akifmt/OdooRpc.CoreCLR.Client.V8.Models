namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Im_livechatReportChannel
{
    public virtual string uuid { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string channel_name { get; set; }
    public virtual string technical_name { get; set; }
    public virtual object livechat_channel_id { get; set; }
    public virtual string start_date { get; set; }
    public virtual string start_hour { get; set; }
    public virtual string day_number { get; set; }
    public virtual double time_to_answer { get; set; }
    public virtual string start_date_hour { get; set; }
    public virtual double duration { get; set; }
    public virtual long nbr_speaker { get; set; }
    public virtual long nbr_message { get; set; }
    public virtual long is_without_answer { get; set; }
    public virtual long days_of_activity { get; set; }
    public virtual long is_anonymous { get; set; }
    public virtual object country_id { get; set; }
    public virtual long is_happy { get; set; }
    public virtual long rating { get; set; }
    public virtual string rating_text { get; set; }
    public virtual long is_unrated { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}