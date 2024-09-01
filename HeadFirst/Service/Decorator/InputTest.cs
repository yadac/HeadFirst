using System.Diagnostics;

namespace HeadFirst.Service.Decorator
{
    public class InputTest
    {
        string path = "test.txt";

        public string GetInputFileContents()
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        using (LowerTextReader reader = new LowerTextReader(sr))
                        {
                            string text = reader.ReadToEnd();
                            return text;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class LowerTextReader : TextReader
    {
        private readonly TextReader _reader;
        public LowerTextReader(TextReader sr)
        {
            _reader = sr;
        }
        public override string ReadToEnd()
        {
            return _reader.ReadToEnd().ToLower();
        }
    }

}
