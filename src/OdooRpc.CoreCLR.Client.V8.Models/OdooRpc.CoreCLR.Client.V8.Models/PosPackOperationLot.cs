﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosPackOperationLot
{
    public virtual object pos_order_line_id { get; set; }
    public virtual object order_id { get; set; }
    public virtual string lot_name { get; set; }
    public virtual object product_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}