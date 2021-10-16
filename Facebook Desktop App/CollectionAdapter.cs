using System.Collections.Generic;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public delegate string DisplayFunc<T>(T i_Item);

    public class CollectionAdapter<T> : ICollectionToString<T>
    {
        public DisplayFunc<T> DisplayItemStrategyMethod { get; set; }

        public ICollection<T> CollectionAdaptee { get; set; }

        public List<string> ConvertToStringList()
        {
            List<string> itemList = new List<string>();
            foreach (T item in this.CollectionAdaptee)
            {
                itemList.Add(this.DisplayItemStrategyMethod.Invoke(item));
            }

            return itemList;
        }
    }
}
