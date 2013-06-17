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
    public class AppiumCheckbox<TResult> : Checkbox<TResult> where TResult : IBlock
    {
        public AppiumCheckbox(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AppiumCheckbox(IBlock parent, IWebElement element) : base(parent, element)
        {
        }

        public override bool Selected
        {
            get { return bool.Parse(Tag.GetAttribute("checked")); }
        }
    }
}
