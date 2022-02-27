namespace CoreLayer.Utilities.Helpers
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class PagedListHelper<T> : List<T>
  {
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;
    public PagedListHelper(List<T> items, int count, int pageNumber, int pageSize)
    {
      TotalCount = count;
      PageSize = pageSize;
      CurrentPage = pageNumber;
      TotalPages = (int)Math.Ceiling(count / (double)pageSize);

      AddRange(items);
    }

    public static PagedListHelper<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
    {
      var count = source.Count();
      var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

      return new PagedListHelper<T>(items, count, pageNumber, pageSize);
    }
  }
}
