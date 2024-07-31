namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CrmTeam
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
    public virtual long sequence { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual bool is_membership_multi { get; set; }
    public virtual long[] member_ids { get; set; }
    public virtual long[] member_company_ids { get; set; }
    public virtual string member_warning { get; set; }
    public virtual long[] crm_team_member_ids { get; set; }
    public virtual long[] crm_team_member_all_ids { get; set; }
    public virtual long color { get; set; }
    public virtual long[] favorite_user_ids { get; set; }
    public virtual bool is_favorite { get; set; }
    public virtual string dashboard_button_name { get; set; }
    public virtual string dashboard_graph_data { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual double invoiced { get; set; }
    public virtual double invoiced_target { get; set; }
    public virtual long quotations_count { get; set; }
    public virtual double quotations_amount { get; set; }
    public virtual long sales_to_invoice_count { get; set; }
    public virtual long sale_order_count { get; set; }
    public virtual long[] website_ids { get; set; }
    public virtual long abandoned_carts_amount { get; set; }
    public virtual long abandoned_carts_count { get; set; }
}