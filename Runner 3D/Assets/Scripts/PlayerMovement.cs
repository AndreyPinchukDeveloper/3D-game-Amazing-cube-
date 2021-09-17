using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public Rigidbody rb;
    // Update is called once per frame

    public float forwardForce = 900f; // задавая параметр словом, у нас появится возможность в Инспекторе менять значение(справа) даже во время игры! очень удобно, что бы не открывать заново скрипт и не шаманить
    public float slidewaysForce = 600f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//дельта тайм тут для того, что бы наш объект на слабых и мощных компах летел с одинаковой скоростью, если без него то на норм компах объект быдет ехать быстрее

        if (Input.GetKey("d"))
        {
            rb.AddForce(slidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-slidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)//если игрок упадет с поля, то конец игры
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}