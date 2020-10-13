using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Puntos : MonoBehaviour
{
    public delegate void PuntuacionEtapa(int etapa);
    public static event PuntuacionEtapa OnPuntuacionEtapa;
    public void _PuntuacionEtapa(int etapa) => OnPuntuacionEtapa?.Invoke(etapa);
}
