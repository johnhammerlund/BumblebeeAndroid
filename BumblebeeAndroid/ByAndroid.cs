using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BumblebeeAndroid
{
    class ByAndroid : By
    {
        public static By ResourceID(string id)
        {
            return Id(id);
        }

        public static By Label(string label)
        {
            return Name(label);
        }

        public static By Value(string value)
        {
            return LinkText(value);
        }

        public static By PartialValue(string value)
        {
            return PartialLinkText(value);
        }

        public static By AndroidClass(string androidClass)
        {
            return ClassName(androidClass);
        }

        public static By UIType(string type)
        {
            return TagName(type);
        }

        //Appium Specific

        public static By ContentDesc(string contentDesc)
        {
            return Name(contentDesc);
        }
    }
}
