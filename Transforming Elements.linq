<Query Kind="Program" />

/* Get list of file sizes*/

void Main()
{
	var paths = new[]{"c:\\windows\\notepad.exe", "c:\\windows\\regedit.exe", "c:\\windows\\explorer.exe"};
	GetListOfFileSizes(paths).Dump();
	paths.Select(p => new FileInfo(p)).ToDictionary(p => p.Name, p => p.Length).Dump();
}

// Define other methods and classes here
List<long> GetListOfFileSizes(IEnumerable<string> paths)
{	
//	var fileSizes = new List<long>();
//	
//	foreach(var path in paths)
//	{
//		var length = new FileInfo(path).Length;
//		fileSizes.Add(length);
//	}
	
	//return fileSizes;
	
	return paths.Select(p => new FileInfo(p).Length).ToList();
}