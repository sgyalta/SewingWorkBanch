using PassportView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportView.Controller
{
    public class Repositer
    {
        private DbPassportContext Connect = new DbPassportContext();

        public List<Customer> GetCustomers()
        {
            return Connect.Customers.ToList();
        }

        public List<Category> GetCategories()
        {
            return Connect.Categories.ToList();
        }

        public List<Employee> GetEmployee(int idDepartment)
        {
            return Connect.Employees.Where(x => x.Position.DepartmentId == idDepartment).ToList();
        }

        public List<ProductType> GetProductType()
        {
            return Connect.ProductTypes.ToList();
        }

        public List<Color> GetColor()
        {
            return Connect.Colors.ToList();
        }

        public List<Size> GetSize()
        {
            return Connect.Sizes.ToList();
        }
    }
}
