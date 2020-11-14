using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Nave : MonoBehaviour
{
    #region  Evento de Colision de nave
    public delegate void NaveColisiona(string test);
    public static event NaveColisiona OnNaveColisiona;
    public void _NaveColisiona(string test) => OnNaveColisiona?.Invoke(test);
    #endregion

    #region  Evento de Nave Explota
    public delegate void NaveExplota();
    public static event NaveExplota OnNaveExplota;
    public void _NaveExplota() => OnNaveExplota?.Invoke();
    #endregion
}
