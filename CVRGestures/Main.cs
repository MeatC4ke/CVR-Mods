using ABI.CCK.Components;
using ABI_RC.Core.Player;
using MelonLoader;
using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;



namespace CVRGesturesNameSpace
{
    public static class BuildInfo
    {
        public const string Name = "CVRGestures"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for ChilloutVR"; // Description for the Mod.  (Set as null if none)
        public const string Author = "MeatCake"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "MeatCake"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class CVRGestures : MelonMod
    {




        public override void OnApplicationStart() // Runs after Game Initialization.
        {





            



            MelonCoroutines.Start((LoopCVRGestures()));


        }


        public static IEnumerator LoopCVRGestures()
        {


            while (true)
            {
                GameObject player = GameObject.Find("_PLAYERLOCAL");

               

                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F1)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(0);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F2)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(1);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F3)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(2);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F4)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(3);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F5)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(4);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F6)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(5);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F7)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(6);

                }
                if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.F8)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureLeft(7);

                }




                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F1)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(0);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F2)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(1);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F3)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(2);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F4)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(3);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F5)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(4);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F6)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(5);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F7)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(6);

                }
                if (Input.GetKey(KeyCode.RightShift) && (Input.GetKeyDown(KeyCode.F8)))
                {
                    player.GetComponent<PlayerSetup>().SetGestureRight(7);

                }


                yield return null;
            }

        }
    }
}