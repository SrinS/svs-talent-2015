using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestProject.BusinessLayer;
using TestProject.BusinessLayer.Contracts;
using TestProject.BusinessLayer.Handlers;
using TestProject.DAL.Configuration;
using TestProject.DAL.Model;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class BikeController : Controller
    {
        // GET: Bike
        /// <summary>
        /// Init bike page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var context = new BikeRegisterContext();
            var result = context.Bikes;
            InitDropDownList();
            return View();
        }

        /// <summary>
        /// POST data in controler
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateBike(FormCollection form)
        {
            BikeSaveCommand bike = new BikeSaveCommand();

            bike.Model = form[0].Remove(0, 1);
            bike.Tip = form[1].Remove(0, 1);
            bike.SeriskiBroj = form[2].Remove(0, 1);
            bike.Grad = form[3].Remove(0, 1);
            bike.Flag = form[4].Remove(0, 1);
            bike.BrojNaBrizini = Convert.ToInt32(form[5].Remove(0, 1));
            bike.Boja1 = form[6].Remove(0, 1);
            bike.Boja2 = form[7].Remove(0, 1);
            bike.MaterijalNaRamka = form[8].Remove(0, 1);

            BikeSaveCommandHandler _command = new BikeSaveCommandHandler();
            _command.Execute(bike);
            //using( var context = new BikeRegisterContext())
            //{
            //    context.Bikes.Add(bike);
            //    context.SaveChanges();
            //}
            return RedirectToAction("Index", "Bike");
        }
        private void InitDropDownList()
        {
            List<SelectListItem> listaCity = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text=null,
                    Value=null
                },
                new SelectListItem{
                    Text="Stip",
                    Value="Stip"
                },
                 new SelectListItem{
                    Text="Skopje",
                    Value="Skopje"
                },
                 new SelectListItem{
                    Text="Radovis",
                    Value="Radovis"
                },
                 new SelectListItem{
                    Text="Tetovo",
                    Value="Tetovo"
                },
                 new SelectListItem{
                    Text="Kicevo",
                    Value="Kicevo"
                },
                 new SelectListItem{
                    Text="Bitola",
                    Value="Bitola"
                },
                new SelectListItem{
                    Text="Veles",
                    Value="Veles"
                },
                new SelectListItem{
                    Text="Kumanovo",
                    Value="Kumanovo"
                },
                new SelectListItem{
                    Text="Prilep",
                    Value="Prilep"
                },
                new SelectListItem{
                    Text="Ohrid",
                    Value="Ohrid"
                },
                new SelectListItem{
                    Text="Gostivar",
                    Value="Gostivar"
                },
                new SelectListItem{
                    Text="Strumica",
                    Value="Strumica"
                },
                new SelectListItem{
                    Text="Kavadarci",
                    Value="Kavadarci"
                },
              new SelectListItem{
                    Text="Kocani",
                    Value="Kocani"
                },
              
                 new SelectListItem{
                    Text="Struga",
                    Value="Struga"
                },
                 new SelectListItem{
                    Text="Gevgelija",
                    Value="Gevgelija"
                },
                 new SelectListItem{
                    Text="Debar",
                    Value="Debar"
                },
                 new SelectListItem{
                    Text="Kriva Planaka",
                    Value="Kriva Palanka"
                },
                 new SelectListItem{
                    Text="Sveti NIkole",
                    Value="Sveti NIkole"
                },
                 new SelectListItem{
                    Text="Negotino",
                    Value="Negotino"
                },
                 new SelectListItem{
                    Text="Delcevo",
                    Value="Delcevo"
                },
                 new SelectListItem{
                    Text="Vinica",
                    Value="Vinica"
                },
                 new SelectListItem{
                    Text="Resen",
                    Value="Resen"
                },
                 new SelectListItem{
                    Text="Proistip",
                    Value="Probistip"
                },
                 new SelectListItem{
                    Text="Berovo",
                    Value="Berovo"
                },
                new SelectListItem{
                    Text="Kratovo",
                    Value="Kratovo"
                },
                new SelectListItem{
                    Text="Krusevo",
                    Value="Krusevo"
                },
                new SelectListItem{
                    Text="Makedonski Brod",
                    Value="Makedonski Brod"
                },
                new SelectListItem{
                    Text="Valandovo",
                    Value="Valandovo"
                },
                new SelectListItem{
                    Text="Demir Hisar",
                    Value="Demir Hisar"
                }
            };
            ViewBag.City = listaCity;

            List<SelectListItem> listaFlag = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text=null,
                    Value=null
                },
                new SelectListItem
                {
                    Text="Regularen",
                    Value="Regularen"
                },
                  new SelectListItem
                {
                    Text="Ukraden",
                    Value="Ukraden"
                },
                  new SelectListItem
                {
                    Text="Izguben",
                    Value="Izguben"
                },
                  new SelectListItem
                {
                    Text="Za Prodazba ",
                    Value="Za Prodazba "
                }
            };
            ViewBag.Flags = listaFlag;

            List<SelectListItem> listaBoja = new List<SelectListItem>
            {   
                new SelectListItem
                {
                    Text=null,
                    Value=null
                },
                 new SelectListItem
                {
                    Text="Crven",
                    Value="Crven"
                },
                 new SelectListItem
                {
                    Text="Bel",
                    Value="Bel"
                },
                 new SelectListItem
                {
                    Text="Zolt",
                    Value="Zolt"
                },
                 new SelectListItem
                {
                    Text="Plav",
                    Value="Plav"
                },
                 new SelectListItem
                {
                    Text="Zelen",
                    Value="Plav"
                },
                 new SelectListItem
                {
                    Text="Crn",
                    Value="Crn"
                },
                 new SelectListItem
                {
                    Text="Siv",
                    Value="Siv"
                },
                 new SelectListItem
                {
                    Text="Crven",
                    Value="Crven"
                },
                 new SelectListItem
                {
                    Text="Portokalov",
                    Value="Portokalov"
                },
                 new SelectListItem
                {
                    Text="Liljakov",
                    Value="Liljakov"
                },
                 new SelectListItem
                {
                    Text="Rozev",
                    Value="Rozev"
                },
            };
            ViewBag.Colors = listaBoja;


            List<SelectListItem> listMaterijali = new List<SelectListItem>
            {
                new SelectListItem{
                    Text=null,
                    Value=null
                },
                new SelectListItem
                {
                    Text="Aluminium",
                    Value="Aluminium"
                },new SelectListItem
                {
                    Text="Titanium",
                    Value="Titanium"
                },new SelectListItem
                {
                    Text="Plastic",
                    Value="Plastic"
                },new SelectListItem
                {
                    Text="Drugo",
                    Value="Drugo"
                }
            };
            ViewBag.Matrijali = listMaterijali;


        }


        public ActionResult UploadPhoto(string Image,
        HttpPostedFileBase photo)
        {
            string path = @" " + Image;

            if (photo != null)
                photo.SaveAs(path);

            return RedirectToAction("Index");
        }
    }

}
