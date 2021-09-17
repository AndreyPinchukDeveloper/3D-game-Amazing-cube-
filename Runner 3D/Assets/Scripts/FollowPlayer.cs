using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;

    public Vector3 offset;// Vector free is usless when we use X Y Z

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;//привязываем камеру к конкретному объекту(в данной игре к нашему квадрату) за счет того, что пишем слово transform с маленькой буквы т
    }
}
