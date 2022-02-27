namespace CoreLayer.Entities
{
  public class PaginationParameters
  {
    const int maxPageSize = 10;
    public int PageNumber { get; set; }
    private int _pageSize = 5;
    public int PageSize
    {
      get { return _pageSize; }
      set
      {
        _pageSize = (value > maxPageSize) ? maxPageSize : value;
      }
    }
  }
}
