using DnsClient;

namespace gmail_checker
{
    internal class Mx
    {
        private string Domain { get; set; }
        private LookupClient Lookup { get; set; }
        public Mx(string domain)
        {
            Domain = domain;
            Lookup = new LookupClient();
        }

        //check domain mx
        public async Task<string[]> CheckMxAsync()
        {
            var result = await Lookup.QueryAsync(Domain, QueryType.MX);
            var record = result.Answers.MxRecords().ToArray();

            if (record.Length == 0)
            {
                return Array.Empty<string>();
            }

            return record.Select(x => x.Exchange.Value).ToArray();
        }

        public async Task<string[]> CheckGmailAsync()
        {
            var mxs = await CheckMxAsync();
            var isGmailMx = mxs.Any(x => x.Contains("google.com"));

            return new[] { Domain, isGmailMx ? "t" : "f" }; 
        }
    }
}
