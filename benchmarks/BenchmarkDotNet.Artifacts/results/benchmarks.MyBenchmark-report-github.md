``` ini

BenchmarkDotNet=v0.11.2, OS=macOS Mojave 10.14.1 (18B75) [Darwin 18.2.0]
Intel Core i5-5257U CPU 2.70GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
| Method | amount | fee | minimum |     Mean |     Error |    StdDev |
|------- |------- |---- |-------- |---------:|----------:|----------:|
|  Bench |   5500 |  10 |       4 | 15.21 us | 0.2814 us | 0.3240 us |
