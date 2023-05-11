using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private Vector2 touchStartPos;
    private float rotationSpeed = 0.1f;
    private float damping = 0.2f;

    private float rotationX = 180f;
    private float rotationY = 0f;

    void Update() {
        if (Input.touchCount == 1) {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began) {
                touchStartPos = touch.position;
            } else if (touch.phase == TouchPhase.Moved) {
                Vector2 currentTouchPos = touch.position;
                Vector2 touchDelta = currentTouchPos - touchStartPos;

                rotationX -= touchDelta.x * rotationSpeed * damping;
                //rotationY -= touchDelta.y * rotationSpeed * damping;

                transform.rotation = Quaternion.Euler(rotationY, rotationX, 0f);
            }
        }
    }
}
