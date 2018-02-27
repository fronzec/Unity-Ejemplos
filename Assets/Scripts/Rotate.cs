using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float rotationAngle = 30f ;

    public float RotationAngle
    {
        get { return rotationAngle; }
        set { rotationAngle = value; }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationAngle * Time.deltaTime);
    }
}