using System;
using NUnit.Framework;
using CollectionsLib;
using System.Linq;

namespace CollectionsLibTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Getemployee_nullvalue_false()
        {
            EmployeeManager em = new EmployeeManager();
            var contain_null = em.GetEmployees().Contains(null);
            Assert.AreEqual(contain_null, false);

        }
        [Test]
        public void Employeeid_100_exists()
        {
            EmployeeManager em = new EmployeeManager();
            var empid = em.GetEmployees();
            int id = empid.Where(e => e.EmpId == 100).Count();
            Assert.That(id, Is.EqualTo(1));
        }

        [Test]
        public void Getemployee_unique_true()
        {
            EmployeeManager em = new EmployeeManager();
            var empid = em.GetEmployees();
            var unique = empid.Distinct().Count();
            Assert.That(unique, Is.EqualTo(empid.Count));
        }

        [Test]
        public void Getemployee_sameitems_true()
        {
            EmployeeManager em = new EmployeeManager();
            var geo = em.GetEmployees();
            var gepyo = em.GetEmployeesWhoJoinedInPreviousYears();
            Assert.That(geo, Is.EquivalentTo(gepyo));
        }
    }
}
