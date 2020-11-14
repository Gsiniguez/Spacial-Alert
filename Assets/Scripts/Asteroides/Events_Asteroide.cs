using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_Asteroide : MonoBehaviour
{

    public delegate void AsteroideExplota(GameObject asteroide);
    public static event AsteroideExplota OnAsteroideExplota;
    public void _AsteroideExplota(GameObject asteroide) => OnAsteroideExplota?.Invoke(asteroide);



    public delegate void AsteroideImpactar();
    public static event AsteroideImpactar onAsteroideImpactar;
    public void _AsteroideImpactar() => onAsteroideImpactar?.Invoke();


}
