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
        // �Է��� �޾ƿ;���.
        float x = Input.GetAxisRaw("Horizontal"); // ���� - ������(D) ����(A)
        float y = Input.GetAxisRaw("Vertical"); // ���� - ��W(1) �Ʒ�S(-1)

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


        // ���� ���콺 ��ġ�� �°� ȸ���ؾ���.
        sword.LookAt( Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward); // ��ũ�� ���� ��ǥ/ ������ǥ
    }
}
