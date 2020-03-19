[UnityEngine.DisallowMultipleComponent]
[UnityEngine.RequireComponent(typeof(UnityEngine.Rigidbody))]
[UnityEngine.RequireComponent(typeof(UnityEngine.MeshFilter))]
[UnityEngine.RequireComponent(typeof(UnityEngine.MeshCollider))]
public class CambiarForma : UnityEngine.MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    [UnityEngine.SerializeField] private UnityEngine.PhysicMaterial[] materialCorrespondienteForma;
    [UnityEngine.SerializeField] private UnityEngine.Mesh[] mesh;
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    private UnityEngine.MeshFilter cuerpoVisible;
    private UnityEngine.MeshCollider cuerpoTangible;
    #endregion
    //--|||--|||--
    #region Propiedades Constantes

    #endregion
    //--|||--|||--





    //--|||--|||--
    #region Metodos MonoBehaviour
    private void Awake()
    {
        cuerpoVisible = GetComponent<UnityEngine.MeshFilter>();
        cuerpoTangible = GetComponent<UnityEngine.MeshCollider>();
    }
    private void OnEnable()
    {
    }
    private void Start()
    {
        byte seleccion = (byte)UnityEngine.Random.Range(0, 2);
        print(seleccion);
        switch (seleccion)
        {
            case 0:
                CambiarPiramide();
                break;
            case 1:
                CambiarEsfera();
                break;
            default:
                break;
        }
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
    private void CambiarPiramide()
    {
        cuerpoVisible.mesh = mesh[0];
        cuerpoTangible.material = materialCorrespondienteForma[0];
        cuerpoTangible.sharedMesh = mesh[0];
    }
    private void CambiarRectangulo()
    {
        cuerpoVisible.mesh = mesh[2];
        cuerpoTangible.material = materialCorrespondienteForma[2];
    }
    private void CambiarEsfera()
    {
        cuerpoVisible.mesh = mesh[1];
        cuerpoTangible.material = materialCorrespondienteForma[1];
        cuerpoTangible.sharedMesh = mesh[1];
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
