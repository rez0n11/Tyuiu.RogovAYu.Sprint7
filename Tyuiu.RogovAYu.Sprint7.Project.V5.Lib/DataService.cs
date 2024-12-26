namespace Tyuiu.RogovAYu.Sprint7.Project.V5.Lib
{
    public class DataService
    {
     
         public string[,] Load(string path)
        {
            using StreamReader reader = new StreamReader(path);
            string[] lines = reader.ReadToEnd().Split('\n');

            

            int rc = lines.Length, cc = lines[0].Split(',',';').Length;

            string[,] matrix = new string[rc,cc];
            for (int i = 0;i<rc;i++)
            {
                for (int j = 0;j<cc;j++)
                {
                    matrix[i,j] = lines[i].Split(',', ';')[j].Trim();
                }
            }
            return matrix;
        }
    }
}
