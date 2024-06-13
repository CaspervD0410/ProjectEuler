using System.Globalization;
using System.IO.Pipes;

namespace ProjectEuler;

class Problem003 : IProblem
{
    public void Solve() {
    long number = 600851475143;
    long possiblePrime = 2;

        while (number > 1) {
            if (number % possiblePrime == 0) {
                System.Console.WriteLine("New prime factor just dropped: "+possiblePrime);
                number /= possiblePrime;
            }
            else {
                possiblePrime++;
            }
        }
    }
}
