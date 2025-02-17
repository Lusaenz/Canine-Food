using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
  private float topBound = 30;
  private float lowerBound = -10;
  void Update()
  {
    destructionObject();
  }

  private void destructionObject()
  {
    if (transform.position.z > topBound)
    {
      Destroy(gameObject);
    }
    else if (transform.position.z < lowerBound)
    {
      Destroy(gameObject);
    }
  }
}
