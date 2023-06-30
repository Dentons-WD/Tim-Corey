using CalculationsLibrary;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CalculatorLibrary.Tests
{
    public class TextDataAccess_Tests
    {
        [Fact]
        public void SaveText_Normal()
        {
            List<string> lines = new List<string>
            {
                "Test one",
                "Test 2",
                "Test III"
            };

            string filePath = @"C:\Temp\Test.txt";
            string fileName = "Test.txt";

            var mock = new Mock<IWriteToText>();

            mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

            TextDataAccess dataAccess = new TextDataAccess();

            dataAccess.SaveText(filePath, lines, mock.Object);

            mock.Verify();
        }

        [Fact]
        public void SaveText_InvalidPath_ShouldThrowException()
        {
            List<string> lines = new List<string>
            {
                "Test one",
                "Test 2",
                "Test III"
            };

            string filePath = @"C:\Temp\Test.txtasflksfsalkfjaslkfjsalkfjasklfjasfkljasflkjasfkljasfkljasfaslkfjaslkfjasfadjaspodjasopdjaspodjaspodjasodpjasdopasjdpjasdsojdaspodjosdjpsaodjaodjaspodjaodjaspodjaspodjaspodjsapodjsapojfagnhinginapgojeagejspgjesogajlgnealkgnaeflkjasfkljasfkljasfaslkfjaslkfjasfadjaspodjasopdjaspodjaspodjasodpjasdopasjdpjasdsojdaspodjosdjpsaodjaodjaspodjaodjaspodjaspodjaspodjsapodjsapojfagnhinginapgojeagejsflkjasfkljasfkljasfaslkfjaslkfjasfadjaspodjasopdjaspodjaspodjasodpjasdopasjdpjasdsojdaspodjosdjpsaodjaodjaspodjaodjaspodjaspodjaspodjsapodjsapojfagnhinginapgojeagejspgjesogajlgnealkgnaekgajegkeajgaoejgogjeapogjmseklmnsklneapfjwapofjwaofawpofawfas.fds,vas;jpgjesogajlgnealkgnaekgajegkeajgaoejgogjeapogjmseklmnsklneapfjwapofjwaofawpofawfas.fds,vas;jkgajegkeajgaoejgogjeapogjmseklmnsklneapfjwapofjwaofawpofawfas.fds,vas;jflkjasfkljasfkljasfaslkfjaslkfjasfadjaspodjasopdjaspodjaspodjasodpjasdopasjdpjasdsojdaspodjosdjpsaodjaodjaspodjaodjaspodjaspodjaspodjsapodjsapojfagnhinginapgojeagejspgjesogajlgnealkgnaekgajegkeajgaoejgogjeapogjmseklmnsklneapfjwapofjwaofawpofawfas.fds,vas;j";
            string fileName = "Test.txt";

            var mock = new Mock<IWriteToText>();

            mock.Setup(x => x.WriteToFile(fileName, It.IsAny<List<string>>())).Verifiable();

            TextDataAccess dataAccess = new TextDataAccess();

            Assert.Throws<PathTooLongException>(
                () => dataAccess.SaveText(filePath, lines, mock.Object));
        }
    }
}
