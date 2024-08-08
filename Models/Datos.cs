using System.Collections.Generic;

namespace TP_Mi_Web_Personal_AGUSTIN_DE_MARCO.Models
{
    public static class Datos
    {
        public static DatosPersonales GetDatosPersonales()
        {
            return new DatosPersonales
            {
                Nombre = "Agustín de Marco",
                Subtitulo = "Desarrollador Full Stack",
                Descripcion = "Soy Agustín De Marco, una estudiante de la escuela ORT de la especialidad de Informática el cual desde siempre se ha interesado por la tecnología y habiendo adentradose al mundo de la programación desde hace 5 años. Mis pilares de conocimiento informático son los lenguajes de programación Javascript y PHP además del amplio conocimiento el lenguajes de etiquetado como Html y Css. Otras de mis pasiones son el mundo del emprendedurismo, las ventas y las inversiones bursátiles.",
                FotoPerfilUrl = "/img/perfil.jpg"
            };
        }

        public static List<Certificado> GetCertificados()
        {
            return new List<Certificado>
            {
                new Certificado { Nombre = "HTML Y CSS", Institucion = "Openbootcamp" },
                new Certificado { Nombre = "Curso de JavaScript Avanzado", Institucion = "Soy Dalto Youtube" },
                new Certificado { Nombre = "Php y MySQL", Institucion = "Bluuweb Youtube" }
            };
        }

        public static List<Idioma> GetIdiomas()
        {
            return new List<Idioma>
            {
                new Idioma { Nombre = "Español", Nivel = "Nativo", Imagen = "/img/spain.svg" },
                new Idioma { Nombre = "Inglés", Nivel = "B2", Imagen = "/img/britain.svg"},
                new Idioma { Nombre = "Hebreo", Nivel = "Básico", Imagen = "/img/israel.svg" }
            };
        }

        public static List<Proyecto> GetProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto { Nombre = "Proyecto 1", Descripcion = "Un vistazo al último proyecto en el que elaboré junto a mi compañero una página web de turismo en Bulgaria.", ImagenUrl = "/img/proyecto1.png", Url = "https://turismoenbulgaria.netlify.app/" },
                new Proyecto { Nombre = "Proyecto 2", Descripcion = "Este es un sitio web one page que elaboré para una empresa que comercializa el sistema SAP", ImagenUrl = "/img/proyecto2.webp", Url = "https://solinntec.netlify.app/" },
                new Proyecto { Nombre = "Proyecto 3", Descripcion = "Y cómo proyecto más completo elaboré este sitio de ecommerce para una librería mayorista con la cual trabajo.", ImagenUrl = "/img/proyecto3.png", Url = "https://mayoristalaestrella.com" }
            };
        }
    }

    public class DatosPersonales
    {
        public string Nombre { get; set; }
        public string Subtitulo { get; set; }
        public string Descripcion { get; set; }
        public string FotoPerfilUrl { get; set; }
    }

    public class Certificado
    {
        public string Nombre { get; set; }
        public string Institucion { get; set; }
    }

    public class Idioma
    {
        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public string Imagen { get; set; }
    }

    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string Url { get; set; }
    }
}