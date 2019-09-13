namespace sorting
{
    public class selectionSort : ISort
    {
        public int[] Sort(int[] aList)
        {
            int i = 0;
            for (i = 0; i < aList.Length-1; i++)
            {
                int smallest = i;
                for(int j = i+1; j < aList.Length; j++)
                {
                    if (aList[j] < aList[smallest])
                    {
                        smallest = j;

                    }
   
                }

                int t = aList[i];

                aList[i] = aList[smallest];
                aList[smallest] = t;
                utils.print(aList);


            }
            return aList;
        }
    }
}