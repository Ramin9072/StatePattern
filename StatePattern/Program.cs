using StatePattern.Class;
using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        var acceptedState  =new AcceptedState();
        var request = new LoanRequest();
        request.State = acceptedState; 
        request.Accept();

        Console.WriteLine(request.State);
    }
}