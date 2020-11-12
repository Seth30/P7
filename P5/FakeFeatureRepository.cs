using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "Title must have a value.";
        public const string DUPLICATE_TITLE_ERROR = "Title Must be unique.";
        public const string NOT_FOUND_ERROR = "Feature not found.";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature.";

        public static List<Feature> features = new List<Feature>();

        public string Add(Feature feature)
        {
            string newname = feature.Title.Trim();
            if (newname == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            foreach (Feature x in features)
            {
                if (x.Title == newname)
                {
                    return DUPLICATE_TITLE_ERROR + newname;
                }
            }
            int count = FakeProjectRepository._Projects.Count;
            if (feature.ProjectId > count || feature.ProjectId < -1)
            {
                return INVALID_PROJECT_ID_ERROR;
            }
            int num=0;
            foreach (Feature y in features)
            {
                if (y.ProjectId == feature.ProjectId)
                    num++;
            }
            num++;
            feature.Id = num;
            features.Add(feature);
            return NO_ERROR;
        }
        public string Modify(Feature feature)
        {
            string newname = feature.Title.Trim();
            if (newname == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            foreach (Feature x in features)
            {
                if (x.Title == newname && x.ProjectId == feature.ProjectId)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
            }
            features[features.FindIndex(j => j.Id == feature.Id)] = feature;
            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectID)
        {
            List<Feature> feature = new List<Feature>();
            foreach (Feature x in features)
            {
                if (x.ProjectId == ProjectID)
                    feature.Add(x);
            }
            return feature;
        }
        public Feature GetFeatureById(int featureId)
        {
            Feature pickme = new Feature();
            foreach (Feature x in features)
            {
                if (x.Id == featureId)
                    pickme = x;
            }
            return pickme;
        }
        public Feature GetFeatureByTitle(string title)
        {
            Feature pickme = new Feature();
            foreach (Feature x in features)
            {
                if (x.Title == title)
                    pickme = x;
            }
            return pickme;
        }
        public string Remove(Feature feature)
        {
            return "do work";
        }
    }
}
