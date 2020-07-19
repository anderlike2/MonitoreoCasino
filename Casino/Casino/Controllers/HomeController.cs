using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Casino.Models;
using Casino.Common;
using Microsoft.Extensions.Configuration;
using Casino.Services;

namespace Casino.Controllers
{
    public class HomeController : Controller
    {
        JugadoresService jugadoresService;

        private readonly IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jugadores()
        {
            try
            {
                RegistroModel modelo = new RegistroModel();
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                
                //Se consulta los jugadores del sistema
                modelo.lstJugadores = jugadoresService.ConsultarJugadores(dbConn);

                ViewData["Message"] = Constantes.TituloJugadores;
                return View(modelo);
            }
            catch (BusinessException ex)
            {
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }

        }

        public IActionResult Simulador()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
