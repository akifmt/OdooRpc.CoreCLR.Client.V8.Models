namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentResource
{
    public virtual object resource_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object resource_calendar_id { get; set; }
    public virtual string tz { get; set; }
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string avatar_1920 { get; set; }
    public virtual string avatar_1024 { get; set; }
    public virtual string avatar_512 { get; set; }
    public virtual string avatar_256 { get; set; }
    public virtual string avatar_128 { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long sequence { get; set; }
    public virtual long capacity { get; set; }
    public virtual bool shareable { get; set; }
    public virtual long[] source_resource_ids { get; set; }
    public virtual long[] destination_resource_ids { get; set; }
    public virtual long[] linked_resource_ids { get; set; }
    public virtual string description { get; set; }
    public virtual long[] appointment_type_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}