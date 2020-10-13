using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Vida : MonoBehaviour
{
    public delegate void AgregarVida();
    public static event AgregarVida OnAgregarVida;
    public void _AgregarVida() => OnAgregarVida?.Invoke();

    public delegate void QuitarVida();
    public static event QuitarVida OnQuitarVida;
    public void _QuitarVida() => OnQuitarVida?.Invoke();
}
