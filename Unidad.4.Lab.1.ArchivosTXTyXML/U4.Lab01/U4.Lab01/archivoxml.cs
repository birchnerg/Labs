using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace U4.Lab01
{
    class archivoxml
    {
        static void xMain(string[] args)
        {
            EscribirXML();
            leerXML();
            Console.ReadKey();
        }
        public static void EscribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement(); //cerramos el tag de nombre
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement(); //cerramos el tag de apellido
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement(); //cerramos el tag de email
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement(); //cerramos el tag de telefono
                    escritorXML.WriteEndElement();//cerramos el tag de contactos
                }
            }
            while (linea != null);
            escritorXML.WriteEndElement();//cerramos el tag de DocumentElement
            escritorXML.WriteEndDocument();
            escritorXML.Close();
        }
        public static void leerXML()
        {
            XmlTextReader lectorXML = new XmlTextReader("agendaxml.xml");
            string tagAnterior = "";
            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;
                }
                else if (lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
                }
            }
            lectorXML.Close();
        }
    }
}
