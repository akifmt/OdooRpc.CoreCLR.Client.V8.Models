﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosMakePayment
{
    public virtual object config_id { get; set; }
    public virtual double amount { get; set; }
    public virtual object payment_method_id { get; set; }
    public virtual string payment_name { get; set; }
    public virtual string payment_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}