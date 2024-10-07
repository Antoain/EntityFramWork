using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public NorthwindEntities contexto = new NorthwindEntities();

        public List<Customers> ObtenerTodos() 
        { 
            var cliente = from custM in contexto.Customers select custM;
            return cliente.ToList();
        
        }

        public Customers ObtenerporID(string id) 
        {
            var clientes = from cm in contexto.Customers where cm.CustomerID == id select cm ;
            return clientes.FirstOrDefault();   
        }

        public int InsertarCliente(Customers customer) 
        {
            contexto.Customers.Add(customer);
            return contexto.SaveChanges();  
        }

        public int UpdateCliente(Customers customer) 
        {
            var registro = ObtenerporID(customer.CustomerID);
            if (registro != null) 
            { 
                registro.CustomerID = customer.CustomerID;  
                registro.ContactTitle = customer.ContactTitle;
                registro.Address = customer.Address;    
                registro.ContactName = customer.ContactName;
                registro.CompanyName = customer.CompanyName;
            }
            return contexto.SaveChanges();
                
        }

        public int DeleteCliente(string id)
        {
            var registro = ObtenerporID(id);
            if (registro != null)
            {
                contexto.Customers.Remove(registro);
                return contexto.SaveChanges();
            }
            return 0;
        }
              
    }
}
