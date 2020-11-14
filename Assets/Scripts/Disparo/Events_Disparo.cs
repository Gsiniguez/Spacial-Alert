using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events_Disparo : MonoBehaviour
{
    public delegate void DisparoInpacta(GameObject asteroide, float danio);
    public static event DisparoInpacta OnDisparoInpacta;
    public void _DisparoInpacta(GameObject asteroide, float danio) => OnDisparoInpacta?.Invoke(asteroide, danio);
}
