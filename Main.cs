namespace ProjectEuler;

class Program
{
    static void Main(string[] args)
    {
        IProblem problem = new Problem003();
        problem.Solve();
    }
}
