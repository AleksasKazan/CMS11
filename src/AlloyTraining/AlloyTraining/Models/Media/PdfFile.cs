using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(
        DisplayName = "Pdf File",
        GUID = "8f1ecc02-9b4d-4092-b376-214e83059b21",
        Description = "Use this to upload Portable Document Format(PDF) files.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PdfFile : MediaData
    {
        [Display(Name = "Render preview image")]
        // false: render as simple hyperlink
        // true: render as clickable thumbnail preview image
        public virtual bool RenderPreviewImage { get; set; }
    }
}
