using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace BDDish.Model.Persistence
{
    public class FeatureMap : ClassMap<Feature>
    {
        public FeatureMap()
        {
            Id(x => x.Id);
            Map(x => x.LabelConcept );
            Map(x => x.LabelBody);
        }
    }

}
