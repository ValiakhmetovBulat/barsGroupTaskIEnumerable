using barsGroupTaskIEnumerable;

string filePath = @"..\..\..\text.txt";
var generic = new LocalFileLogger<string>(filePath);

generic.LogInfo("Hello!");
Exception ex = new DivideByZeroException();
generic.LogError("Division", ex);
generic.LogWarning("Warning!");