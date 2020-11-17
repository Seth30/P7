using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value.";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";


        public static List<Requirement> _Requirements = new List<Requirement>();

        public string Add(Requirement requirement)
        {
            string newname = requirement.Statement;
            if (newname == "")
                return EMPTY_STATEMENT_ERROR;
            foreach (Requirement x in _Requirements)
            {
                if (x.Statement == newname)
                    return DUPLICATE_STATEMENT_ERROR;
            }
            int num = 0;
            foreach (Requirement y in _Requirements)
            {
                if (y.ProjectId == requirement.ProjectId)
                    num++;
            }
            num++;
            requirement.Id = num;
            _Requirements.Add(requirement);
            return NO_ERROR;
        }
        public string Modify(Requirement requirement)
        {
            string newname = requirement.Statement;
            if (newname == "")
                return EMPTY_STATEMENT_ERROR;
            foreach (Requirement x in _Requirements)
            {
                if (x.Statement == newname)
                {
                    return x.Statement + requirement.Statement + x.Id;
                }
            }
            _Requirements[_Requirements.FindIndex(j => j.Id == requirement.Id)] = requirement;
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            List<Requirement> newlist = new List<Requirement>();
            foreach (Requirement x in _Requirements)
            {
                if (x.ProjectId == ProjectId)
                    newlist.Add(x);
            }
            return newlist;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            Requirement chosen = new Requirement();
            foreach (Requirement x in _Requirements)
            {
                if (x.Id == requirementId)
                {
                    chosen = x;
                    return chosen;
                }
            }
            chosen.Statement = REQUIREMENT_NOT_FOUND_ERROR;
            return chosen;
        }
        public int CountByFeatureId(int featureId)
        {
            int count = 0;
            foreach (Requirement x in _Requirements)
            {
                if (x.FeatureId == featureId)
                    count++;
            }
            return count;
        }
        public void RemoveByFeatureId(int featureId)
        {
            _Requirements.RemoveAll(j => j.FeatureId == featureId);
            foreach (Requirement x in _Requirements)
            {
                if (x.FeatureId == featureId)
                    _Requirements.Remove(x);
            }
        }
        public string Remove(Requirement requirement)
        {
            foreach (Requirement x in _Requirements)
            {
                if (x.ProjectId == requirement.ProjectId)
                {
                    if (x.FeatureId == requirement.FeatureId)
                    {
                        if (x.Id == requirement.Id)
                        {
                            _Requirements.Remove(requirement);
                            return NO_ERROR;
                        }
                    }
                }
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
    }
} 
