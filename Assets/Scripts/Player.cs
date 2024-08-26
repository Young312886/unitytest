using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private GameObject weapon;
    [SerializeField]
    private Transform shoottransform;
    [SerializeField]
    private float shootinterval = 0.05f;
    private float lastShootTime = 0f;
    // Update is called once per frame
    void Update()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");
        // Vector3 moveTo = new Vector3( horizontalInput, verticalInput, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;
        // 키보드 움직임 (가로축만)
        Vector3 moveTo = new Vector3( moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= moveTo;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += moveTo;
        }
        // 마우스로 움직임
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(position.x, -2.35f, 2.35f);
        transform.position = new Vector3( toX, transform.position.y,transform.position.z);

        // Weapon
        Shoot();
    }

    void Shoot() {
        if (Time.time - lastShootTime > shootinterval) { 

        Instantiate( weapon, shoottransform.position, Quaternion.identity );
        lastShootTime = Time.time;
        }
    }
}
