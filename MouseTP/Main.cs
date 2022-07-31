using ABI.CCK.Components;
using MelonLoader;
using System.Collections;
using UnityEngine;

namespace MeatyMouseTP
{
    public static class BuildInfo
    {
        public const string Name = "MouseTP"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for ChilloutVR"; // Description for the Mod.  (Set as null if none)
        public const string Author = "MeatCake"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "MeatCake"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class MouseTP : MelonMod
    {




        public override void OnApplicationStart() // Runs after Game Initialization.
        {





            MelonLogger.Msg("===------------------------ Keybinds -------------------------===");
            MelonLogger.Msg("===                                                           ===");
            MelonLogger.Msg("===          CTRL + LeftMouse   =   MouseTP                   ===");
            MelonLogger.Msg("===                                                           ===");
            MelonLogger.Msg("===-----------------------------------------------------------===");



            MelonCoroutines.Start(MouseTPS());


        }


        public static IEnumerator MouseTPS()
        {


            while (true)
            {
                GameObject player = GameObject.Find("_PLAYERLOCAL");

                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Mouse0))
                {
                    var r = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                    if (Physics.Raycast(r, out RaycastHit raycastHit))
                    {
                        player.transform.position = raycastHit.point;
                    }
                }

                yield return null;
            }

        }
    }
}