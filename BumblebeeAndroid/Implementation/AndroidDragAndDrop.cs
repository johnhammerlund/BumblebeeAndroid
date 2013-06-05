using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;

namespace BumblebeeAndroid.Implementation
{
    class AndroidDragAndDrop : IPerformsDragAndDrop
    {
        public IWebDriver Driver { get; private set; }

        public AndroidDragAndDrop(IWebDriver driver)
        {
            Driver = driver;
        }

        public void DragAndDrop(IWebElement drag, IWebElement drop)
        {
            new TouchActions(Driver).Scroll(drag, drop.Location.X - drag.Location.X, drop.Location.Y - drag.Location.Y);
        }

        public void DragAndDrop(IWebElement drag, int xDrop, int yDrop)
        {
            new TouchActions(Driver).Scroll(drag, xDrop, yDrop);
        }
    }
}
