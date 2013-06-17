using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using BumblebeeAndroid.Exentions;

namespace BumblebeeAndroid.Implementation
{
    public class OrientationAction<TResult> where TResult : IBlock
    {
        private Session _session;

        public OrientationAction(IBlock block)
        {
            _session = block.Session;
        }

        public TResult ToLandscape()
        {
            var driver = ((DroidDriver) _session.Driver);
            var res = InnerConvenience.ExecutePost(driver.GetRemoteAddress() + "/session/" + driver.GetSessionId() + "/orientation", "{\"orientation\": \"LANDSCAPE\"}");

            return _session.CurrentBlock<TResult>();
        }

        public TResult ToPortrait()
        {
            var driver = ((DroidDriver)_session.Driver);
            var res = InnerConvenience.ExecutePost(driver.GetRemoteAddress() + "/session/" + driver.GetSessionId() + "/orientation", "{\"orientation\": \"PORTRAIT\"}");

            return _session.CurrentBlock<TResult>();
        }
    }
}
