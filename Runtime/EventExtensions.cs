using UnityEngine.Events;
using UnityEngine;

namespace JelleVer.ExtensionTools
{
    [System.Serializable]
    public class IntEvent : UnityEvent<int> { }
    [System.Serializable]
    public class FloatEvent : UnityEvent<float> { }
    [System.Serializable]
    public class StringEvent : UnityEvent<string> { }
    [System.Serializable]
    public class ColliderEvent : UnityEvent<Collider> { }


}



