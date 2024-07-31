﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailActivityPlanTemplate
{
    public virtual object plan_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual object company_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual long delay_count { get; set; }
    public virtual string delay_unit { get; set; }
    public virtual string delay_from { get; set; }
    public virtual string icon { get; set; }
    public virtual string summary { get; set; }
    public virtual string responsible_type { get; set; }
    public virtual object responsible_id { get; set; }
    public virtual string note { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}