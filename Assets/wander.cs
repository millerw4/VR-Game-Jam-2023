using UnityEngine;
using System.Collections;

public class wander : MonoBehaviour
{
    [SerializeField]
    private Transform NavTarget;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("NewTarget");
    }

    IEnumerator NewTarget() {
        while(true) {
            float radius = Random.Range(3.0f, 5.0f);
            Vector3 targetRandomPosition = Random.onUnitSphere*radius;
            Vector3 newPos = transform.position + targetRandomPosition;
            Debug.Log(newPos);
            NavTarget.position = newPos;
            float interval = Random.Range(1.0f, 5.0f);
            yield return new WaitForSeconds(interval);
        }
    }
}
