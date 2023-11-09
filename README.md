# Codility-Nesting
A string S consisting of N characters is called properly nested if:</br>
S is empty;</br>
S has the form "(U)" where U is a properly nested string;</br>
S has the form "VW" where V and W are properly nested strings.</br>
For example, string "(()(())())" is properly nested but string "())" isn't.

Write a function:</br>
class Solution { public int solution(String S); }</br>
that, given a string S consisting of N characters,</br>
returns 1 if string S is properly nested and 0 otherwise.

For example, given S = "(()(())())", the function should return 1 and given S = "())",</br> 
the function should return 0, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..1,000,000];</br>
string S is made only of the characters '(' and/or ')
