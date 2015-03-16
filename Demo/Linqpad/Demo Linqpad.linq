<Query Kind="Program" />

void Main()
{
	var names = new TestClass().GetNames();	
	
	names.Dump();
}

// Define other methods and classes here
public class TestClass
{	
	public string Name { get; set; }
	
	public List<TestClass> GetNames()
	{
		return new List<TestClass> {
			new TestClass { Name = "Justin James" },
			new TestClass { Name = "Billy Bob" }
		};
	}
	
}
