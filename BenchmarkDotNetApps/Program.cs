using BenchmarkDotNet.Running;
using BenchmarkDotNetApps;

BenchmarkRunner.Run<CalcOperations>();
// or the line bellow, to run all found benchmark in the running Program.
// BenchmarkRunner.Run(typeof(Program).Assembly);