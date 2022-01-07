// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using InterestingCases.Cases;

var summary = BenchmarkRunner.Run(typeof(ArrayAccessOrder).Assembly);


