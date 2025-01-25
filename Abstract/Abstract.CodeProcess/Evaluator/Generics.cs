using Abstract.Parser.Core.ProgData.DataReference;
using Abstract.Parser.Core.ProgMembers;

namespace Abstract.Parser;

public partial class Evaluator
{

    public Function GenerateStaticAnnonymous(Function baseFunc, DataRef[] _args)
    {
        var parent = baseFunc.parent!;

        var annon = new Function(parent, ("__annon_" + baseFunc.identifier
        + $"_{parent.AnnonCount++:X4}"), null!);
        parent.AppendChild(annon);

        annon.parameters = []; // FIXME baseFunc.parameters;
        annon.returnType = GetFunctionReturnType(baseFunc, _args);

        Console.WriteLine($"{annon} built");
        return annon;
    }

}
