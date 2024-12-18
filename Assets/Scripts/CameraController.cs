using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;
    [SerializeField] private Transform _directPoint;
    public Transform target;
    [SerializeField] private Vector3 _centerOffset;
    public Vector3 offset = new Vector3(0, 5, -10);
    public float sensitivity = 10f;
    public float minYAngle = -20f;
    public float maxYAngle = 60f;

    private Transform _pivot;

    public Vector3 Direct => _directPoint.position - transform.position;

    private void Awake()
    {
        Instance = this;
    }

    internal void SetPivot(Transform tPivot)
    {
        _pivot = tPivot;
    }

    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}