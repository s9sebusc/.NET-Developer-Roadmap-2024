// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Test_Project_BenchmarkDotNet;

Summary? summary = BenchmarkRunner.Run<DummyClass>(new DummyCustomConfig());


