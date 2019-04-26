using UnityEngine;
using System.Collections;

public class MapScript2 : MonoBehaviour
{

    public GameObject treePrefab;
    public GameObject movingObj;

    void Start()
    {
        StartCoroutine(MoveMap());
        StartCoroutine(SetTree());
    }

    IEnumerator SetTree()
    {
        while (true)
        {
            Vector3 pos = new Vector3(11, -3.6f, 0);
            GameObject tree = Instantiate(treePrefab, pos, transform.rotation) as GameObject;
            tree.transform.parent = movingObj.transform;
            yield return new WaitForSeconds(0.7f);
        }
    }

    IEnumerator MoveMap()
    {
        while (true)
        {
            Vector3 pos = movingObj.transform.position;
            pos.x -= 1 * Time.deltaTime;
            movingObj.transform.position = pos;
            yield return 0;
        }
    }

}