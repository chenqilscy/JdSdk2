﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Response.Supplier
{
﻿    [Serializable]
    public class DropshipDpsSearchpreResponse : JdResponse
    {
        [JsonProperty("searchPreResult")]
        public ReturnOrderPreForJosResultListDto SearchPreResult
        {
            get;
            set;
        }

    }

}
