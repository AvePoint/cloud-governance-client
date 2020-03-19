using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Collections;
using System.Linq;

namespace Cloud.Governance.Client.Model
{
    public class NextLink
    {
        public Int32? Top { get; set; }
        public Int32? Skip { get; set; }
        public String Filter { get; set; }
        public String OrderBy { get; set; }
        public String Search { get; set; }
        public String Distinct { get; set; }

        public NextLink() { }

        public NextLink(String nextLink)
        {
            if (String.IsNullOrEmpty(nextLink))
            {
                return;
            }
            nextLink = $"https://nextLink{nextLink}";
            if (!Uri.TryCreate(nextLink, UriKind.Absolute, out var uri))
            {
                return;
            }
            var query = HttpUtility.ParseQueryString(uri.Query);
            foreach (var key in query.AllKeys)
            {
                var key2 = key.ToLowerInvariant();
                if (!key2.StartsWith("$", StringComparison.Ordinal))
                {
                    key2 = $"${key}";
                }
                var value = query.GetValues(key).FirstOrDefault();
                if (String.IsNullOrEmpty(value))
                {
                    continue;
                }
                switch (key2)
                {
                    case "$filter":
                        this.Filter = value;
                        break;
                    case "$orderby":
                        this.OrderBy = value;
                        break;
                    case "$search":
                        this.Search = value;
                        break;
                    case "$top":
                        if (Int32.TryParse(value, out var top))
                        {
                            this.Top = top;
                        }
                        break;
                    case "$skip":
                        if (Int32.TryParse(value, out var skip))
                        {
                            this.Skip = skip;
                        }
                        break;
                    case "$distinct":
                        this.Distinct = value;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
