using UnityEngine;

public class NPC : MonoBehaviour
{
    private float moveSpeed = 4f;
    private float turnSpeed = 90f;
    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }

}