using Bumblebee.Interfaces;
using Bumblebee.Setup;
using BumblebeeAndroid.Exentions;

namespace BumblebeeAndroid.Implementation
{
    public class AlertAction<TResult> where TResult : IBlock
    {
        private readonly Session _session;

        public AlertAction(IBlock block)
        {
            _session = block.Session;
        }

        public TResult AcceptAlert()
        {
            var driver = ((DroidDriver)_session.Driver);
            InnerConvenience.ExecutePost(driver.GetRemoteAddress() + "/session/" + driver.GetSessionId() + "/accept_alert", null);

            return _session.CurrentBlock<TResult>();
        }

        public TResult DismissAlert()
        {
            var driver = ((DroidDriver)_session.Driver);
            InnerConvenience.ExecutePost(driver.GetRemoteAddress() + "/session/" + driver.GetSessionId() + "/dismiss_alert", null);

            return _session.CurrentBlock<TResult>();
        }
    }
}
