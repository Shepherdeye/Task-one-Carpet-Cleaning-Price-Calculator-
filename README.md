<h1>Search Task</h1>

--> Example 

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X}+{Y}={X + Y:C}");

.................... Answers..................

<h3>Why the output of equation=  $30.00 ?</h3>
<p> 
Because we used a Standard Numeric Format type "C" (Currency) and it appeare the sing  of  "$" .
</p>
<br>
<h3>what is its benefit ?</h3>
<p> 
Standard Numeric Format helps us control how the output appears, whether it's a currency, percentage, decimal, or other numeric type.
</p>
<br>
<br>
<h3>the other example</h3>
<p> 
  double studentPoints = 400;
 int totalPoints = 410;
 double percentage = studentPoints / totalPoints;
 Console.WriteLine($"Percentage: ={percentage:P}");
<br>
  <strong>Result</strong>
  Percentage: = 97.56%
</p>
