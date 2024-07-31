﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailAliasDomain
{
    public virtual string name { get; set; }
    public virtual long[] company_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual string bounce_alias { get; set; }
    public virtual string bounce_email { get; set; }
    public virtual string catchall_alias { get; set; }
    public virtual string catchall_email { get; set; }
    public virtual string default_from { get; set; }
    public virtual string default_from_email { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}