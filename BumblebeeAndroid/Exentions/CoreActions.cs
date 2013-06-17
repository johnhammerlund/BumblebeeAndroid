using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bumblebee.Interfaces;
using BumblebeeAndroid.Implementation;

namespace BumblebeeAndroid.Exentions
{
    public static class CoreActions
    {
        public static OrientationAction<TResult> ChangeOrientation<TResult>(this TResult block) where TResult : IBlock
        {
            return new OrientationAction<TResult>(block);
        }
    }
}
