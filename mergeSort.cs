using System.Collections.Generic;

namespace sorting
{
    public class mergeSort : ISort
    {
        public int[] Sort(int[] aList)
        {
            List<int> list1 = new List<int>();
            list1.AddRange(aList);
            utils.print(list1);            

            List<List<int>> buckets = new List<List<int>>();
            buckets.Add(list1);

            var splitList = split(buckets);

            //utils.print(splitList);

            var mergeList = merge(splitList);
            
            return(mergeList.ToArray());
        }

        private List<List<int>> split(List<List<int>> aListsToSplit)
        {

            List<List<int>> splitList = new List<List<int>>();
            
            bool done = true;

            foreach(List<int> list in aListsToSplit)
            {
                
                if (list.Count > 1)
                {
                    int len = list.Count;
                    int end1 = len / 2;
                    
                    List<int> list1 = new List<int>();
                    List<int> list2 = new List<int>();
                    splitList.Add(list1);
                    splitList.Add(list2);
                    for(int i =0;i<end1;i++)
                    {
                        list1.Add(list[i]);
                        list2.Add(list[i+end1]);
                    }

                    if (end1*2 < len)
                    {
                        list2.Add(list[len-1]);
                    }
                    done = false;

                } else 
                {
                    splitList.Add(list);
                }

            }

            if(done) 
            {
                return(splitList);
            } else 
            {
                return (split(splitList)); 
            }

        }

        private List<int> merge(List<List<int>> listsToMerge)
        {
            List<List<int>> mergedLists = new List<List<int>>();

            for(int i=0;i<listsToMerge.Count;i+=2)
            {
                List<int> merged;
                if (i < listsToMerge.Count-1)
                {
                    merged = merge(listsToMerge[i], listsToMerge[i+1]);
                } 
                else
                {
                    merged = listsToMerge[i];

                }
                
                mergedLists.Add(merged);

            }

            if (mergedLists.Count > 1)
            {
                return(merge(mergedLists));
            }
            else
            {
                return(mergedLists[0]);
            }
        }

        private List<int> merge(List<int> list1, List<int> list2)
        {
            List<int> newList = new List<int>();
            int max = list1.Count >= list2.Count ? list1.Count : list2.Count;

            int i1=0, i2 = 0;

            while(i1 < list1.Count || i2 < list2.Count)
            {
                if (i1 < list1.Count)
                {
                    if (i2 < list2.Count)
                    {
                        if (list1[i1] <= list2[i2])
                        {
                            newList.Add(list1[i1]);
                            i1++;
                        }
                        else
                        {
                            newList.Add(list2[i2]);
                            i2++;
                        }
                    }
                    else
                    {
                            newList.Add(list1[i1]);
                            i1++;
                    }
                     
                }
                else 
                {
                    newList.Add(list2[i2]);
                    i2++;
                }
            }

            return(newList);
        }
    }
}