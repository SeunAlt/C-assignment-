using system;
using system.collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace NewAssignment
{
class Program
{
static void Main(string[]args)
{
int I=4;
double d=4.0;
string s="polyilaro";
//declaring extra variables 
int i2;
double d2;
string s2;
console.Writeline("Enter value:");
i2=convert.ToInt32(console.Readline());

console.Writeline("Enter double Value:");
d2=convert.ToDouble(console.Readline());

console.Writeline("Enter string:");
s2 = Convert.ToString(Console.Readline());
console.Writeline(i+i2);
console.Writeline(d+d2);
console.Writeline(s+s2);
}
}
}