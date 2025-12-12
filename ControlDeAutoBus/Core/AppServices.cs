using ControlDeAutoBus.Controller;
using ControlDeAutoBus.Domain.Services;
using ControlDeAutoBus.Domain.Services.Interface;
using ControlDeAutoBus.Domain.SharedInterfaces;
using ControlDeAutoBus.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAutoBus.Core
{
    public static class AppServices
    {
        public static BusController BusController { get; private set; }
        public static ChoferesController ChoferesController { get; private set; }
        public static RutasController RutasController { get; private set; }

        public static void Init()
        {
            IBusRepository busRepository = new BusRepository();
            IBusServices service = new BusServices(busRepository);
            BusController = new BusController(service);

            IChoferRepository choferesRepository = new ChoferRepository();
            IChoferesServices choferesService = new ChoferesServices(choferesRepository);
            ChoferesController = new ChoferesController(choferesService);

            IRouteRepository rutasRepository = new RouteRepository();
            IRoutesServices rutasService = new RoutesServices(rutasRepository);
            RutasController = new RutasController(rutasService);


        }
    }
}
