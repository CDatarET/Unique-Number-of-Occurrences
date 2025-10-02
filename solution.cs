public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++){
            if(d.ContainsKey(arr[i])){
                d[arr[i]] = d[arr[i]] + 1;
            }
            else{
                d[arr[i]] = 1;
            }
        }

        Dictionary<int, int> d2 = new Dictionary<int, int>();
        foreach(int key in d.Keys){
            if(d2.ContainsKey(d[key])){
                return(false);
            }
            else{
                d2[d[key]] = 1;
            }
        }

        return(true);
    }
}
