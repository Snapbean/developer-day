const string name = "Susan";
const string hello = $"Hello {name}";

const string reason = "foo";

[Obsolete($"Obsolete because of {reason}")]
void Test()
{

}