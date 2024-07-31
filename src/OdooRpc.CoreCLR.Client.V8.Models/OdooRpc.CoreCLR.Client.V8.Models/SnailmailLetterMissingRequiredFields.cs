namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SnailmailLetterMissingRequiredFields
{
    public virtual object partner_id { get; set; }
    public virtual object letter_id { get; set; }
    public virtual string street { get; set; }
    public virtual string street2 { get; set; }
    public virtual string zip { get; set; }
    public virtual string city { get; set; }
    public virtual object state_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}