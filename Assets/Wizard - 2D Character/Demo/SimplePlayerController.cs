using System;
using System.Security.Claims;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace ClearSky
{
    public class SimplePlayerController : MonoBehaviour
    {
        public float movePower = 10f;

        private Rigidbody2D rb;
        private Animator anim;
        Vector3 movement;
        private int direction = 1;
        private bool alive = true;

        private SpartaTownController controller;
        private GameObject Player;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            if (controller != null)
            {
                controller.OnLookEvent += OnAim;
            }
        }

        private void OnAim(Vector2 direction)
        {
            RotateArm(direction);
        }
        private void RotateArm(Vector2 direction)
        {
            float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            if (rotZ > 90f || rotZ < -90f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        private void Update()
        {
            Restart();
            if (alive)
            {
                Run();

            }
        }

        void Run()
        {
            Vector3 moveVelocity = Vector3.zero;
            anim.SetBool("isRun", false);

            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");


            movement = new Vector3(horizontalInput, verticalInput, 0);

            // 이동 방향에 따라 애니메이션 및 이동 처리
            if (movement != Vector3.zero)
            {
                anim.SetBool("isRun", true);
                rb.MovePosition(transform.position + movement.normalized * movePower * Time.deltaTime);
            }
            else
            {
                anim.SetBool("isRun", false);
            }
            transform.position += moveVelocity * movePower * Time.deltaTime;
        }

        void Restart()
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                anim.SetTrigger("idle");
                alive = true;
            }
        }
    }
}