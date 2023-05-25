using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    
    public float smoothTime;

    private Vector2 velocity;
  //  public Vector2 minCamPos, maxCamPos; // para limitar la camara
    public GameObject follow;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime);

      //  transform.position = new Vector3(Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),Mathf.Clamp(posY, minCamPos.x, maxCamPos.x),transform.position.z);
    }
}
