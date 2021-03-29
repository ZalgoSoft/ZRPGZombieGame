using UnityEngine;

public class ZombieNPC : MonoBehaviour
{
    public float detectRadius = 999f;
    Rigidbody rr;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rr = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 100f)
            rr.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, Time.fixedDeltaTime * 3f));
        //Rigidbody rb;
        //Collider[] hitColliders =
        //Physics.OverlapSphere(
        //transform.position,
        //detectRadius,
        //1 << LayerMask.NameToLayer("Player")
        //);
        //if (hitColliders.Length > 0)
        //rr.MovePosition(Vector3.MoveTowards(transform.position, hitColliders[0].transform.position, Time.deltaTime * 3f));
        //foreach (var hitCollider in hitColliders)
        //{
        //  if (hitCollider.TryGetComponent<Rigidbody>(out Rigidbody rb))
        //    rr.MovePosition(Vector3.MoveTowards(transform.position, rb.position, Time.deltaTime * 3f * 10f));
        //}
    }
}
