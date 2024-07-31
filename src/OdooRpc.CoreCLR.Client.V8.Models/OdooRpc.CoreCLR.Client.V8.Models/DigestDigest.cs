namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DigestDigest
{
    public virtual string name { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual string periodicity { get; set; }
    public virtual string next_run_date { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string available_fields { get; set; }
    public virtual bool is_subscribed { get; set; }
    public virtual string state { get; set; }
    public virtual bool kpi_res_users_connected { get; set; }
    public virtual long kpi_res_users_connected_value { get; set; }
    public virtual bool kpi_mail_message_total { get; set; }
    public virtual long kpi_mail_message_total_value { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool kpi_account_total_revenue { get; set; }
    public virtual string kpi_account_total_revenue_value { get; set; }
    public virtual bool kpi_livechat_rating { get; set; }
    public virtual double kpi_livechat_rating_value { get; set; }
    public virtual bool kpi_livechat_conversations { get; set; }
    public virtual long kpi_livechat_conversations_value { get; set; }
    public virtual bool kpi_livechat_response { get; set; }
    public virtual double kpi_livechat_response_value { get; set; }
    public virtual bool kpi_project_task_opened { get; set; }
    public virtual long kpi_project_task_opened_value { get; set; }
    public virtual bool kpi_website_sale_total { get; set; }
    public virtual string kpi_website_sale_total_value { get; set; }
}