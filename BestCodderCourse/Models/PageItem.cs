namespace BestCodderCourse.Models
{
    public class PageItem
    {

        public string Text { get; set; }
        public int PageIndex { get; set; }
        public bool Enabled { get; set; }
        public bool IsActive { get; set; }



        public PageItem(string text, int pageIndex, bool enabled, bool isActive)
        {



            this.Text = text;
            this.PageIndex = pageIndex;
            this.Enabled = enabled;
            this.IsActive = isActive;
        }
    }
}
