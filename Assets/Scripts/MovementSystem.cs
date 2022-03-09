using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    private Rigidbody player;
    public float movementSpeed =50f;

    // Start is called before the first frame update
    private void Awake()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(movementSpeed * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(movementSpeed * Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(movementSpeed * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(movementSpeed * Vector3.right);
        }
    }

}
