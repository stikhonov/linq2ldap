using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using Linq2Ldap.Attributes;
using Linq2Ldap.Proxies;
using Linq2Ldap.Types;

namespace Linq2Ldap.Models
{
    public class Entry: IEntry
    {
        public string DN { get; set; }

        public ResultPropertyCollectionProxy Properties { get; set; }

        public virtual bool Has(string attrName) => this.Properties.Contains(attrName);

        public ICollection Keys => this.Properties.Keys;
        public ICollection Values => this.Properties.Values;

        public ResultPropertyValueCollectionProxy this[string key] {
            get => this.Properties[key];
        }
    }
}
