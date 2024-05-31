using DnsClient;
using System.Text.RegularExpressions;

namespace gmail_checker
{
    internal class Mx
    {
        private string Line { get; set; }
        private string Domain { get; set; }
        private LookupClient Lookup { get; set; }

        const string Pattern = @"(?<=@)[\w\.-]+";
        public Mx(string line)
        {
            Line = line;
            Lookup = new LookupClient();
            var matches = Regex.Matches(Line, Pattern);
            if (matches.Count > 0)
            {
                Domain = matches[0].Value;
            }
            else
            {
                Domain = Line;
            }
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

            return new[] { Line, isGmailMx ? "t" : "f" };
        }
    }
}
