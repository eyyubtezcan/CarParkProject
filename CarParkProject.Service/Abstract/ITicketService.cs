using CarParkProject.Domain.EntityModels;
using CarParkProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Service.Abstract
{
    public interface ITicketService
    {
        List<Ticket> GetTickets();
        Ticket GetTicket(int id);
        ServiceResult<Ticket> GetTicket(Ticket ticket);
        ServiceResult<Ticket> CheckInTicket(Vehicle vehicle);
        ServiceResult<Ticket> CheckOutTicket(Vehicle vehicle);
    }
}
