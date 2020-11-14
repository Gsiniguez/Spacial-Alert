using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Game : MonoBehaviour
{
   public delegate void NaveExplota();
    public static event NaveExplota OnNaveExplota;
    public void _NaveExplota() => OnNaveExplota?.Invoke();
}
