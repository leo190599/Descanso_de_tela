using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descanso : MonoBehaviour
{
    [SerializeField]
    private float maxX, maxY,velocidade;
    [SerializeField]
    private Vector2 direcaoVelocidade, proximaPosicao;

    private void Start()
    {
        maxY = Mathf.Abs(maxY);
        maxX = Mathf.Abs(maxX);
        direcaoVelocidade = new Vector2(Random.value,Random.value).normalized*velocidade;
        proximaPosicao = new Vector2(0, 0);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>=maxX)
        {
            direcaoVelocidade.x = Mathf.Abs(direcaoVelocidade.x)*-1;
        }
        else if(transform.position.x <= -maxX)
        {
            direcaoVelocidade.x = Mathf.Abs(direcaoVelocidade.x);
        }
        if (transform.position.y >= maxY)
        {
            direcaoVelocidade.y = Mathf.Abs(direcaoVelocidade.y) * -1;
        }
        else if(transform.position.y <= -maxY)
        {
            direcaoVelocidade.y = Mathf.Abs(direcaoVelocidade.y);
        }

        proximaPosicao.x = Mathf.Clamp(proximaPosicao.x += direcaoVelocidade.x,-maxX,maxX);
        proximaPosicao.y = Mathf.Clamp(proximaPosicao.y += direcaoVelocidade.y, -maxY, maxY);

        transform.position = proximaPosicao;

        //transform.Translate(direcaoVelocidade*Time.deltaTime);
    }
}
