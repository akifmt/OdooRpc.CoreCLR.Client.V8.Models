namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpReport
{
    public virtual long id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object production_id { get; set; }
    public virtual string date_finished { get; set; }
    public virtual object product_id { get; set; }
    public virtual string total_cost { get; set; }
    public virtual string component_cost { get; set; }
    public virtual double qty_produced { get; set; }
    public virtual double qty_demanded { get; set; }
    public virtual double yield_rate { get; set; }
    public virtual string unit_cost { get; set; }
    public virtual string unit_component_cost { get; set; }
    public virtual string display_name { get; set; }
    public virtual string employee_cost { get; set; }
    public virtual string unit_employee_cost { get; set; }
}