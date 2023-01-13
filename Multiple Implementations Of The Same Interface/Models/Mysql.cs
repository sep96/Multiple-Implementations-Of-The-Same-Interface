namespace Multiple_Implementations_Of_The_Same_Interface.Models
{
    public class Mysql : ICrud
    {
        public string Add()
        {
            return "Insert Opeeration on Mysql";
        }

        public string Delete()
        {
            return "Delete Opeeration on Mysql";
        }

        public string Update()
        {
            return "Update Opeeration on Mysql";
        }
    }
}
