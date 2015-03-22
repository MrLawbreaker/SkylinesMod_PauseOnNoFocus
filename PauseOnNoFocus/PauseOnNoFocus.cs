using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICities;
using UnityEngine;

namespace PauseOnNoFocus
{
    public class Mod : IUserMod
    {

        public string Description
        {
            get { return "Automatically pauses the game when it is not focused"; }
        }

        public string Name
        {
            get { return "Pause on no focus"; }
        }
    }

    public class PauseOnUnfocus : LoadingExtensionBase
    {
        public override void OnCreated(ILoading loading)
        {
            Application.runInBackground = false;
        }
    }
}
