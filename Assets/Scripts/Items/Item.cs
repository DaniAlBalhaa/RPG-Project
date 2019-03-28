using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    new public string name = "New Item"; //Name 
    public Sprite icon = null; //Icon
    public bool isDefaultItem = false; //Default Wear?

    public virtual void Use ()
    {
        //Use the item
        //Something might happen

        Debug.Log("Using " + name);
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }


}
