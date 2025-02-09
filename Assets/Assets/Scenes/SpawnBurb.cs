using UnityEngine;

public class SpawnBurb : MonoBehaviour
{
    public GameObject[] burbs;
    public GameObject spawnpt;
    public int i;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(i < 6)
            {
                GameObject newburb = Instantiate(burbs[i]);
                newburb.transform.position = spawnpt.transform.position;
                i++;
            }
            else
            {
                i = 0;
            }
            
        }
    }
}
