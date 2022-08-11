namespace tp7;
    public static class program{
        public static int Main(string[] args)
        {
            //Creacion de listas;
            List<Tarea> listaTareas= new List<Tarea>();
            List<Tarea> tareasPendientes= new List<Tarea>();
            List<Tarea> tareasRealizadas= new List<Tarea>();

            cargarListaTareas(listaTareas);
            mostrarListaTareas(listaTareas);
            Console.ReadKey();
            Console.Clear();
            gestorTareas(listaTareas, tareasRealizadas, tareasPendientes);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\nTareas Realizadas: ");
            mostrarListaTareas(tareasRealizadas);
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\ntareas Pendientes");
            mostrarListaTareas(tareasPendientes);
            Console.ReadKey();
            Console.Clear();
            horasTrabajadas(tareasRealizadas);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Buscar tarea");
            Console.Write("Ingrese la descripcion buscada: ");
            string buscar= Console.ReadLine();
            Console.WriteLine("Buscar en tareas realizadas: ");
            buscarTarea(tareasRealizadas, buscar);
            // Console.WriteLine("");
            Console.WriteLine("Buscar en tareas pendientes: ");
            buscarTarea(tareasPendientes, buscar);
            
            return 0;
            void cargarListaTareas(List<Tarea> listaTareas)
            {
                int cantiTareas;
                string tareaDescripcion;
                var rand= new Random();
                Console.Write("Cuantas taeas desea cargar? ->");
                cantiTareas= Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantiTareas; i++)
                {
                    Console.WriteLine("Ingrese una descripcion de la tarea: ");
                    tareaDescripcion= Console.ReadLine();

                    Tarea nuevaTarea= new Tarea(i+1,tareaDescripcion, rand.Next(10,101));
                    listaTareas.Add(nuevaTarea);
                }
            }
            void mostrarListaTareas(List<Tarea> listaTareas)
            {
                if(listaTareas.Any()){
                    //Console.WriteLine("\ntrue\n");
                    foreach (var tarea in listaTareas)
                    {
                        tarea.MostrarTarea();
                        
                    }
                }else{
                    // Console.WriteLine("\nfalse\n");
                    Console.WriteLine("Lista Vacia, sin tareas.");
                }
            }
            void gestorTareas(List<Tarea> listaTarea, List<Tarea> listaTareaR, List<Tarea> listaTareaP)
            {
                int opcion;
                Console.WriteLine("Organice las tareas segun su estado: ");
                for(int i= 0; i< listaTarea.Count; i++)
                {
                    listaTarea[i].MostrarTarea();
                    Console.WriteLine("1 -> Realizada\n2 -> Pendiente");
                    opcion= Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1 || opcion == 2)
                    {
                        Tarea nuevaTarea= new Tarea(listaTarea[i].IdTarea,listaTarea[i].DescripcionTarea,listaTarea[i].DuracionTarea);
                        switch (opcion)
                        {
                            case 1:
                                listaTareaR.Add(nuevaTarea);
                                break;
                            case 2:
                                //Tarea nuevaTarea= new Tarea(listaTarea[i].IdTarea,listaTarea[i].DescripcionTarea,listaTarea[i].DuracionTarea);
                                listaTareaP.Add(nuevaTarea);
                                break;
                            default:
                                Console.WriteLine("ERROR!!!");
                                break;
                        }
                    }else{
                        Console.WriteLine("Error, opcion equivocada");
                    }

                }
            }
            void buscarTarea(List<Tarea> listaTarea, string buscar)
            {

                int cont= 0;
                for (int i = 0; i < listaTarea.Count(); i++)
                {
                    if (listaTarea[i].DescripcionTarea.Contains(buscar))
                    {
                        cont++;
                    }
                }
                if(cont > 0)
                {
                    Console.WriteLine("Encontrada.\n");
                }
                else
                {
                    Console.WriteLine("No se encontro");
                }
                
            }
            void horasTrabajadas(List<Tarea> listaTarea)
            {
                int hsTrabajadas= 0;
                for(int i= 0; i < listaTarea.Count(); i++)
                {
                    hsTrabajadas+= listaTarea[i].DuracionTarea;
                }
                Console.WriteLine("Horas trabajadas: " + hsTrabajadas);
            }
        }
    }