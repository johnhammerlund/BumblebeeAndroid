using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace BumblebeeAndroid.Implementation
{
    public class DroidBlock : Block
    {
        public DroidBlock(Session session) : base(session)
        {
            Session.Driver.SwitchTo().Window("NATIVE_APP");
        }

        public override IPerformsDragAndDrop GetDragAndDropPerformer()
        {
            return new AndroidDragAndDrop(Session.Driver);
        }
    }
}
