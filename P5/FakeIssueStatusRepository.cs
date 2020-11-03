using System;
using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            if (_IssueStatuses.Count == 0)
            {
                _IssueStatuses.Add(new IssueStatus { Value = "Open", Id = 0 });
                _IssueStatuses.Add(new IssueStatus { Value = "Assigned", Id = 1 });
                _IssueStatuses.Add(new IssueStatus { Value = "Fixed", Id = 2 });
                _IssueStatuses.Add(new IssueStatus { Value = "Closed - Won't Fix", Id = 3 });
                _IssueStatuses.Add(new IssueStatus { Value = "Closed - Fixed", Id = 4 });
                _IssueStatuses.Add(new IssueStatus { Value = "Closed - By Design", Id = 5 });
            }
        }
        public void Add(string value, int Id) 
        {
            _IssueStatuses.Add(new IssueStatus { Value = value, Id = Id });
        }
        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            int id;
            foreach (IssueStatus x in _IssueStatuses)
            {
                if (x.Value == value)
                {
                    id = x.Id;
                    return id;
                }
            }
            return -1;
        }
        public string GetValueById(int id)
        {
            string value;
            foreach (IssueStatus x in _IssueStatuses)
            {
                if (x.Id == id)
                {
                    value = x.Value;
                    return value;
                }
            }
            return "";
        }
    }
}
