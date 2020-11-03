using System;
using System.Collections.Generic;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        public static List<Issue> _Issues = new List<Issue>();

        public FakeIssueRepository()
        { 
        }

        public string Add(Issue issue)
        {
            string newname = issue.Title.Trim();
            if (newname == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            DateTime date = issue.DiscoveryDate;
            if (date == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (date > DateTime.Now)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            string discoverer = issue.Discoverer;
            if (discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            _Issues.Add(issue);

            return NO_ERROR;
        }
    }
}