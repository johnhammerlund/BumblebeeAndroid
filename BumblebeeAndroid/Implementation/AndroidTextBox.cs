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
    public class AndroidTextField<TResult> : TextField<TResult> where TResult : IBlock
    {
        public AndroidTextField(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AndroidTextField(IBlock parent, IWebElement tag) : base(parent, tag)
        {
        }

        public override string Text
        {
            get { return Tag.Text;}
        }
    }
}
