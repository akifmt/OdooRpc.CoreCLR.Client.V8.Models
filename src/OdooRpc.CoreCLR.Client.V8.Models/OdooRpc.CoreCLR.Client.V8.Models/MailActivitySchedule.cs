namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailActivitySchedule
{
    public virtual object res_model_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_ids { get; set; }
    public virtual bool is_batch_mode { get; set; }
    public virtual object company_id { get; set; }
    public virtual string error { get; set; }
    public virtual bool has_error { get; set; }
    public virtual long[] plan_available_ids { get; set; }
    public virtual object plan_id { get; set; }
    public virtual bool plan_has_user_on_demand { get; set; }
    public virtual string plan_summary { get; set; }
    public virtual object plan_on_demand_user_id { get; set; }
    public virtual string plan_date { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_category { get; set; }
    public virtual string date_deadline { get; set; }
    public virtual string summary { get; set; }
    public virtual string note { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual string chaining_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object department_id { get; set; }
    public virtual bool plan_department_filterable { get; set; }
}