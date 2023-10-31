using System.Text;
#region Clase 11 - Modificadores de acceso
//namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
//{
//    class SuperHeroe
//    {
//        public int Id;
//        public string Nombre;
//        public string IdentidadSecreta;
//        public String Ciudad;
//        public List<SuperPoder> SuperPoderes;
//        public bool PuedeVolar;

//        public SuperHeroe()
//        {
//            Id = 1;
//            SuperPoderes = new List<SuperPoder>();
//            PuedeVolar = false;
//        }

//        public string UsarSuperPoderes()
//        {
//            StringBuilder sb = new StringBuilder();

//            foreach (var item in SuperPoderes)
//            {
//                sb.AppendLine($"{Nombre} está usando el super poder {item.Nombre}!!");
//            }

//            return sb.ToString();
//        }
//    }
//}
#endregion

#region Clase 12 - Encapsulamientos
//namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
//{
//    class SuperHeroe
//    {
//        private string _Nombre;

//        public int Id;
//        public string Nombre
//        {
//            get
//            {
//                return _Nombre;
//            }

//            set
//            {
//                _Nombre = value.Trim();
//            }
//        }

//        public string NombreEidentidadSecreta
//        {
//            get
//            {
//                return $"{_Nombre} ({IdentidadSecreta})";
//            }
//        }

//        public string IdentidadSecreta;
//        public String Ciudad;
//        public List<SuperPoder> SuperPoderes;
//        public bool PuedeVolar;

//        public SuperHeroe()
//        {
//            Id = 1;
//            SuperPoderes = new List<SuperPoder>();
//            PuedeVolar = false;
//        }

//        public string UsarSuperPoderes()
//        {
//            StringBuilder sb = new StringBuilder();

//            foreach (var item in SuperPoderes)
//            {
//                sb.AppendLine($"{NombreEidentidadSecreta} está usando el super poder {item.Nombre}!!");
//            }

//            return sb.ToString();
//        }
//    }
//}
#endregion

#region Clase 15 - Abstracción
//namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
//{
//    class SuperHeroe: Heroe
//    {
//        private string _Nombre;

//        public int Id;
//        public override string Nombre
//        {
//            get
//            {
//                return _Nombre;
//            }

//            set
//            {
//                _Nombre = value.Trim();
//            }
//        }

//        public string NombreEidentidadSecreta
//        {
//            get
//            {
//                return $"{_Nombre} ({IdentidadSecreta})";
//            }
//        }

//        public string IdentidadSecreta;
//        public String Ciudad;
//        public List<SuperPoder> SuperPoderes;
//        public bool PuedeVolar;

//        public SuperHeroe()
//        {
//            Id = 1;
//            SuperPoderes = new List<SuperPoder>();
//            PuedeVolar = false;
//        }

//        public string UsarSuperPoderes()
//        {
//            StringBuilder sb = new StringBuilder();

//            foreach (var item in SuperPoderes)
//            {
//                sb.AppendLine($"{NombreEidentidadSecreta} está usando el super poder {item.Nombre}!!");
//            }

//            return sb.ToString();
//        }

//        public override string SalvarElMundo()
//        {
//            return $"{NombreEidentidadSecreta} ha salvado el mundo";
//        }
//    }
//}
#endregion

#region Clase 16 - Polimorfismo
namespace cursoDeProgramacionOrientadaAObjetosConCSharp.Models
{
    class SuperHeroe : Heroe
    {
        private string _Nombre;

        public int Id;
        public override string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEidentidadSecreta
        {
            get
            {
                return $"{_Nombre} ({IdentidadSecreta})";
            }
        }

        public string IdentidadSecreta;
        public String Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEidentidadSecreta} está usando el super poder {item.Nombre}!!");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEidentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();

            return $"{NombreEidentidadSecreta} ha salvado la tierra";
        }
    }
}
#endregion