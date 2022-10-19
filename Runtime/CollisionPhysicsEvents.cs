using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JelleVer.ExtensionTools
{
    public class CollisionPhysicsEvents : MonoBehaviour
    {
        [SerializeField]
        private ColliderEvent CollisionEnter, CollisionStay, CollisionExit;

        private void OnCollisionEnter(Collision collision)
        {
            CollisionEnter.Invoke(collision.collider);
        }

        private void OnCollisionStay(Collision collision)
        {
            CollisionStay.Invoke(collision.collider);
        }

        private void OnCollisionExit(Collision collision)
        {
            CollisionExit.Invoke(collision.collider);
        }



    }
}


