using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(
        DisplayName = "Image File",
        GUID = "97cf9192-269c-4bb1-be52-a4c9162f9b62",
        Description = "“Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {
                [CultureSpecific]
                [Editable(true)]
                public virtual string Description { get; set; }
    }
}
