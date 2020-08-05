using System.Collections.Generic;

namespace csharp_collections_practice{

    public class ItemCounter<T>{

        public Dictionary<T, int> CountItems(T[] items){

            Dictionary<T, int> itemTable = new Dictionary<T, int>();

            foreach( T item in items){
                if(itemTable.ContainsKey(item)){
                    itemTable[item] = itemTable[item] + 1; 
                }else{
                    itemTable.Add(item, 1);
                }
            }
            return itemTable;
        }
    }



}