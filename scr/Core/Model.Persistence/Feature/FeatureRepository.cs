using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistance;

namespace BDDish.Model.Persistence
{
    public class FeatureRepository : RepositoryDb<Feature, FeatureList>
    {
        public FeatureRepository(ISession session) : base(session)
        {
        }
    }

}
