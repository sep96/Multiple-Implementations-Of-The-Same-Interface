namespace Multiple_Implementations_Of_The_Same_Interface.Models
{
    public class MSS : ICrud
    {
        public string Add()
        {
           return "Insert Opeeration on MSS";
        }

        public string Delete()
        {
            return "Delete Opeeration on MSS";
        }

        public string Update()
        {
            return "Update Opeeration on MSS";
        }
    }
}
