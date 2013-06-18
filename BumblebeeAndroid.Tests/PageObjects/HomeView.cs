using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using BumblebeeAndroid.Implementation;

namespace BumblebeeAndroid.Tests.PageObjects
{
    public class HomeView : AppiumDroidBlock
    {
        public HomeView(Session session) : base(session)
        {
        }

        public IClickable<AppiumDroidBlock> EnBtn
        {
            get { return new Clickable<AppiumDroidBlock>(this, ByAndroid.ContentDesc("buttonTest")); }
        }

        public IClickable<HybridView> WebviewBtn
        {
            get { return new Clickable<HybridView>(this, ByAndroid.ContentDesc("buttonStartWebviewCD")); }
        }

        public IClickable<RegisterView> UserRegistrationBtn
        {
            get { return new Clickable<RegisterView>(this, ByAndroid.ContentDesc("startUserRegistrationCD")); }
        }

        public ITextField<HomeView> TextField
        {
            get { return new TextField<HomeView>(this, ByAndroid.ContentDesc("my_text_field")); }
        }

        public IClickable<AppiumDroidBlock> ShowProgressBtn
        {
            get { return new Clickable<AppiumDroidBlock>(this, ByAndroid.ContentDesc("waitingButtonTest")); }
        }

        public IClickable<HomeView> DisplayTextBtn
        {
            get { return new Clickable<HomeView>(this, ByAndroid.ContentDesc("visibleButtonTest")); }
        }

        public ICheckbox<HomeView> AcceptAddsChk
        {
            get { return new AppiumCheckbox<HomeView>(this, ByAndroid.AndroidClass("android.widget.CheckBox")); }
        }
    }
}
