using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    // Use this for initialization
    void Start()
    {
        Vector3 pos = Vector3.zero;
        prefab.AddComponent(typeof(Rotate));
        prefab.GetComponent<Rotate>().RotationAngle = 120;
        Instantiate(prefab, pos, Quaternion.identity);
    }
}