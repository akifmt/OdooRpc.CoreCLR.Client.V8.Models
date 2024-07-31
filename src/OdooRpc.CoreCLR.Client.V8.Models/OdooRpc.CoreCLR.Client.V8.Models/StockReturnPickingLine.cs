﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockReturnPickingLine
{
    public virtual object product_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual object uom_id { get; set; }
    public virtual object wizard_id { get; set; }
    public virtual object move_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool to_refund { get; set; }
}