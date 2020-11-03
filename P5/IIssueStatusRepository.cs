using Castle.DynamicProxy.Generators;
using System;
using System.Collections.Generic;

namespace P5
{
    public interface IIssueStatusRepository
    {
        void Add(int Id, string value);
        List<IssueStatus> GetAll();
        int GetIdByStatus(string value);
        string GetValueById(int Id);
    }
}
