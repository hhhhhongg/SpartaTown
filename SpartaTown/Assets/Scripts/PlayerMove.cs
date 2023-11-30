using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    SpriteRenderer sprite;
    public Transform sword;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // 입력을 받아와야함.
        float x = Input.GetAxisRaw("Horizontal"); // 수평 - 오른쪽(D) 왼쪽(A)
        float y = Input.GetAxisRaw("Vertical"); // 수직 - 위W(1) 아래S(-1)

        transform.position += new Vector3(x, y).normalized * Time.deltaTime * speed;

        float a = Input.GetAxis("Mouse X");
        float b = Input.GetAxis("Mouse Y");

        Vector3 mousePos = Input.mousePosition;

        //sprite.flipX = (Input.mousePosition.x < Screen.width / 2) ? true : false;
        if (mousePos.x < Screen.width / 2)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipY = false;
        }


        // 검이 마우스 위치에 맞게 회전해야함.
        sword.LookAt( Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward); // 스크린 상의 좌표/ 월드좌표
    }
}
