using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Nave : MonoBehaviour
{
    #region  Evento de Nave Pierde Vida
    public delegate void NavePierdeVida();
    public static event NavePierdeVida OnNavePierdeVida;
    public void _NavePierdeVida() => OnNavePierdeVida?.Invoke();
    #endregion
}
