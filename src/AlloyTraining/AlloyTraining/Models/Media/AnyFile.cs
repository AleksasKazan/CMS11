using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "AnyFile",
        GUID = "ad065f25-12c6-40c2-aa14-aea2711b324b",
        Description = "Use this to upload any type of file")]
    public class AnyFile : MediaData
    {
    }
}
