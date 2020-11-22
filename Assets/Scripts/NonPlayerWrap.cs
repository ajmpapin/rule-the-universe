using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerWrap : MonoBehaviour
{

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject playerShip = GameObject.Find ("PlayerShip");

        GameObject mainBackground = GameObject.Find ("MainBackground");
        Sprite bgSprite = mainBackground.GetComponent<SpriteRenderer>().sprite;

        Bounds playerBounds =
          new Bounds(playerShip.transform.position, bgSprite.bounds.size);


        // teleport non-player objects as player moves

        Vector3 pos = transform.position;

        if(pos.y >= playerBounds.max.y) {
            pos.y = pos.y - playerBounds.size.y;
        }

        if(pos.y <= playerBounds.min.y) {
            pos.y = pos.y + playerBounds.size.y;
        }

        if(pos.x >= playerBounds.max.x) {
            pos.x = pos.x - playerBounds.size.x;
        }

        if(pos.x <= playerBounds.min.x) {
            pos.x = pos.x + playerBounds.size.x;
        }

        transform.position = pos;

    }
}
