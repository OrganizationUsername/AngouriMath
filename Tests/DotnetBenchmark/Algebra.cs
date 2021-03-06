﻿using AngouriMath;
using BenchmarkDotNet.Attributes;

namespace DotnetBenchmark
{
    public class AlgebraTest
    {
        private VariableEntity x = MathS.Var("x");
        private Entity exprEasy;
        private Entity exprMedium;
        private Entity exprHard;
        private Entity exprSolvable;

        [GlobalSetup]
        public void Setup()
        {
            exprEasy = x + MathS.Sqr(x) - 3;
            exprMedium = MathS.Sin(x + MathS.Cos(x)) + MathS.Sqrt(x + MathS.Sqr(x));
            exprHard = MathS.Sin(x + MathS.Arcsin(x)) / (MathS.Sqr(x) + MathS.Cos(x)) * MathS.Arccos(x / 1200 + 0.00032 / MathS.Cotan(x + 43));
            exprSolvable = MathS.FromString("3arccos(2x + a)3 + 6arccos(2x + a)2 - a3 + 3");
        }
        [Benchmark]
        public void SolveEasy() => exprEasy.SolveNt(x);
        [Benchmark]
        public void SolveMedium() => exprMedium.SolveNt(x);
        [Benchmark]
        public void SolveHard() => exprHard.SolveNt(x);
        [Benchmark]
        public void SolveAnal() => exprSolvable.SolveEquation(x);

    }
}
