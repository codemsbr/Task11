namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yol 1 
            //while (true)
            //{
            //    Console.Write("Enter Fulname : ");
            //    string fullName = Console.ReadLine();

            //    Console.Write("Enter GroupNo : ");
            //    string groupNo = Console.ReadLine();

            //    Console.Write("Enter Age : ");
            //    byte age = Convert.ToByte(Console.ReadLine());

            //    if(fullName.FullnameController() && groupNo.GroupNoController())
            //    {
            //        Student student = new Student(fullName, groupNo, age);
            //    }
            //}
            #endregion

            string fullName = string.Empty;
            string groupNo = string.Empty;
            do
            {
                Console.Write("Enter Fulname : ");
                fullName = Console.ReadLine();
            } while (!fullName.FullnameController());


            do
            {
                Console.Write("Enter GroupNo : ");
                groupNo = Console.ReadLine();
            } while (!groupNo.GroupNoController());

            Console.Write("Enter Age : ");
            byte age = Convert.ToByte(Console.ReadLine());
            Student student = new Student(fullName, groupNo, age);
        }
    }
}