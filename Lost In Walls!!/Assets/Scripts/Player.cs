using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float h, v; //inputs
    public float speed; //declaracao de velocidade
    public CharacterController cc;
    void Start()
    {
        
    }

    
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, 0);
        cc.Move(dir * speed * Time.deltaTime); //movimentacao sem gravidade
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
