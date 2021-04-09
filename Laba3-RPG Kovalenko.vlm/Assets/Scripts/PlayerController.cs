using Assets.Scripts;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private LayerMask objects;
    private Camera mainCamera;
    private NavMeshAgent agent;
    private Interactable interact;

    void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        if (agent.remainingDistance <= agent.stoppingDistance)
            animator.SetBool("Walk", false);
    }


    void Update()
    {
        if (interact != null)
        {
            if (agent.remainingDistance <= interact.Radius)
            {
                agent.SetDestination(gameObject.transform.position);
                interact.Interact();
                RemoveInteract();
            }
        }

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.SetDestination(hit.point);
                animator.SetBool("Walk", true);

                SetInteract(hit.collider.GetComponent<Interactable>());
            }
        }
    }

    void SetInteract(Interactable interactable)
    {
        interact = interactable;
    }

    void RemoveInteract()
    {
        interact = null;
    }
}
