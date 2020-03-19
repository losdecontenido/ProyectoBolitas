[UnityEngine.DisallowMultipleComponent]
[UnityEngine.RequireComponent(typeof(UnityEngine.MeshRenderer))]
public class CambiarSkin : UnityEngine.MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    private UnityEngine.MeshRenderer renderizadorMesh;
    private UnityEngine.Material[] materialesCarasCirculares;
    private UnityEngine.Material[] materialesCarasTriangulares;
    #endregion
    //--|||--|||--
    #region Propiedades Logica

    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion
    //--|||--|||--





    //--|||--|||--
    #region Metodos MonoBehaviour
    private void Awake()
    {
    }
    private void OnEnable()
    {
    }
    private void Start()
    {
    }
    private void Update()
    {
    }
    private void FixedUpdate()
    {
    }
    private void LateUpdate()
    {
    }
    private void OnDisable()
    {
    }
    #endregion





    //--|||--|||--
    #region Metodos Clase
    private void Metodo()
    {
    }
    #endregion
}
/*
[UnityEngine.Header("Propiedades")]
public UnityEngine.Events.UnityEvent habilidadActivada;
public EventoHabilidad eventoHabilidadLlamada;
[System.Serializable] public class EventoHabilidad : UnityEngine.Events.UnityEvent<TipoHabilidadSeleccionado.Habilidad, short> { }
public System.Collections.Generic.List<ListaAniadadaTransform> lista = new System.Collections.Generic.List<ListaAniadadaTransform>();

[UnityEngine.SerializeField, UnityEngine.Tooltip("Descripcion de algo"), UnityEngine.Range(0, 9)] private short numero;
[UnityEngine.Space]
[UnityEngine.TextArea] public string texto = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja.";
private string name = "Suresh Dasari";
public string Name
{
    get
    {
      name.ToUpper();
    }
    set
    {
        if (value == "Suresh")
            name = value;
    }
}
//--|||--|||--
[UnityEditor.MenuItem("Tools/Decir/Hola")]
public static void Hola()
{
    Debug.Log("Hola mundo");
}
public struct NombreStructura
{
    int a = 0;
    int z = 0;
};
public enum enumerador
{
    norte, sur, este, oeste
};
private System.Collections.IEnumerator Corrutina()
{
    yield return new UnityEngine.WaitForEndOfFrame();
}
[System.Serializable]
public class ListaAniadadaTransform
{
    public System.Collections.Generic.List<UnityEngine.Transform> listaAnidada;
}
*/
