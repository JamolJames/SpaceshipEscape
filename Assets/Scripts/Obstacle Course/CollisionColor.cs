using UnityEngine;

public class CollisionColor : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.3f, 0.4f, 0.6f, 0.3f);
    }


}
