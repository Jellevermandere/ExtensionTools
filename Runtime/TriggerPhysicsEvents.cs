using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JelleVer.ExtensionTools
{
    public class TriggerPhysicsEvents : MonoBehaviour
    {
        [SerializeField]
        private ColliderEvent TriggerEnter, TriggerStay, TriggerExit;

        private void OnTriggerEnter(Collider other)
        {
            TriggerEnter.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            TriggerStay.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            TriggerExit.Invoke(other);
        }
    }
}
