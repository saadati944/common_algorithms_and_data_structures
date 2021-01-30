/*
* find longest palindromic substring in the input
* replace "input" with your own and run program :
* 
*   $ node longest_palindromic.js
* 
* sample out put :
* 
*   asdfghjkl;'';lkjhgfdsa
*/

// the input string
let input = "12345678900987654321a;sief ;aisejf lemfliahslvufhaeihf3489tvasdfghjkl;'';lkjhgfdsao384y2o8v0483 2570v8ve4rhvfe1234567890987654321";

longest = "";

function longestPalindrome(inp) {
    let i=0, j=0;
    for (i; i < inp.length - 1; i++) {
        let t = j = i;
        let pal='';
        
        while (i >= 0 && j < inp.length && inp[i] == inp[j]) {
            i--;
            j++;
        }

        if(j-i > 2)
            pal = inp.substring(i+1, j);
            if(pal.length>longest.length)
                longest=pal;

        i = t;
        j = i+1;
        while (i >= 0 && j < inp.length && inp[i] == inp[j]) {
            i--;
            j++;
        }
        
        if(j-i > 2)
            pal = inp.substring(i+1, j);
            if(pal.length>longest.length)
                longest=pal;
        
        i = t;
    }
}

longestPalindrome(input);
console.log(longest);
