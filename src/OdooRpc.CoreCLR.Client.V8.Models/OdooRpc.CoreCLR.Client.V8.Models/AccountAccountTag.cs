﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAccountTag
{
    public virtual string name { get; set; }
    public virtual string applicability { get; set; }
    public virtual long color { get; set; }
    public virtual bool active { get; set; }
    public virtual bool tax_negate { get; set; }
    public virtual object country_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}