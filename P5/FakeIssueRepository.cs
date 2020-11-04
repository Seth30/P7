using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
        public string Modify(Issue missue)
        {
            string newname = missue.Title.Trim();
            if (newname == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            DateTime date = missue.DiscoveryDate;
            if (date == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (date > DateTime.Now)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            string discoverer = missue.Discoverer;
            if (discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            _Issues[_Issues.FindIndex(j => j.Id == missue.Id)] = missue;
            return NO_ERROR;
        }
        public bool Remove(Issue rissue)
        {
            var item = _Issues.Single(y => y.Id == rissue.Id);
            if (item != null)
            {
                _Issues.Remove(item);
                return true;
            }
            return false;
        }

        public int GetTotalNumberOfIssues(int Projectid)
        {
            int num=0;
            foreach (Issue x in _Issues)
            {
                if (x.ProjectId == Projectid)
                {
                    num++;
                }
            }
            return num;
        }
        public List<string> GetIssuesByMonth(int Projectid)
        {
            List<string> issues = new List<string>();
            DateTime today = DateTime.Today;
            int year = today.Year;
            for (int x = 1; x < 13; x++)
            {
                foreach (Issue y in _Issues)
                {
                    if (y.DiscoveryDate.Month == x)
                    {
                        if (y.ProjectId == Projectid && y.DiscoveryDate.Year == year)
                        {
                            issues.Add(y.DiscoveryDate.Month.ToString());
                            break;
                        }
                    }
                }
            }

            return issues;
        }
        public List<string> GetIssuesbyDiscoverer(int Projectid)
        {
            List<string> issues = new List<string>();
            foreach (AppUser user in FakeAppUserRepository._AppUsers.Values)
            {
                foreach (Issue y in _Issues)
                {
                    if (y.Discoverer.Trim() == user.UserName.Trim())
                    {
                        if (y.ProjectId == Projectid)
                        {
                            issues.Add(y.Discoverer);
                            break;
                        }
                    }
                }
            }

            return issues;
        }
        public List<Issue> GetAll(int ProjectID)
        {
            List<Issue> issues = new List<Issue>();
            foreach (Issue x in _Issues)
            {
                if (x.ProjectId == ProjectID)
                    issues.Add(x);
            }
            return issues;
        }
        public Issue GetIssueById(int Id)
        {
            Issue thisone = new Issue();
            foreach (Issue x in _Issues)
            {
                if (x.Id == Id)
                {
                    thisone = x;
                }
            }
            return thisone;
        }
    }
}