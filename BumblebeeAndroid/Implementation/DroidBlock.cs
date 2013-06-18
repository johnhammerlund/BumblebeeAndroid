using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace BumblebeeAndroid.Implementation
{
    public abstract class DroidBlock : Block
    {
        protected DroidBlock(Session session) : base(session)
        {
        }

        public override IPerformsDragAndDrop GetDragAndDropPerformer()
        {
            return new AndroidDragAndDrop(Session.Driver);
        }
    }
}
