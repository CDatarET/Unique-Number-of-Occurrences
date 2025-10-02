class Solution:
    def uniqueOccurrences(self, arr):
        c = Counter(arr)
        return len(c.values()) == len(set(c.values()))
