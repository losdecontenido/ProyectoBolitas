[UnityEngine.DisallowMultipleComponent]
[UnityEngine.RequireComponent(typeof(UnityEngine.MeshRenderer))]
public class EscalarTablero : UnityEngine.MonoBehaviour
{
    //--|||--|||--
    #region Propiedades Clase
    [UnityEngine.SerializeField] private UnityEngine.Material materialTablero;
    [UnityEngine.SerializeField] private UnityEngine.Renderer renderizadorTablero;
    #endregion
    //--|||--|||--
    #region Propiedades Logica
    private long segundosTranscurridos = 0;
    private double escalaMaterial = 1.0;
    private bool iteradorEscala = true;
    #endregion
    //--|||--|||--
    #region Propiedades Constantes
    private const float reduccionEscalaSegundo = 0.0208333333333333f;
    private const float escalaMesh = 3.75f;
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
        StartCoroutine(DesescalarTablero(1f));
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
    private System.Collections.IEnumerator DesescalarTablero(float tiempo)
    {
        while (iteradorEscala)
        {
            segundosTranscurridos++;
            yield return new UnityEngine.WaitForSeconds(tiempo);
            if (transform.lossyScale.x >= 1)
            {
                float medida = escalaMesh - (reduccionEscalaSegundo * segundosTranscurridos);
                transform.localScale = new UnityEngine.Vector3(medida, medida, 1);
                materialTablero.SetTextureScale("_MainTex", new UnityEngine.Vector2(medida, medida));
            } else
            {
                iteradorEscala = false;
            }
        }
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
