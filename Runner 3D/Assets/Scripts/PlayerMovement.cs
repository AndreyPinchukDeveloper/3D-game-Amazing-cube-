using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public Rigidbody rb;
    // Update is called once per frame

    public float forwardForce = 900f; // ������� �������� ������, � ��� �������� ����������� � ���������� ������ ��������(������) ���� �� ����� ����! ����� ������, ��� �� �� ��������� ������ ������ � �� ��������
    public float slidewaysForce = 600f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//������ ���� ��� ��� ����, ��� �� ��� ������ �� ������ � ������ ������ ����� � ���������� ���������, ���� ��� ���� �� �� ���� ������ ������ ����� ����� �������

        if (Input.GetKey("d"))
        {
            rb.AddForce(slidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-slidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)//���� ����� ������ � ����, �� ����� ����
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}