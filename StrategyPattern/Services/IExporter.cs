namespace StrategyPattern.Services;
public interface IFileExporter
{
	string Export(string data);
	public string GetFileType { get; set; }
}


public class CsvExporter : IFileExporter
{
	public string GetFileType { get; set; } = "csv";
	public string Export(string data)
	{
		return ($"Exporting to {GetFileType} file");
	}
}

public class XmlExporter : IFileExporter
{
	public string GetFileType { get; set; } = "xml";
	public string Export(string data)
	{
		return ($"Exporting to {GetFileType} file");
	}
}


public class JsonExporter : IFileExporter
{
	public string GetFileType { get; set; } = "json";
	public string Export(string data)
	{
		return ($"Exporting to {GetFileType} file");
	}
}


public interface IExportServiceProvider
{
	Dictionary<string, IFileExporter> Exporters { get; set; }
	string exportData(string fileType, string data);
}


public class ExportServiceProvider : IExportServiceProvider
{
	public Dictionary<string, IFileExporter> Exporters { get; set; } = new Dictionary<string, IFileExporter>
	{
		{"csv", new CsvExporter()},
		{"xml", new XmlExporter()},
		{"json", new JsonExporter()}
	};

	public string exportData(string fileType, string data)
	{
		return Exporters[fileType].Export(data);
	}
}
