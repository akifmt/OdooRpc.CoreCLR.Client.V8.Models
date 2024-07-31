namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountFiscalPosition
{
    public virtual long sequence { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] account_ids { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual string note { get; set; }
    public virtual bool auto_apply { get; set; }
    public virtual bool vat_required { get; set; }
    public virtual object company_country_id { get; set; }
    public virtual string fiscal_country_codes { get; set; }
    public virtual object country_id { get; set; }
    public virtual object country_group_id { get; set; }
    public virtual long[] state_ids { get; set; }
    public virtual string zip_from { get; set; }
    public virtual string zip_to { get; set; }
    public virtual long states_count { get; set; }
    public virtual string foreign_vat { get; set; }
    public virtual string foreign_vat_header_mode { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}