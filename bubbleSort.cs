namespace sorting
{
    public class bubbleSort: ISort
    {
        public int[] Sort(int[] aList)
        {
            int i = 0;
            
            for (i = 0; i < aList.Length; i++)
            {
               
                for(int j = 0; j < aList.Length-1; j++)
                {
                    if (aList[j] > aList[j+1])
                    {
                        int t = aList[j];
                        aList[j] = aList[j+1];
                        aList[j+1] = t;   

                    }

                     utils.print(aList);   
                }
            }
            return aList;
        }
    }
}