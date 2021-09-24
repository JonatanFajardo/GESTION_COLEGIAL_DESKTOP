using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms
{
    class DateExamples
    {
        public static void llenarFormulario(Control vaciar)
        {

            int maxlenght = 0;
            Random randomNumbers = new Random();
            int ramNum;

            //foreach (Control item in vaciar.Controls)
            //{
            //    if (item is JNTexBox)
            //    {
            //        JNTexBox JNTexBox = new JNTexBox();
            //        if (((JNTexBox)item).Validar == JNTexBox.Estados.Letters)
            //        {
            //            ((JNTexBox)item).Text = GetNames();
            //        }
            //        if (((JNTexBox)item).Validar == JNTexBox.Estados.Numbers)
            //        {
            //            maxlenght = ((JNTexBox)item).MaxLength;
            //            int getnumber = GetNumber(maxlenght);
            //            ramNum = randomNumbers.Next(0, getnumber);

            //            ((JNTexBox)item).Text = ramNum.ToString();
            //        }
            //    }
            //}
        }
        public static string GetNames()
        {
            Random randomLetters = new Random();
            int numOfRamdom = 0;
            List<string> texto = new List<string>()
            {
                 "Abigail","Abril","Agustina","Alaia","Alana","Alba","Alejandra","Alicia","Alma","Altagracia","Amala","Amalia","Amanda","Ana","Ana","Ana","Ana","Ana","Ana","Andrea","Ángeles","Antonella","Antonia","Ariana","Ashley","Bárbara","Beatriz","Belén","Briana","Brithany","Camila","Caridad","Carmen","Carmen","Carolina","Catalina","Celeste","Claudia","Concepción","Daniela","Danna","Dayana","Del","Delfina","Domenica","Dulce","Elizabeth","Emilia","Emily","Emma","Esmeralda","Evelyn","Florencia","Francesca","Gabriela","Génesis","Guadalupe","Isabella","Isidora","Jimena","Josefa","Josefina","Juana","Julia","Julieta","Kamila","Karla","Karla","Kiara","Kimberly","Laura","Leticia","Lidia","Lisandra","Liz","Luana","Lucía","Luciana","Luisa","Luisa","Luz","Luz","Mabel","Maite","Margarita","Ángeles","Carmen","Celeste","del","Dolores","Elena","Fernanda","Isabel","Jesús","José","Luisa","Paula","Teresa","Mariana","Mariangel","Mariapaz","Maritza","Martha","Martina","Mayelin","Melany","Mercedes","Mia","Mikaela","Morena","Noemí","Odalys","Olga","Olivia","Patricia","Paula","Ramona","Raquel","Reina","Rosa","Rosmery","Roxana","Salomé","Samantha","Sara","Sara","Silvia","Sofía","Sonia","Sophia","Tania","Teresa","Trinidad","Valentina","Valeria","Vanessa","Verónica","Victoria","Ximena","Yadira","Yaima","Yamileth","Yanelis","Yanet","Zoe","Adrián","Agustín","Alberto","Alejandro","Alexander","Alexis","Alonso","Andrés","Ángel","Anthony","Antonio","Bautista","Benicio","Benjamín","Carlos","Carlos","Carlos","Carlos","César","Cristóbal","Daniel","David","Diego","Dylan","Eduardo","Emiliano","Emmanuel","Enrique","Erik","Ernesto","Ethan","Fabián","Facundo","Felipe","Félix","Félix","Fernando","Francisco","Francisco","Gabriel","Gaspar","Gustavo","Hugo","Ian","Iker","Isaac","Jacob","Javier","Jayden","Jeremy","Jerónimo","Jesús","Jesús","Jesús","Joaquín","Jorge","Jorge","Jorge","José","José","José","José","José","José","José","José","José","Josué","Juan","Juan","Juan","Juan","Juan","Juan","Juan","Juan","Juan","Juan","Julio","Julio","Justin","Kevin","Lautaro","Liam","Lian","Lorenzo","Lucas","Luis","Luis","Luis","Luis","Manuel","Manuel","Marco","Mario","Martín","Mateo","Matías","Maximiliano","Maykel","Miguel","Miguel","Nelson","Noah","Oscar","Pablo","Pedro","Rafael","Ramón","Raúl","Ricardo","Rigoberto","Roberto","Rolando","Samuel","Samuel","Santiago","Santino","Santos","Sebastián","Thiago","Thiago","Tomás","Valentino","Vicente","Víctor","Víctor","Mico","Chispa","Rayo","Chiqui","Plutón","Chico","Luna","Lola","Coco","Linda","Noa","Nina","Toby","Rocky","Thor","Simba","Bruno","Nico","Bimba","Max","Luna","Kira","Thor","Lola","Nala","Rex","Rocky","Zeus","Simba","Coco","Zar","Bruno","Sultán","Sol","Gordo","Grande","Lobo","Oso","Zorro","arándano","banana","breva","cereza","chirimoya","ciruela","coco","frambuesa","fresa","granada","higo","kiwi","lima","limón","mandarina","mango","manzana","maracuyá","melocotón","melón","membrillo","mora","naranja","níspero","papaya","pera","piña","plátano","pomelo","sandía","uva","alcachofa","apio","batata","berenjena","brócoli","calabacín","calabaza","cebolla","champiñón","coliflor","espárrago","espinaca","judía","lechuga","patata","pepino","pimiento","puerro","rábano","remolacha","repollo","zanahori"
            };
            numOfRamdom = randomLetters.Next(texto.Count);
            return texto[numOfRamdom].ToString();
        }
        public static int GetNumber(int num)
        {
            string n = "1";
            int resultado;
            for (int i = 1; i < num; i++)
            {
                n += "0";
            }
            resultado = int.Parse(n);
            return resultado;
        }

    }
}
