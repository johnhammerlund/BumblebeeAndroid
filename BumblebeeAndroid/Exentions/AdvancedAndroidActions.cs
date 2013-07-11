using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Interfaces;
using OpenQA.Selenium.Interactions;

namespace BumblebeeAndroid.Exentions
{
    public static class AdvancedAndroidActions
    {
        public static TResult ClickAtLocation<TResult>(this IBlock block, int x, int y) where TResult : IBlock
        {
            new TouchActions(block.Session.Driver).Down(x, y).Up(x, y).Perform();
            return block.Session.CurrentBlock<TResult>();
        }
    }
}
