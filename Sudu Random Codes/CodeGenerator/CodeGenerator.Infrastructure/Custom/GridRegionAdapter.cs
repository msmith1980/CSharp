using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CodeGenerator.Infrastructure.Custom
{
    public class GridRegionAdapter : RegionAdapterBase<Grid>
    {
        public GridRegionAdapter(IRegionBehaviorFactory regionBehaviourFactory)
            : base(regionBehaviourFactory)
        {

        }

        protected override void Adapt(IRegion region, Grid regionTarget)
        {
            region.Views.CollectionChanged +=(sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add && region.ActiveViews.Count() == 0)
                {
                    foreach (FrameworkElement element in e.NewItems)
                    {
                        regionTarget.Children.Add(element);
                    }
                }
                else if(e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (FrameworkElement element in e.OldItems)
                    {
                        if (regionTarget.Children.Contains(element))
                        {
                            regionTarget.Children.Remove(element);
                        }
                    }
                }
            };




        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
