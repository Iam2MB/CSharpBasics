// Type: lesson_7.Program 
// Assembly: lesson_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A02626CD-4D33-42A4-B217-C71A5E031FAA
// Location: D:\Studies\repos\CSharpBasics\lesson_7\bin\Debug\lesson_7.exe
// Sequence point data from D:\Studies\repos\CSharpBasics\lesson_7\bin\Debug\lesson_7.pdb

.class private auto ansi beforefieldinit
  lesson_7.Program
    extends [mscorlib]System.Object
{

  .method private hidebysig static void
    Main(
      string[] args
    ) cil managed
  {
    .entrypoint
    .maxstack 2
    .locals init (
      [0] string password,
      [1] string input,
      [2] bool V_2
    )

    // [8 9 - 8 10]
    IL_0000: nop

    // [9 13 - 9 42]
    IL_0001: ldstr        "password"
    IL_0006: stloc.0      // password

    // [10 13 - 10 50]
    IL_0007: ldstr        "Enter password:"
    IL_000c: call         void [mscorlib]System.Console::WriteLine(string)
    IL_0011: nop

    // [11 13 - 11 47]
    IL_0012: call         string [mscorlib]System.Console::ReadLine()
    IL_0017: stloc.1      // input

    IL_0018: br.s         IL_0038
    // start of loop, entry point: IL_0038

      // [14 13 - 14 14]
      IL_001a: nop

      // [15 17 - 15 58]
      IL_001b: ldstr        "Invalid password!\n"
      IL_0020: call         void [mscorlib]System.Console::WriteLine(string)
      IL_0025: nop

      // [16 17 - 16 60]
      IL_0026: ldstr        "Enter password again:"
      IL_002b: call         void [mscorlib]System.Console::WriteLine(string)
      IL_0030: nop

      // [17 17 - 17 44]
      IL_0031: call         string [mscorlib]System.Console::ReadLine()
      IL_0036: stloc.1      // input

      // [18 13 - 18 14]
      IL_0037: nop

      // [13 13 - 13 47]
      IL_0038: ldloc.1      // input
      IL_0039: ldloc.0      // password
      IL_003a: call         bool [mscorlib]System.String::op_Equality(string, string)
      IL_003f: ldc.i4.0
      IL_0040: ceq
      IL_0042: stloc.2      // V_2

      IL_0043: ldloc.2      // V_2
      IL_0044: brfalse.s     IL_001a
    // end of loop

    // [20 13 - 20 43]
    IL_0046: ldstr        "Welcome!"
    IL_004b: call         void [mscorlib]System.Console::WriteLine(string)
    IL_0050: nop

    // [21 13 - 21 35]
    IL_0051: ldc.i4.1
    IL_0052: call         valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_0057: pop

    // [22 9 - 22 10]
    IL_0058: ret

  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [mscorlib]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Program::.ctor
} // end of class lesson_7.Program
