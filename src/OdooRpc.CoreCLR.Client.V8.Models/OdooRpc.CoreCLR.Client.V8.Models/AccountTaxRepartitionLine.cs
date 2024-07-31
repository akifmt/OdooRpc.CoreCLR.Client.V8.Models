namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTaxRepartitionLine
{
    public virtual double factor_percent { get; set; }
    public virtual double factor { get; set; }
    public virtual string repartition_type { get; set; }
    public virtual string document_type { get; set; }
    public virtual object account_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object tax_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool use_in_tax_closing { get; set; }
    public virtual string tag_ids_domain { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}