using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private int timeToWait = 3;

    private Rigidbody _rigidbody;

    private MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            _rigidbody.useGravity = true;
            _meshRenderer.enabled = true;
        }
    }
}