namespace ProjectEuler;

class Problem001 : IProblem
{
    public void Solve() {
        //define variables
        int total = 1000;
        int multiple1 = 3;
        int multiple2 = 5;
        //to conform to < instead of <=
        total-=1;
        //aggregates of multiples
        int solution = SolvePerMultiple(total, multiple1) + SolvePerMultiple(total,multiple2) - SolvePerMultiple(total, multiple1 * multiple2 );
        System.Console.WriteLine("Final answer: "+solution);
    }

    public int SolvePerMultiple(int total, int multiple) {
        int max = total - total % multiple;
        int aggr =  (int) (Convert.ToDouble(multiple + max) / 2.0 * ( max / multiple ));
        System.Console.WriteLine("Sum for " + multiple + ": " + aggr);
        return aggr;
    }
}
