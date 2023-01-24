namespace OlaTvUI.PagedList
{
    public class Pager
    {
        public int FirstPage { get; set; } //baslangıcSayfası
        public int EndPage { get; set; } //bitissayfası
        public int TotalPage { get; set; } //sayfasayısı
        public int DataPerPage { get; set; }  //goruntulenenkayıtsayısı
        public int TotalData { get; set; } // toplamkayıtsayısı
        public int ActivePage { get; set; } //aktifsayfa


        public Pager(int page, int pageSize, int itemCounts)
        {
            ActivePage = page;
            DataPerPage = pageSize;
            TotalData = itemCounts;

            TotalPage = (int)Math.Ceiling((decimal)TotalData / (decimal)DataPerPage);

            FirstPage = ActivePage - 5;
            EndPage = ActivePage + 4;

            if (FirstPage<1)
            {
                EndPage = EndPage - (FirstPage - 1);
                FirstPage = 1;
            }

            if (EndPage > TotalPage)
            {
                EndPage = TotalPage;
                if (EndPage>10)
                {
                    FirstPage = EndPage - 9;
                }
            }
        }
    }
}
