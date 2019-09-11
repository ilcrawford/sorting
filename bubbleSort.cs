namespace sorting
{
    public class bubbleSort : ISort
    {
        public int[] Sort(int[] aList)
        {
            int i = 0;
            for (i = 0; i < aList.Length-1; i++)
            {
                for(int j = i+1; j < aList.Length; j++)
                {
                    if (aList[j] < aList[i])
                    {
                        int t = aList[i];
                        aList[i] = aList[j];
                        aList[j] = t;   

                    }
                        
                }
            }
            return aList;
        }
    }
}