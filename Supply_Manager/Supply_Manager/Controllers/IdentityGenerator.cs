using System;
using System.IO;

namespace Supply_Manager.Controllers
{
    public class IdentityGenerator
    {
        public IdentityGenerator()
        {
        }

        int identity;
        readonly string path = "../JsonResources/identityfile.txt";
        string fileContent;
        int count;
        int counter;
        string[] container;
        readonly string delimeter = "@";

        Random randomNumber = new Random();
         
        private void GenerateIdentity()
        {
            identity = randomNumber.Next(10000000, 100000000);
        }

        public int GetTheIdentity()
        {
            return identity;
        }

        // reading the file
        private void ReadingFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    fileContent = sr.ReadToEnd();
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        // writing new value to the file
        private void WritingToTheFile()
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    string newfileContent = String.Concat(fileContent, identity, delimeter);
                    sr.Write(newfileContent);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        public void GetIdentity()
        {  
            if (count < 1) ReadingFile();
            if(count < 1) container = fileContent.Split('@');
            count++;
            GenerateIdentity();
            foreach (string param in container)
            {
                counter++;
                if (param == (string)identity.ToString())
                {
                    counter = 0;
                    GenerateIdentity();
                    GetIdentity();
                    break;
                }

                if (counter == container.Length)
                {
                    WritingToTheFile();
                    counter = 0;
                }
            }
        }
    }
}
