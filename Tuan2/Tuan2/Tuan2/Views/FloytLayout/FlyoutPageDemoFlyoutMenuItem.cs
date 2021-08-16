using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2.Views.FloytLayout
{
    public class FlyoutPageDemoFlyoutMenuItem
    {
        public FlyoutPageDemoFlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPageDemoFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}