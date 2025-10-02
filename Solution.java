class Solution {
    public boolean uniqueOccurrences(int[] arr) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = 0; i < arr.length; i++){
            map.put(arr[i], map.getOrDefault(arr[i], 0) + 1);
        }

        HashMap<Integer, Integer> map2 = new HashMap<Integer, Integer>();
        for(int key : map.keySet()){
            if(map2.containsKey(map.get(key))){
                return(false);
            }
            else{
                map2.put(map.get(key), 1);
            }
        }

        return(true);
    }
}
