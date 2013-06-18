using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using OpenQA.Selenium;

namespace BumblebeeAndroid.Implementation
{
    public class AndroidElement : Element
    {
        public AndroidElement(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AndroidElement(IBlock parent, IWebElement tag) : base(parent, tag)
        {
        }

        public override IPerformsDragAndDrop GetDragAndDropPerformer()
        {
            return new AndroidDragAndDrop(Session.Driver);
        }

        public override bool Selected
        {
            get { return bool.Parse(Tag.GetAttribute("checked")); }
        }
    }
}
