using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class Utils
    {
        internal static int LikesAmount(FacebookObjectCollection<User> i_UseresLikes)
        {
            int v_LikesAmount = 0;

            foreach (User user in i_UseresLikes)
            {
                v_LikesAmount++;
            }

            return v_LikesAmount;
        }
    }
}
