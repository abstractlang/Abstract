namespace Abstract.Parser.Core.ProgMembers;

public class Namespace(ProgramMember? parent, MemberIdentifier identifier)
: ProgramMember(parent, identifier)
{
    public override string ToString() => $"{GlobalReference}";
}
