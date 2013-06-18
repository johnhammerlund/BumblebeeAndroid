using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace BumblebeeAndroid.Implementation
{
    public class AndroidSpinner<TResult> : SelectBox<TResult> where TResult : IBlock
    {
        //Need to scope to driver level to access spinner
        public AndroidSpinner(IBlock parent, By @by)
            : base(parent, parent.Session.Driver.FindElement(@by))
        {
        }

        public AndroidSpinner(IBlock parent, IWebElement element) : base(parent, element)
        {
        }

        public override IEnumerable<IOption<TResult>> Options
        {
            get
            {
                return GetElements(ByAndroid.AndroidClass("android.widget.TextView"))
                    .Select(e => new AndroidOption<TResult>(ParentBlock, e));
            }
        }
    }

    public class AndroidRadioSpinner<TResult> : AndroidElement, ISelectBox<TResult> where TResult : IBlock
    {
        //Need to scope to driver level to access spinner
        public AndroidRadioSpinner(IBlock parent, By @by) : base(parent, parent.Session.Driver.FindElement(@by))
        {
        }

        public AndroidRadioSpinner(IBlock parent, IWebElement tag) : base(parent, tag)
        {
        }

        public IEnumerable<IOption<TResult>> Options
        {
            get
            {
                return Session.Driver.FindElements(ByAndroid.AndroidClass("android.widget.CheckedTextView"))
                    .Select(e => new AndroidOption<TResult>(ParentBlock, e));
            }
        }
    }

    public class AndroidOption<TResult> : Option<TResult> where TResult : IBlock
    {
        public AndroidOption(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AndroidOption(IBlock parent, IWebElement element) : base(parent, element)
        {
        }

        public override bool Selected
        {
            get { return bool.Parse(Tag.GetAttribute("checked")); }
        }
    }
}
