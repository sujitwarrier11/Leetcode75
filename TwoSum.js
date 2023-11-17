// https://leetcode.com/problems/two-sum/

const TwoSumWithOutRepeatingElements = (arr=[], sum = 0) => {
    const posMap = {};
    for (let i = 0; i< arr.length; i++) {
        const diff = sum - arr[i];
        if (posMap[diff]) {
            return [posMap[diff], i];
        }
        posMap[arr[i]] = i;
    }
};

const TwoSumWithRepeatingElements = (arr=[], sum = 0) => {
    let i = 0;
    let j = arr.length - 1;
    arr.sort((a,b) => a-b);
    while (i < j) {
        const currSum = arr[i] + arr[j];
        if (currSum === sum) return [arr[i],arr[j]];
        if (currSum > sum) j--;
        else i++;
    }
}


console.log(TwoSumWithRepeatingElements([2,11,7,15], 9));