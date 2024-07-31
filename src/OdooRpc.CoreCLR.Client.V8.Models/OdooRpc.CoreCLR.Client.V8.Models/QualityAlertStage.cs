﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class QualityAlertStage
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool folded { get; set; }
    public virtual bool done { get; set; }
    public virtual long[] team_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}