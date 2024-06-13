namespace ProjectEuler;

class Program
{
    static void Main(string[] args)
    {
        IProblem problem = new Problem002();
        problem.Solve();
    }
}
