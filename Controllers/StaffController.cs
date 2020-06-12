using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaffInformationManagementSystem.Models;
using StaffInformationManagementSystem.Repository;

namespace StaffInformationManagementSystem.Controllers
{
    //[Authorize]
    public class StaffController : Controller
    {

        private Istaff istaff;
        public StaffController()
        {
            this.istaff = new RepositoryStaffClass(new DBSIMSEntities());
        }

        // GET: Staff
        public ActionResult Index()
        {
            var stafflist = istaff.getStaff().ToList();
            return View(stafflist);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            var getstaff = istaff.GetStaffId(id);
            var staffdisplay = new Staff();
            staffdisplay.Id = getstaff.Id;
            staffdisplay.Name = getstaff.Name;
            staffdisplay.Photo = getstaff.Photo;
            staffdisplay.Email = getstaff.Email;
            staffdisplay.Phone = getstaff.Phone;
            staffdisplay.Fax = getstaff.Fax;
            staffdisplay.Internet = getstaff.Internet;
            staffdisplay.Remark = getstaff.Remark;
            staffdisplay.AddressType = getstaff.AddressType;
            staffdisplay.Address = getstaff.Address;
            staffdisplay.City = getstaff.City;
            staffdisplay.Country = getstaff.Country;
            staffdisplay.PostalCode = getstaff.PostalCode;
            staffdisplay.DOB = getstaff.DOB;
            staffdisplay.NRC = getstaff.NRC;
            staffdisplay.CreatedDate = getstaff.CreatedDate;
            staffdisplay.CreatedBy = getstaff.CreatedBy;
            staffdisplay.ModifiedDate = getstaff.ModifiedDate;
            staffdisplay.ModifiedBy = getstaff.ModifiedBy;
            return View(staffdisplay);
        }

        // GET: Staff/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Staff());
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Staff staffinsert)
        {
            try
            {
                // TODO: Add insert logic here
                var addstaff = new Staff();
                addstaff.Name = staffinsert.Name;
                addstaff.Photo = staffinsert.Photo;
                addstaff.Email = staffinsert.Email;
                addstaff.Phone = staffinsert.Phone;
                addstaff.Fax = staffinsert.Fax;
                addstaff.Internet = staffinsert.Internet;
                addstaff.Remark = staffinsert.Remark;
                addstaff.AddressType = staffinsert.AddressType;
                addstaff.Address = staffinsert.Address;
                addstaff.City = staffinsert.City;
                addstaff.Country = staffinsert.Country;
                addstaff.PostalCode = staffinsert.PostalCode;
                addstaff.DOB = staffinsert.DOB;
                addstaff.NRC = staffinsert.NRC;
                addstaff.CreatedDate = staffinsert.CreatedDate;
                addstaff.CreatedBy = staffinsert.CreatedBy;
                addstaff.ModifiedDate = staffinsert.ModifiedDate;
                addstaff.ModifiedBy = staffinsert.ModifiedBy;
                istaff.InsertStaffRecord(addstaff);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var getstaff = istaff.GetStaffId(id);
            var staffdisplay = new Staff();
            staffdisplay.Id = getstaff.Id;
            staffdisplay.Name = getstaff.Name;
            staffdisplay.Photo = getstaff.Photo;
            staffdisplay.Email = getstaff.Email;
            staffdisplay.Phone = getstaff.Phone;
            staffdisplay.Fax = getstaff.Fax;
            staffdisplay.Internet = getstaff.Internet;
            staffdisplay.Remark = getstaff.Remark;
            staffdisplay.AddressType = getstaff.AddressType;
            staffdisplay.Address = getstaff.Address;
            staffdisplay.City = getstaff.City;
            staffdisplay.Country = getstaff.Country;
            staffdisplay.PostalCode = getstaff.PostalCode;
            staffdisplay.DOB = getstaff.DOB;
            staffdisplay.NRC = getstaff.NRC;
            staffdisplay.CreatedDate = getstaff.CreatedDate;
            staffdisplay.CreatedBy = getstaff.CreatedBy;
            staffdisplay.ModifiedDate = getstaff.ModifiedDate;
            staffdisplay.ModifiedBy = getstaff.ModifiedBy;
            return View(staffdisplay);

        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(Staff staffupdate, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                istaff.UpdateStaffRecord(staffupdate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            var staffdel = istaff.GetStaffId(id);
            return View(staffdel);
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                istaff.DeleteStaffRecord(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
