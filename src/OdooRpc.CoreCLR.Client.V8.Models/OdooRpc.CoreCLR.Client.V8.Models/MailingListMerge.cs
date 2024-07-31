namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingListMerge
{
    public virtual long[] src_list_ids { get; set; }
    public virtual object dest_list_id { get; set; }
    public virtual string merge_options { get; set; }
    public virtual string new_list_name { get; set; }
    public virtual bool archive_src_lists { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}