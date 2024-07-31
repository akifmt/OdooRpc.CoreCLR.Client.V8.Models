namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailActivityPlan
{
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] template_ids { get; set; }
    public virtual bool active { get; set; }
    public virtual object res_model_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual long steps_count { get; set; }
    public virtual bool has_user_on_demand { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object department_id { get; set; }
    public virtual bool department_assignable { get; set; }
}