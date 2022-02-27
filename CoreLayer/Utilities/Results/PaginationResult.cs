namespace CoreLayer.Utilities.Results
{
  public class PaginationResult<T> : SuccessDataResult<T>
  {
    public int TotalCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public bool HasNext { get; set; }
    public bool HasPrevious { get; set; }

    public PaginationResult(T data, int totalCount, int pageSize, int currentPage, bool hasNext, bool hasPrevious) : base(data)
    {
      TotalCount = totalCount;
      PageSize = pageSize;
      CurrentPage = currentPage;
      HasNext = hasNext;
      HasPrevious = hasPrevious;
    }
  }
}
