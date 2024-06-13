namespace ProjectEuler;

class Problem002 : IProblem
{
    public void Solve() {
        int total = 1;
        int prevTotal = 1;
        int aggr = 0;

        while (total < 4000000) {
            if (total % 2 == 0) {
                aggr+=total;
            }
            total+=prevTotal;
            prevTotal = total - prevTotal;
        }
        System.Console.WriteLine(aggr);
    }
}
