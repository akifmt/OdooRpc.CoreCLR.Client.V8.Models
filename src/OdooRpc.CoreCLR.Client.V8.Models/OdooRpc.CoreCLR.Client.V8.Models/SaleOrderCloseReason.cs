namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderCloseReason
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool visible_in_portal { get; set; }
    public virtual string retention_message { get; set; }
    public virtual string retention_button_text { get; set; }
    public virtual string retention_button_link { get; set; }
    public virtual bool empty_retention_message { get; set; }
    public virtual bool is_protected { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}