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
    public class AndroidTextBox<TResult> : TextField<TResult> where TResult : IBlock
    {
        public AndroidTextBox(IBlock parent, By @by) : base(parent, @by)
        {
        }

        public AndroidTextBox(IBlock parent, IWebElement tag) : base(parent, tag)
        {
        }

        public override string Text
        {
            get { return Tag.Text;}
        }
    }
}
