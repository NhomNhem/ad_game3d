using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform target;

   private float yCameraOffset ;

   void Start()
   {
      yCameraOffset = transform.position.y;
   }

   void Update()
   {
      transform.position = new Vector3(target.position.x, yCameraOffset, target.position.z);

      transform.rotation = Quaternion.Euler(90, target.eulerAngles.y, 0);
   }
}
