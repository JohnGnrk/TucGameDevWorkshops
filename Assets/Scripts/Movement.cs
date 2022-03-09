using UnityEngine;

public class Movement : MonoBehaviour
{
    float movementSpeed = 4f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5)
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -5)
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z <5)
        {
            transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.x > -5)
        {
            transform.position += Vector3.back * movementSpeed * Time.deltaTime;
        }
    }
}
