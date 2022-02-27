namespace Core.Utilities.Helpers
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  public class FileCategory
  {
    public string FolderName { get; set; }
    public Dictionary<string, string> ExtensionMimeType { get; set; }
    public double MaximumUploadSizeInByte { get; set; }
  }
}
