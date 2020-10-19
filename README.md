# Comparing object mappers
* Manual mapping
* Mapster
* Automapper

## Benchmark
|            Method |     Mean |    Error |   StdDev | Ratio | RatioSD |     Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|------------------ |---------:|---------:|---------:|------:|--------:|----------:|---------:|---------:|----------:|
|     ManualMapping | 18.79 ms | 0.467 ms | 1.005 ms |  1.00 |    0.00 | 1156.2500 | 437.5000 |  93.7500 |   6.33 MB |
| AutoMapperMapping | 26.38 ms | 0.792 ms | 1.706 ms |  1.41 |    0.10 | 1281.2500 | 562.5000 | 156.2500 |   6.81 MB |
|    MapsterMapping | 15.28 ms | 0.190 ms | 0.421 ms |  0.81 |    0.05 | 1062.5000 | 453.1250 | 109.3750 |   5.72 MB |