using barsGroupTaskIEnumerable;

string filePath = @"..\..\..\text.txt";
// string
var generic = new LocalFileLogger<string>(filePath);

generic.LogInfo("Hello!");
Exception ex = new DivideByZeroException();
generic.LogError("Division", ex);
generic.LogWarning("Warning!");

// integer
var generic1 = new LocalFileLogger<int>(filePath);

generic.LogInfo("My integer");
Exception ex1 = new DataMisalignedException();
generic.LogError("Data misaligned", ex1);
generic.LogWarning("Waning!");