namespace Game.Player;

internal class Inventory
{
    
    public int ItemCount { get; set; }
    public string[] Items {  get; set; }
    public Inventory()
    {
        Items = new string[5];
    }
    public void AddItem(string item)
    {
        if(ItemCount >= 5)
        {
            Console.WriteLine("Your inventory is full.");
        }
        else
        {
            Items[ItemCount] = item;
            ItemCount++;
        }
    }
    public void RemoveItem(string item)
    {
        for (int i = 0; i < ItemCount; i++)
        {
            if (Items[i] == item)
            {
                for (int j = i; j < ItemCount-1; j++)
                {
                    Items[j] = Items[j + 1];
                   
                   
                }
                ItemCount--;
                break;

            }
            
        }
        
    }
}
