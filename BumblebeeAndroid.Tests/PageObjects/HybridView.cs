using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using BumblebeeAndroid.Implementation;

namespace BumblebeeAndroid.Tests.PageObjects
{
    public class HybridView : AppiumDroidBlock
    {
        public HybridView(Session session) : base(session)
        {
        }

        public ISelectBox<HybridView> ActionSelect
        {
            get { return new AndroidSpinner<HybridView>(this, ByAndroid.AndroidClass("android.widget.Spinner"));}
        }
    }
}
