using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    public Vector3 offset;// Vector free is usless when we use X Y Z

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;//����������� ������ � ����������� �������(� ������ ���� � ������ ��������) �� ���� ����, ��� ����� ����� transform � ��������� ����� �
    }
}
