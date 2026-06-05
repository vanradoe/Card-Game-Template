using UnityEngine;
using UnityEngine.EventSystems;
public class DraggableUI : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    public GameManager gm;
    private Canvas canvas;
    public bool card_played = false;
    public bool can_be_dragged = true;

    void Awake()
    {
        if (can_be_dragged == true)
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        gm = FindAnyObjectByType<GameManager>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
    // Called once when the drag starts
    //Debug.Log("Started dragging " + gameObject.name);
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (can_be_dragged == true)
            // Called every frame while dragging
            rectTransform.anchoredPosition += eventData.delta /
            canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    // Called once when the drag ends
    //Debug.Log("Finished dragging " + gameObject.name);

        if(card_played)
        {
            //gm.Player_Turn();
            can_be_dragged = false;
            //make it so during player turn cards cannot be moved using a bool like can_be_dragged and apply it to the code
            //reference it in the gm and then apply it when card has been played by the player

        }
    }
}