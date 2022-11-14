using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business.SelectionFactories;
using EPiServer.Shell.ObjectEditing;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Product",
        GroupName = SiteGroupNames.Specialized,
        Order = 20,
        GUID = "b28c7e43-0b50-4cfc-af19-993d5d9baff1",
        Description = "Use this for software products that Alloy sells.")]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "theme1";
        }

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(
            Name = "Color theme",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual IList<string> UniqueSellingPoints { get; set; }
    }
}
