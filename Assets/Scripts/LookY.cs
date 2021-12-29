using UnityEngine;
using Photon.Pun;

/**
 * This component rotates its object according to the mouse movement in the Y axis, in a given rotation speed.
 */
public class LookY : MonoBehaviourPun
{
    [SerializeField] private float rotationSpeed = 1f;

    void Update()
    {
        if(photonView.IsMine == false){
            return;
        }
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = transform.localEulerAngles;
        rotation.x -= mouseY * rotationSpeed;
        transform.localEulerAngles = rotation;
    }
}