using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.01f;

    private float InitMousePosX, InitMousePosZ;
    private float CurrMousePosX, CurrMousePosZ;

    public GameManager gameManager;

    [SerializeField] Animator animationController;

    public GameObject tutorialPanel;


    // Update is called once per frame
    void Update()
    {

        if(gameManager.isUIActive == true)
        {
            tutorialPanel.SetActive(false);
            animationController.SetBool("IsMoving", false);
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            tutorialPanel.SetActive(false);
            InitMousePosX = Input.mousePosition.x;
            InitMousePosZ = Input.mousePosition.y;
            Debug.Log("Mouse Button Pressed");
        }

        if (Input.GetMouseButton(0))
        {
            animationController.SetBool("IsMoving", true);

            CurrMousePosX = Input.mousePosition.x;
            CurrMousePosZ = Input.mousePosition.y;

            float dragX = CurrMousePosX - InitMousePosX;
            float dragZ = CurrMousePosZ - InitMousePosZ;



            dragX = dragX <= 200 ? dragX : 200;
            dragX = dragX >= -200 ? dragX : -200;

            dragZ = dragZ <= 200 ? dragZ : 200;
            dragZ = dragZ >= -200 ? dragZ : -200;

            transform.position = new Vector3(transform.position.x + (dragX * speed * Time.deltaTime),
                                             transform.position.y,
                                             transform.position.z + (dragZ * speed * Time.deltaTime));


            Vector3 movementDir = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y")).normalized;

            Debug.Log("MovementDir Value : " + movementDir);

            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(movementDir),
                                                  Time.deltaTime * 3);
        }

        if (Input.GetMouseButtonUp(0))
        {
            animationController.SetBool("IsMoving", false);
        }

    }

}
