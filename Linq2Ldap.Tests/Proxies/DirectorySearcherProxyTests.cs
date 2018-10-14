using System.DirectoryServices;
using Linq2Ldap.Proxies;
using Xunit;
using Linq2Ldap.TestUtil;

namespace Linq2Ldap.Tests.Proxies {
    public class DirectorySearcherProxyTests {

        [IgnoreOnMonoFact]
        public void Constructs_PassesBaseEntry() {
            var entry = new DirectoryEntry();
            var p = new DirectorySearcherProxy(entry);
            Assert.Equal(entry, p.SearchRoot);
        }
    }
}