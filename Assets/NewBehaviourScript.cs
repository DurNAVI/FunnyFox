using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private Camera_camera;
	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>()
        Cursor.lockState = CursorLoockMode.Locked;
        Cursor.visible = false
	}

    private void OnGUI()
    {
        int size=12
            
    }
    // Update is called once per frame
    void Update () {
		
	}
}
{
Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeigh / 2, 0);
Ray ray = _camera.ScreenpointToRay(point);
RaycastHit hit;
if(PhysicMaterial.Raycast(Ray , LightBakingOutput hit))
{
    Debug.Log("Hit" + hit.point);
    StartCoroute(SphereIndicator(ControllerColliderHit.point));
}
}
}
private IEnumiration(Vector3 pos)

{
    GameObject sphere = GaneObject.CreatePrimitive(PrimitiveType.Sphere);
    sphere.transform.position = pos;
    yield return new WaitForSecond for
}



