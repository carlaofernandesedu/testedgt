using System;
using System.Collections;
using System.Reflection;

namespace br.procon.si.UAT.Helpers
{
    //https://www.codeproject.com/Articles/1083779/RESTful-Day-sharp-Unit-Testing-and-Integration-T
    public static class AssertObjectsHelper
    {
        public static string PropertyValuesAreEquals(object actual, object expected)
        {
            string retorno = string.Empty;
            PropertyInfo[] properties = expected.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object expectedValue = property.GetValue(expected, null);
                object actualValue = property.GetValue(actual, null);

                if (actualValue is IList)
                    retorno = AssertListsAreEquals(property, (IList)actualValue, (IList)expectedValue);
                else if (!Equals(expectedValue, actualValue))
                    if (property.DeclaringType != null)
                        retorno = String.Format("Property {0}.{1} does not match. Expected: {2} but was: {3}", property.DeclaringType.Name, property.Name, expectedValue, actualValue);
            }
            return retorno;
        }

        private static string AssertListsAreEquals(PropertyInfo property, IList actualList, IList expectedList)
        {
            string retorno = string.Empty;
            if (actualList.Count != expectedList.Count)
                retorno = String.Format("Property {0}.{1} does not match. Expected IList containing {2} elements but was IList containing {3} elements",
                property.PropertyType.Name,
                property.Name, expectedList.Count, actualList.Count);

            for (int i = 0; i < actualList.Count; i++)
            {
                if (!Equals(actualList[i], expectedList[i]))
                {
                    retorno = String.Format("Property {0}.{1} does not match. Expected IList with element {1} equals to {2} but was IList with element {1} equals to {3}", property.PropertyType.Name, property.Name, expectedList[i], actualList[i]);
                }
            }
            return retorno;
        }
    }
}