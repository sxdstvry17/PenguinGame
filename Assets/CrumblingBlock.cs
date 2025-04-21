using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblingBlock : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
