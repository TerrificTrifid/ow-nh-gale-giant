using OWML.Common;
using OWML.ModHelper;
using OWML.Utils;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHorizonsTemplate
{
    public class GaleGiant : ModBehaviour
    {
        public INewHorizons NewHorizonsAPI;

        private void Start()
        {
            NewHorizonsAPI = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            NewHorizonsAPI.LoadConfigs(this);
        }
    }
}
