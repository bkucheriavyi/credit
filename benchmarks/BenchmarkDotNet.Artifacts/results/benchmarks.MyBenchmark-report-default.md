
BenchmarkDotNet=v0.11.2, OS=macOS Mojave 10.14.1 (18B75) [Darwin 18.2.0]
Intel Core i5-5257U CPU 2.70GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.302
  [Host]    : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  MediumRun : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  ShortRun  : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


 Method |       Job | IterationCount | LaunchCount | WarmupCount | amount | fee | minimum |     Mean |      Error |    StdDev |
------- |---------- |--------------- |------------ |------------ |------- |---- |-------- |---------:|-----------:|----------:|
  Bench | MediumRun |             15 |           2 |          10 |   5500 |  10 |       4 | 15.02 us |  0.2405 us | 0.3449 us |
  Bench |  ShortRun |              3 |           1 |           3 |   5500 |  10 |       4 | 15.78 us | 12.1700 us | 0.6671 us |
