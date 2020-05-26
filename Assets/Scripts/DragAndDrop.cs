using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Vector2 pos = Input.mousePosition;

        Vector3 objPos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 1f));

        transform.position = objPos;
    }
}
