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

        [HttpPost]
        public JsonResult AlmacenarJugador(RegistroModel model)
        {
            ErrorModel response = new ErrorModel();
            try
            {
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                jugadoresService.InsertarJugador(model, dbConn);
                response.CodigoError = 1;
                response.DescripcionError = "OK";

                return Json(response);
            }
            catch (BusinessException ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
            catch (Exception ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }            
        }

        [HttpPost]
        public JsonResult ConsultarJugador(RegistroModel model)
        {
            ErrorModel response = new ErrorModel();
            try
            {
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                JugadoresModel jugador = jugadoresService.ConsultarJugadoresPorIdentificacion(model, dbConn);
                return Json(jugador);
            }
            catch (BusinessException ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
            catch (Exception ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
        }

        [HttpPost]
        public JsonResult EditarJugador(RegistroModel model)
        {
            ErrorModel response = new ErrorModel();
            try
            {
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                jugadoresService.ActualizarJugador(model, dbConn);
                response.CodigoError = 1;
                response.DescripcionError = "OK";

                return Json(response);
            }
            catch (BusinessException ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
            catch (Exception ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
        }

        [HttpPost]
        public JsonResult EliminarJugador(RegistroModel model)
        {
            ErrorModel response = new ErrorModel();
            try
            {
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                jugadoresService.EliminarJugador(model.TipoIdentificacionJugador, model.IdentificacionJugador, dbConn);
                response.CodigoError = 1;
                response.DescripcionError = "OK";

                return Json(response);
            }
            catch (BusinessException ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
            catch (Exception ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
        }

        public IActionResult Simulador()
        {
            try
            {
                SimuladorModel modelo = new SimuladorModel();
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

        [HttpPost]
        public JsonResult ActualizarDisponibles(string registrosActualizar)
        {
            ErrorModel response = new ErrorModel();
            try
            {
                jugadoresService = new JugadoresService();
                string dbConn = _config.GetSection("General").GetSection("PathDB").Value;
                jugadoresService.ActualizarDisponible(registrosActualizar, dbConn);
                response.CodigoError = 1;
                response.DescripcionError = "OK";

                return Json(response);
            }
            catch (BusinessException ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
            catch (Exception ex)
            {
                response.CodigoError = 2;
                response.DescripcionError = ex.Message;
                return Json(response);
            }
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
