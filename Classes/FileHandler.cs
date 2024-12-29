namespace Inlämningsuppgift1._1.Classes
{
    public class FileHandler
    {

        public string _filePath;
        public FileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteToFile(string text)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(text);
            }
        }
       
        //public void WriteToFileEdit(string text)
        //{

        //}
        //public void Delete()
        //{
        //    //Läser upp data från textfil och konverterar till en lista.
        //    var lines = File.ReadAllLines(_filePath).ToList();
        //}
    }
}
