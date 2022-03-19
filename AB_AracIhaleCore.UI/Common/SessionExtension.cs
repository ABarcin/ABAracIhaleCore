using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.UI.Common
{
    public static class SessionExtension
    {
        public static void MySessionSet(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T MySessionGet<T>(this ISession session, string key)
        {

            var hede = session.GetString(key);
            return hede == null
                ? default(T)
                : JsonConvert.DeserializeObject<T>(hede);
        }
    }
}
