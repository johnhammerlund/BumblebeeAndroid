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
    public class AndroidSpinner<TResult> : SelectBox<TResult> where TResult : IBlock
    {
        public AndroidSpinner(IBlock parent, By @by) : base(parent, @by)
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
                    .Select(e => new Option<TResult>(ParentBlock, e));
            }
        }
    }

    public class AndroidRadioSpinner<TResult> : SelectBox<TResult> where TResult : IBlock
    {
        public AndroidRadioSpinner(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AndroidRadioSpinner(IBlock parent, IWebElement element) : base(parent, element)
        {
        }

        public override IEnumerable<IOption<TResult>> Options
        {
            get
            {
                return GetElements(ByAndroid.AndroidClass("android.widget.CheckedTextView"))
                    .Select(e => new Option<TResult>(ParentBlock, e));
            }
        }
    }
}
