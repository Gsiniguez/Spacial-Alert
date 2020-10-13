using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Nave : MonoBehaviour
{
    public delegate void NaveColisiona();
    public static event NaveColisiona OnNaveColisiona;
    public void _NaveColisiona() => OnNaveColisiona?.Invoke();
}
