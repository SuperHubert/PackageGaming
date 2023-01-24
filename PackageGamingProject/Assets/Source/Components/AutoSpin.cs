using UnityEngine;

public class AutoSpin : MonoBehaviour
{
    [SerializeField] private float amount;
    
    private void Update()
    {
        transform.localRotation *= Quaternion.Euler(new Vector3(0,amount,0));
    }
}
