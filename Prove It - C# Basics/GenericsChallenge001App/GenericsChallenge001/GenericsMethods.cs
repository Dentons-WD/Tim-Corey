using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsChallenge001
{
    public static class GenericsMethods
    {
        public static List<T> InterMixLists<T>(List<T> listOne, List<T> listTwo)
        {
            List<T> output = new List<T>();

            if (listOne.Count >= listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    output.Add(listOne[i]);

                    if (listTwo.Count > i)
                    {
                        output.Add(listTwo[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    output.Add(listTwo[i]);

                    if (listOne.Count > i)
                    {
                        output.Add(listOne[i]);
                    }
                }
            }

            return output;
        }

        public static object ReturnObjectWithLongestTitle<T, U>(T objectOne, U objectTwo)
        {
            var propertiesOne = objectOne.GetType().GetProperties();
            var propertiesTwo = objectTwo.GetType().GetProperties();

            bool containsTitlePropertyOne = false;

            foreach (var property in propertiesOne)
            {
                if (property.Name == "Title")
                {
                    containsTitlePropertyOne = true;
                }
            }

            bool containsTitlePropertyTwo = false;

            foreach (var property in propertiesTwo)
            {
                if (property.Name == "Title")
                {
                    containsTitlePropertyTwo = true;
                }
            }

            if (containsTitlePropertyOne == false || containsTitlePropertyTwo == false)
            {
                throw new NotSupportedException("Both objects must have a property called 'Title'.");
            }

            string titleOne= objectOne.GetType().GetProperty("Title").GetValue(objectOne, null).ToString();
            string titleTwo= objectTwo.GetType().GetProperty("Title").GetValue(objectTwo, null).ToString();

            if (titleOne.Length >= titleTwo.Length)
            {
                return objectOne;
            }
            else
            {
                return objectTwo;
            }
        }
    }
}
