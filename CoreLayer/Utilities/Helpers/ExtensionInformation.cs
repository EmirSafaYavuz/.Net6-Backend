namespace Core.Utilities.Helpers
{
  using System;
  using System.Collections.Generic;
  using System.Text;
  public class ExtensionInformation
  {
    public string FolderName { get; set; }
    public string Extension { get; set; }
    public string MimeType { get; set; }
    public double MaximumUploadSizeInByte { get; set; }
  }
}
