namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsFolder
{
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual object parent_folder_id { get; set; }
    public virtual string parent_path { get; set; }
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual long[] children_folder_ids { get; set; }
    public virtual long[] document_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] share_link_ids { get; set; }
    public virtual bool is_shared { get; set; }
    public virtual long[] facet_ids { get; set; }
    public virtual long[] group_ids { get; set; }
    public virtual long[] read_group_ids { get; set; }
    public virtual bool user_specific { get; set; }
    public virtual bool user_specific_write { get; set; }
    public virtual bool has_write_access { get; set; }
    public virtual long action_count { get; set; }
    public virtual long document_count { get; set; }
    public virtual long deletion_delay { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] project_ids { get; set; }
}