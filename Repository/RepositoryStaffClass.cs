using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffInformationManagementSystem.Models;

namespace StaffInformationManagementSystem.Repository
{
    public class RepositoryStaffClass : Istaff
    {
        private DBSIMSEntities dBSIMSEntities;
    
        public RepositoryStaffClass(DBSIMSEntities dBSIMSEntities)
        {
            this.dBSIMSEntities = dBSIMSEntities;
        }

        public void DeleteStaffRecord(int staffid)
        {
            Staff delstaff = dBSIMSEntities.Staffs.Find(staffid);
            dBSIMSEntities.Staffs.Remove(delstaff);
            dBSIMSEntities.SaveChanges();
        }

        public Staff GetStaffId(int staffid)
        {
            return dBSIMSEntities.Staffs.Find(staffid);
        }


        public IEnumerable<Staff> getStaff()
        {
            return dBSIMSEntities.Staffs.ToList();
        }

      

        public void InsertStaffRecord(Staff staff)
        {
            dBSIMSEntities.Staffs.Add(staff);
            dBSIMSEntities.SaveChanges();
            
        }

        public void UpdateStaffRecord(Staff staff)
        {
            dBSIMSEntities.Entry(staff).State = System.Data.Entity.EntityState.Modified;
            dBSIMSEntities.SaveChanges();
        }
    }
}