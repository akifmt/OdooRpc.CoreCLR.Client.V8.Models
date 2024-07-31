namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpWorkcenterProductivity
{
    public virtual object production_id { get; set; }
    public virtual object workcenter_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object workorder_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object loss_id { get; set; }
    public virtual string loss_type { get; set; }
    public virtual string description { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual double duration { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object employee_id { get; set; }
    public virtual string employee_cost { get; set; }
    public virtual double total_cost { get; set; }
    public virtual object currency_id { get; set; }
}