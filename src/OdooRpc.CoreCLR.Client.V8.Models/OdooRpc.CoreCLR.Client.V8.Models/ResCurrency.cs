namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResCurrency
{
    public virtual string name { get; set; }
    public virtual string full_name { get; set; }
    public virtual string symbol { get; set; }
    public virtual double rate { get; set; }
    public virtual double inverse_rate { get; set; }
    public virtual string rate_string { get; set; }
    public virtual long[] rate_ids { get; set; }
    public virtual double rounding { get; set; }
    public virtual long decimal_places { get; set; }
    public virtual bool active { get; set; }
    public virtual string position { get; set; }
    public virtual string date { get; set; }
    public virtual string currency_unit_label { get; set; }
    public virtual string currency_subunit_label { get; set; }
    public virtual bool is_current_company_currency { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool display_rounding_warning { get; set; }
    public virtual string fiscal_country_codes { get; set; }
}