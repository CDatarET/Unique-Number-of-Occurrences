class Solution:
    def uniqueOccurrences(self, arr):
        c1 = Counter(arr)
        c2 = Counter(c1.values())
        for x in c2:
            if(c2[x] > 1):
                return(False)

        return(True)
