using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float PlayerSpeed = 3.0f;
    public float TurnSpeed = 4.0f;

    // Update is called once per frame
    void MoveZ(float speed, int direction){
         transform.Translate(Vector3.forward * Time.deltaTime * speed* direction, Space.World );
    }
    void MoveX(float speed, int direction){
         transform.Translate(Vector3.left * Time.deltaTime * speed* direction, Space.World );
    }
    void Update()
    {
       MoveZ(PlayerSpeed,1);
       if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
           if(this.gameObject.transform.position.x > LevelBoundary.leftBoundary){
               MoveX(TurnSpeed, 1);
           }
           
       }
       if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
           if(this.gameObject.transform.position.x < LevelBoundary.rightBoundary){
               MoveX(TurnSpeed, -1);
           }
       }
    }
}
