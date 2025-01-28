using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class TouchMove : MonoBehaviour
{
    void Awake()
    {
        EnhancedTouchSupport.Enable();
    }

    void Update()
    {
        //counting to see if there is more than one touch
        if (Touch.activeTouches.Count > 0)
        {
            Touch myTouch = Touch.activeTouches[0];
            //Vector2 touchPos = Camera.main.ScreenToWorldPoint(myTouch.screenPosition);
            //Consulted ChatGPT because I noticed each touch would move every obstruction block and paddle on my screen
            //Collider2D touchedCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(myTouch.screenPosition));
            //if (touchedCollider != null && touchedCollider.transform == this.transform)
            
                if (myTouch.phase == TouchPhase.Began || myTouch.phase == TouchPhase.Moved)
                {
                    Vector2 newPos = Camera.main.ScreenToWorldPoint(myTouch.screenPosition);
                    newPos.y = transform.position.y;
                    transform.position = newPos;
                }
            
            
        }
    }
}