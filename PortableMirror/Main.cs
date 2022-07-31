using ABI.CCK.Components;
using MelonLoader;
using System.Collections;
using UnityEngine;

namespace MeatyMirror
{
    public static class BuildInfo
    {
        public const string Name = "PortableMirror"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for ChilloutVR"; // Description for the Mod.  (Set as null if none)
        public const string Author = "MeatCake"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "MeatCake"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class PortableMirror : MelonMod
    {




        public override void OnApplicationStart() // Runs after Game Initialization.
        {



           

            MelonLogger.Msg("===------------------------ Keybinds -------------------------===");
            MelonLogger.Msg("===                                                           ===");
            MelonLogger.Msg("===              Spawn Mirror   =   1                         ===");
            MelonLogger.Msg("===                   Scale +   =   Numpad +                  ===");
            MelonLogger.Msg("===                   Scale -   =   Numpad -                  ===");
            MelonLogger.Msg("===                Pickupable   =   Numpad Enter              ===");
            MelonLogger.Msg("===                                                           ===");
            MelonLogger.Msg("===-----------------------------------------------------------===");



            MelonCoroutines.Start(Starter());

            
        }

        public IEnumerator Starter()
        {

            yield return new WaitForSeconds(1f);
            MelonCoroutines.Start(KeyBinds());

        }
        public static IEnumerator KeyBinds()
        {


            while (true)
            {

                var Alpha1 = Input.GetKeyDown(KeyCode.Alpha1); 
                var Plus = Input.GetKeyDown(KeyCode.KeypadPlus);
                var Minus = Input.GetKeyDown(KeyCode.KeypadMinus);
                var NumpadEnter = Input.GetKeyDown(KeyCode.KeypadEnter);
                GameObject SpawnMirror = GameObject.Find("PortableMirror");



                if (Alpha1)
                {
                    if (SpawnMirror == null)
                    {
                        Mirror.PortableMirror.ToggleMirror(true);
                    }
                    else
                    {
                        Mirror.PortableMirror.ToggleMirror(false);
                    }


                }

                if(Plus)
                {
                    SpawnMirror.transform.localScale += new Vector3(0.1f, 0.1f, 0f);
                }

                if (Minus)
                {
                    SpawnMirror.transform.localScale -= new Vector3(0.1f, 0.1f, 0f);
                }

                if (NumpadEnter)
                {
                    if (SpawnMirror.GetComponent<CVRPickupObject>().enabled == false)
                    {
                        SpawnMirror.GetComponent<CVRPickupObject>().enabled = true;
                    }

                    else
                    { 
                        SpawnMirror.GetComponent<CVRPickupObject>().enabled = false;
                    }
                }

                    yield return null;

            }
        }
    }
}