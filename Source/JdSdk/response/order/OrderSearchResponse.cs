﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Order;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderSearchResponse : JdResponse
    {
        [JsonProperty("orderresult")]
        public OrderResult OrderResult
        {
            get;
            set;
        }

    }

}