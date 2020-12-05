using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject DiamondDObj;
    // Start is called before the first frame update
    void Start()
    {
        DiamondDObj = GameObject.FindGameObjectWithTag("DiamondD");
        DiamondDObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(ActivateDiamond());
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    IEnumerator ActivateDiamond()
    {
        DiamondDObj.SetActive(true);
        yield return new WaitForSeconds(5f);
        DiamondDObj.SetActive(false);
    }
}
