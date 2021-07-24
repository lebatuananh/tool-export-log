using System.Collections.Generic;

namespace Tool.ExportLog.Shared
{
    public interface IExportService
    {
        int GetAllLines(string path, string searchPattern, bool includingSubdirectories = false);
        string ReadLines(string output);
    }
}
