namespace Multiple_Implementations_Of_The_Same_Interface.Models
{
    public class Oracel : ICrud
    {
        public string Add()
        {
            return "Insert Opeeration on Oracel";
        }

        public string Delete()
        {
            return "Delete Opeeration on Oracel";
        }

        public string Update()
        {
            return "Update Opeeration on Oracel";
        }
    }
}
