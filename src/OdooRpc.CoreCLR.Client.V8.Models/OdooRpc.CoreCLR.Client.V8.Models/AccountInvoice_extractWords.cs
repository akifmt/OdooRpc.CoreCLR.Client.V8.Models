namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountInvoice_extractWords
{
    public virtual object invoice_id { get; set; }
    public virtual string field { get; set; }
    public virtual bool ocr_selected { get; set; }
    public virtual bool user_selected { get; set; }
    public virtual string word_text { get; set; }
    public virtual long word_page { get; set; }
    public virtual double word_box_midX { get; set; }
    public virtual double word_box_midY { get; set; }
    public virtual double word_box_width { get; set; }
    public virtual double word_box_height { get; set; }
    public virtual double word_box_angle { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}