﻿using Newtonsoft.Json;
using System.Diagnostics;
using System.Web;

namespace Terratype.Labels
{
    [DebuggerDisplay("{Id}")]
    [JsonObject(MemberSerialization.OptIn, ItemTypeNameHandling = TypeNameHandling.All)]
    public class Standard : Models.Label
    {
        public static string _Id = "standard";

        [JsonProperty]
        public override string Id
        {
            get
            {
                return _Id;
            }
        }

        public override string Name
        {
            get
            {
                return "terratypeLabelStandard_name";                    //  Value is in the language file
            }
        }

        public override string Description
        {
            get
            {
                return "terratypeLabelStandard_description";                    //  Value is in the language file
            }
        }

        [JsonProperty(PropertyName = "color")]
        public int Color { get; set; }

        [JsonProperty(PropertyName = "content")]
        public IHtmlString Content { get; set; }

    }
}