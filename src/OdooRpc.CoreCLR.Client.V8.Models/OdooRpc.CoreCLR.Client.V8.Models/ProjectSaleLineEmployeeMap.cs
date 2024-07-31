namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProjectSaleLineEmployeeMap
{
    public virtual object project_id { get; set; }
    public virtual object employee_id { get; set; }
    public virtual long[] existing_employee_ids { get; set; }
    public virtual object sale_line_id { get; set; }
    public virtual object sale_order_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual double price_unit { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string cost { get; set; }
    public virtual string display_cost { get; set; }
    public virtual object cost_currency_id { get; set; }
    public virtual bool is_cost_changed { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object timesheet_product_id { get; set; }
}