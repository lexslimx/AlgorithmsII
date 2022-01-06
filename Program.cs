// See https://aka.ms/new-console-template for more information
using AlgorithmsII;

MergeSort mergeSort = new MergeSort();
var ans = mergeSort.Sort(new int[] { 1,0,1,0,2,1,2,3,2});
for(var i = 0; i < ans.Length; i ++){
    Console.Write(ans[i]);
}