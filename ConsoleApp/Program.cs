using System.Reflection;
using System.Xml;
using ClassLibrary1;

class Programm
{
    static void Main()
    {
        XmlDocument xmlDocument = new XmlDocument();
        XmlElement rootElement = xmlDocument.CreateElement("Diagram");
        xmlDocument.AppendChild(rootElement);

        Assembly assembly = Assembly.Load("ClassLibrary1");
        Type[] types = assembly.GetTypes();

        foreach (Type type in types)
        {
            string temp;
            if (type.IsClass)
            {
                temp = "Class";
            }
            else
            {
                temp = "Enum";
            }

            if (type.Namespace.Contains("ClassLibrary1"))
            {
                XmlElement element = xmlDocument.CreateElement(temp);
                rootElement.AppendChild(element);

                element.SetAttribute("name", type.Name);

                CommentAttribute comment = (CommentAttribute)type.GetCustomAttribute(typeof(CommentAttribute));
                if (comment != null)
                {
                    XmlElement commentElement = xmlDocument.CreateElement("Comment");
                    commentElement.InnerText = comment.Comment;
                    element.AppendChild(commentElement);
                }

                object[] properties = type.GetProperties();
                foreach (var prop in properties)
                {
                    XmlElement propertyElement = xmlDocument.CreateElement("Property");
                    propertyElement.InnerText = prop.ToString();
                    element.AppendChild(propertyElement);
                }

                object[] methods = type.GetMethods(BindingFlags.DeclaredOnly);
                foreach (var method in methods)
                {
                    XmlElement methodElement = xmlDocument.CreateElement("Method");
                    methodElement.InnerText = method.ToString();
                    element.AppendChild(methodElement);
                }
            }

            
        }

        xmlDocument.Save("/Users/user/source/repos/lab7/ConsoleApp/ClassDiagram.xml");
    }
}
