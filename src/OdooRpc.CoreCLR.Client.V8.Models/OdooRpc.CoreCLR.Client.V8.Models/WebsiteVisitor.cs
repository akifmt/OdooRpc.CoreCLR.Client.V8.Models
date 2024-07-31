namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteVisitor
{
    public virtual string name { get; set; }
    public virtual string access_token { get; set; }
    public virtual object website_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_image { get; set; }
    public virtual object country_id { get; set; }
    public virtual string country_flag { get; set; }
    public virtual object lang_id { get; set; }
    public virtual string timezone { get; set; }
    public virtual string email { get; set; }
    public virtual string mobile { get; set; }
    public virtual long visit_count { get; set; }
    public virtual long[] website_track_ids { get; set; }
    public virtual long visitor_page_count { get; set; }
    public virtual long[] page_ids { get; set; }
    public virtual long page_count { get; set; }
    public virtual object last_visited_page_id { get; set; }
    public virtual string create_date { get; set; }
    public virtual string last_connection_datetime { get; set; }
    public virtual string time_since_last_action { get; set; }
    public virtual bool is_connected { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object livechat_operator_id { get; set; }
    public virtual string livechat_operator_name { get; set; }
    public virtual long[] discuss_channel_ids { get; set; }
    public virtual long session_count { get; set; }
    public virtual long visitor_product_count { get; set; }
    public virtual long[] product_ids { get; set; }
    public virtual long product_count { get; set; }
}