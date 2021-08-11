using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Xamarin.Views
{
    public class MyFlayoutFlyoutMenuItem
    {
        public MyFlayoutFlyoutMenuItem()
        {
            TargetType = typeof(MyFlayoutFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string URL{ get; set;}
    }
}