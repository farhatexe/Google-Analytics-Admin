using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsProject.Models
{
    public class AnalyticsSummary
    {
        public TimeSpan AveragePageLoadTime { get; set; }
        public IDictionary<string, int> TopSearches { get; set; }
        public IDictionary<string, int> TopReferrers { get; set; }
        public IDictionary<string, int> PageViews { get; set; }
        public IDictionary<string, string> PageTitles { get; set; }
        public double PercentExitRate { get; set; }
        public double PageviewsPerVisit { get; set; }
        public double EntranceBounceRate { get; set; }
        public TimeSpan AverageTimeOnSite { get; set; }
        public double PercentNewVisits { get; set; }
        public int TotalPageViews { get; set; }
        public int TotalVisits { get; set; }
        public IList<int> Visits { get; set; }
    }
}