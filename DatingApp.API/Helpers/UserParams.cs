namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1; //default value 1
        private int pageSize = 10; //propfull
        public int PageSize
        {
            get { return pageSize = 10; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
    }
}