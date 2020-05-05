using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Linq;
using PrimeNumbers.IntegrationTests.Extensions;

namespace Http.QueryString.Factories
{
    public class QueryStringFactory
    {
        public string Create(object obj, StringBuilder stringBuilder = null, string prefix = "")
        {
            stringBuilder = stringBuilder ?? new StringBuilder("?");

            var properties = obj.GetType()
                    .GetProperties()
                    .Where(n => n.GetValue(obj) != null);

            foreach (var propertyInfo in properties)
            {
                var propertyValue = HttpUtility.UrlEncode(propertyInfo.GetValue(obj).ToString());

                if (propertyInfo.PropertyType.IsSimple())
                {
                    stringBuilder.Append($"{prefix}{propertyInfo.Name}={propertyValue}&");
                    continue;
                }

                Create(propertyValue, stringBuilder, $"{prefix}{propertyInfo.Name}.");
            }

            return stringBuilder.ToString();
        }

        public async Task<string> CreateAsync<T>(T obj)
            where T : class
        {
            if (obj == default)
            {
                return null;
            }

            var dictionary = CreateQueryStringDictionary(obj);
            var formUrlEncodedContent = new FormUrlEncodedContent(dictionary);
            var urlEncodedString = await formUrlEncodedContent.ReadAsStringAsync();

            return urlEncodedString;
        }

        public IDictionary<string, string> CreateQueryStringDictionary(object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (!(obj is JToken token))
            {
                return CreateQueryStringDictionary(JObject.FromObject(obj));
            }

            if (token.HasValues)
            {
                var contentData = new Dictionary<string, string>();
                foreach (var child in token.Children().ToList())
                {
                    var childContent = CreateQueryStringDictionary(child);
                    if (childContent != null)
                    {
                        contentData = contentData.Concat(childContent)
                                                 .ToDictionary(k => k.Key, v => v.Value);
                    }
                }

                return contentData;
            }

            var jValue = token as JValue;
            if (jValue?.Value == null)
            {
                return null;
            }

            var value = jValue?.Type == JTokenType.Date ?
                            jValue?.ToString("o", CultureInfo.InvariantCulture) :
                            jValue?.ToString(CultureInfo.InvariantCulture);

            return new Dictionary<string, string> { { token.Path, value } };
        }
    }
}