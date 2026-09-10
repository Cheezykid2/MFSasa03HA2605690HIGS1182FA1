using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class PlayerController : MonoBehaviour
{
    public float movespeed = 10f;
    public Camera playerCam;
    public float rayDistance = 50f;

    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    void HandleMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movespeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                Debug.Log("Hit: " + hit.collider.name);
                // You can add more logic here for what happens when the player shoots an object
            }
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}