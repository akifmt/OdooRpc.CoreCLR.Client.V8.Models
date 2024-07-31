﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsLink_to_record_wizard
{
    public virtual long[] document_ids { get; set; }
    public virtual object model_id { get; set; }
    public virtual bool is_readonly_model { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual long[] accessible_model_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}