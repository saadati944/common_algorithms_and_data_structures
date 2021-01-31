/*
* match parentheses and check the correctness of matching nested prentheses.
* except '(' and ')', all characters will be ignored.
*
* input is the input !!! :)
* so change it with your own test case
*/

// input string
    // true matching example :
let input = "((((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))))";
    // wrong matching example :
//let input = "((((()())(())()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))((()())(())(()())(()))((()())(())))(((()())(())(()())(()))((()())(()))))";

// stack data structure
// which has only two operations,
// pop and push
// push will add a new element to elements list
// and pop will return last added element
// if there is no elements avaliable, the pop will return -1
class Stack{
    constructor(){
        this.elements = [];
    }
    push(element){
        this.elements.push(element);
    }
    pop(){
        if(this.elements.length>0)
            return this.elements.pop();
        return -1;
    }
}

let stack = new Stack()

let wrong = false;

for(let i = 0;i<input.length; i++)
{
    //if the input[i] is a open bracket, add it to stack
    if(input[i] == "(")
        {
            stack.push(input[i]);
        }
    
    //  if there isn't any open brackets to match
    //  this close bracket then input is wrong !!
    else if (input[i]== ')')
        if(stack.pop() != '(')
            {
                wrong = true;
                break;
            }
}

if(stack.elements.length > 0)
    wrong = true;

if(wrong)
    console.log("wrong matching !!!");
else
    console.log("true matching");