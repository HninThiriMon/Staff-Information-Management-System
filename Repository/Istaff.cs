using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffInformationManagementSystem.Models;

namespace StaffInformationManagementSystem.Repository
{
    interface Istaff
    {
        void InsertStaffRecord(Staff staff);
        IEnumerable<Staff> getStaff();
        void UpdateStaffRecord(Staff staff);
        void DeleteStaffRecord(int staffid);
        Staff GetStaffId(int staffid);

    }
}
