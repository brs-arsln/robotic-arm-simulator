using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperate : MonoBehaviour
{
    [Tooltip("Mouse wheel rolling control lens please enter, the speed of the back")]
    [Range(0.5f, 2f)] public float scrollSpeed = 1f;
    [Tooltip("Right mouse button control lens X axis rotation speed")]
    [Range(0.5f, 2f)] public float rotateXSpeed = 1f;
    [Tooltip("Right mouse button control lens Y axis rotation speed")]
    [Range(0.5f, 2f)] public float rotateYSpeed = 1f;
    [Tooltip("Mouse wheel press, lens translation speed")]
    [Range(0.1f, 2f)] public float moveSpeed = 1f;
    [Tooltip("The keyboard controls how fast the camera moves")]
    [Range(0.5f, 2f)] public float keyMoveSpeed = 1f;

    public bool operate = true;
    public bool isKeyOperate = true;
    private bool isRotate = false;
    private bool isMove = false;
    private Transform m_transform;
    private Vector3 traStart;
    private Vector3 mouseStart;
    private bool isDown = false;


    // Start is called before the first frame update
    void Start()
    {
        m_transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (operate)
        {
            if (isRotate && Input.GetMouseButtonUp(1))
            {
                isRotate = false;
            }
            if (isMove && Input.GetMouseButtonUp(2))
            {
                isMove = false;
            }
            if (isRotate)
            {
                Vector3 offset = Input.mousePosition - mouseStart;

                if (isDown)
                {
                    m_transform.rotation = Quaternion.Euler(traStart + new Vector3(offset.y * 0.3f * rotateYSpeed, -offset.x * 0.3f * rotateXSpeed, 0));
                }
                else
                {
                    m_transform.rotation = Quaternion.Euler(traStart + new Vector3(-offset.y * 0.3f * rotateYSpeed, offset.x * 0.3f * rotateXSpeed, 0));
                }
                if (isKeyOperate)
                {
                    float speed = keyMoveSpeed;
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        speed = 2f * speed;
                    }
                    if (Input.GetKey(KeyCode.W))
                    {
                        m_transform.position += m_transform.up * Time.deltaTime * 5f * speed;
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        m_transform.position -= m_transform.up * Time.deltaTime * 5f * speed;
                    }
                    if (Input.GetKey(KeyCode.A))
                    {
                        m_transform.position -= m_transform.right * Time.deltaTime * 5f * speed;
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        m_transform.position += m_transform.right * Time.deltaTime * 5f * speed;
                    }
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                isRotate = true;
                mouseStart = Input.mousePosition;
                traStart = m_transform.rotation.eulerAngles;
                isDown = m_transform.up.y < -0.0001f ? true : false;
            }
            if (isMove)
            {
                Vector3 offset = Input.mousePosition - mouseStart;
                m_transform.position = traStart + m_transform.up * -offset.y * 0.1f * moveSpeed + m_transform.right * -offset.x * 0.1f * moveSpeed;
            }
            else if (Input.GetMouseButtonDown(2))
            {
                isMove = true;
                mouseStart = Input.mousePosition;
                traStart = m_transform.position;
            }
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0)
            {
                m_transform.position += m_transform.forward * scroll * 10f * Time.deltaTime * scrollSpeed;
            }

        }
    }
}