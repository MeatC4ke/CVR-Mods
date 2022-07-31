using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using System.Collections;
using Extension;
using ABI.CCK.Components;

namespace Mirror
{
    internal class PortableMirror
    {
        public static void ToggleMirror(bool State)
        {
            


            if (!State && _mirror != null)
            {
                UnityEngine.Object.Destroy(_mirror);
                _mirror = null;
            }
            else if (State)
            {
                GameObject player = GameObject.Find("_PLAYERLOCAL");
                Vector3 pos = player.transform.position + player.transform.forward;
                pos.y += _mirrorScaleY / 1.7f;
                GameObject mirror = GameObject.CreatePrimitive(PrimitiveType.Quad);
                mirror.transform.position = pos;
                mirror.transform.rotation = player.transform.rotation;
                //mirror.transform.localScale = new Vector3(_mirrorScaleX, _mirrorScaleY, 1f);
                mirror.transform.localScale = new Vector3(3f, 3f, 1f);
                mirror.name = "PortableMirror";
                UnityEngine.Object.Destroy(mirror.GetComponent<Collider>());
                mirror.GetOrAddComponent<BoxCollider>().size = new Vector3(1f, 1f, 0.05f);
                mirror.GetOrAddComponent<BoxCollider>().isTrigger = true;
                mirror.GetOrAddComponent<MeshRenderer>().material.shader = Shader.Find("FX/MirrorReflection");
                mirror.GetOrAddComponent<CVRMirror>().m_ReflectLayers = new LayerMask
                
                {
                    value = _optimizedMirror ? 263680 : -1025
                };
                mirror.GetOrAddComponent<CVRPickupObject>();
                mirror.GetOrAddComponent<CVRPickupObject>().enabled = false;
                mirror.GetOrAddComponent<Rigidbody>().useGravity = false;
                mirror.GetOrAddComponent<Rigidbody>().isKinematic = true;
                _mirror = mirror;
            }
        }

        private static GameObject _mirror;
        private static float _mirrorScaleX = 4;
        private static float _mirrorScaleY = 2.5f;
        private static bool _optimizedMirror = false;
        private static bool _canPickupMirror = true;



        

    }
}
