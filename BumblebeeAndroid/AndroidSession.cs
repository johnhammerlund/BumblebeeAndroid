using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Setup;

namespace BumblebeeAndroid
{
    class AndroidSession : Session
    {
        public AndroidSession(IDriverEnvironment environment) : base(environment)
        {
        }
    }
}
