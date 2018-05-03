using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float Speed = 10f;
    private GameObject Cube;

	void Start ()
    {
        Cube = this.gameObject;
    }
	
	void Update ()
	{
	    Cube.transform.position += Vector3.forward * Time.deltaTime * Speed;
	}
}
