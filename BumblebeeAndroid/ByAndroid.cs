using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BumblebeeAndroid
{
    public class ByAndroid
    {
        public static By ResourceID(string id)
        {
            return By.Id(id);
        }

        public static By Label(string label)
        {
            return By.Name(label);
        }

        public static By Value(string value)
        {
            return By.LinkText(value);
        }

        public static By PartialValue(string value)
        {
            return By.PartialLinkText(value);
        }

        public static By AndroidClass(string androidClass)
        {
            return By.ClassName(androidClass);
        }

        public static By UIType(string type)
        {
            return By.TagName(type);
        }

        //Appium Specific

        public static By ContentDesc(string contentDesc)
        {
            return By.Name(contentDesc);
        }
    }
}
