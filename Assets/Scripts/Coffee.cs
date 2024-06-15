using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    [SerializeField] private float _effectTime = 5f;
    [SerializeField] private float _dissappearingTime = 1f;
    [SerializeField] private float _speedOfAnim = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.TryGetComponent(out Mover mover)) // .gameObject.TryGetComponent(out Mover mover))
        {
            StartCoroutine(DissappearingProcess());
            StartCoroutine(CoffeeEffect(mover));
        }
    }

    private IEnumerator CoffeeEffect(Mover mover)
    {
        mover.speed = mover.speed + 2f;
        mover.jumpForce = mover.jumpForce + 200f;

        yield return new WaitForSeconds(_effectTime);
        Object currentObject = mover.gameObject.GetComponentInChildren<Object>();

        mover.speed = currentObject.speed;
        mover.jumpForce = currentObject.jumpForce;
        transform.localScale = Vector3.one;
    }

    private IEnumerator DissappearingProcess() //����������
    {
        float i = 0f;
        float rate = (1f / _dissappearingTime);

        while (i < 1f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, i);
            yield return null;
        }
    }
}
