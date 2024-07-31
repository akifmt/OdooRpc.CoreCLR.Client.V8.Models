﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosPrinter
{
    public virtual string name { get; set; }
    public virtual string printer_type { get; set; }
    public virtual string proxy_ip { get; set; }
    public virtual long[] product_categories_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string epson_printer_ip { get; set; }
}