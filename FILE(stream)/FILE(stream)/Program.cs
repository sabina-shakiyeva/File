class Program
{
    static void Main(string[] args)
    {
        //Folder yarat

        //Directory.CreateDirectory("C:\\Users\\sabina\\Desktop\\fileDemo");

        //oldugun directory-ni gor
        //Console.WriteLine(Directory.GetCurrentDirectory());

        //Directory.Delete("C:\\Users\\sabina\\Desktop\\fileDemo");

        //file yarat
        //using StreamWriter sw = new StreamWriter("demoss.txt");

        //File sil
        //File.Delete("demoss.txt");

        //File-i bir folderdan basqasina kocur
        //Directory.CreateDirectory("C:\\Users\\sabina\\Desktop\\mainFolder");//source path
        //Directory.CreateDirectory("C:\\Users\\sabina\\Desktop\\destinationFolder");//destination

        //string fileName = "demoss.txt";
        //string mainFile = Path.Combine("C:\\Users\\sabina\\Desktop\\mainFolder", fileName);
        //using(StreamWriter sw=new StreamWriter(mainFile))
        //{
        //    sw.WriteLine("It is a sample");
        //}

        //string destinationFile = Path.Combine("C:\\Users\\sabina\\Desktop\\destinationFolder", fileName);
        //File.Move(mainFile, destinationFile);



        //ad-a gore axtaris
        //Console.Write("Axtarmaq istediyiniz faylin adini yazin:");
        //string fileNamee=Console.ReadLine();
        //string[] Filess = Directory.GetFiles("C:\\Users\\sabina\\Desktop\\destinationFolder", fileNamee);
        //foreach(var file in Filess)
        //{
        //    Console.WriteLine($"Tapilan file:{file}");
        //}

        //butun hamisinin siyahisi
        string[] allFiless = Directory.GetFiles("C:\\Users\\sabina\\Desktop\\destinationFolder");
        Console.WriteLine("Butun file-lar:");
        foreach (var file in allFiless)
        {
            Console.WriteLine(file);

        }



    }
}